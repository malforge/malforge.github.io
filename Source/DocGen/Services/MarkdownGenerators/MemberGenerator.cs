using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DocGen.Services.Markdown;

namespace DocGen.Services.MarkdownGenerators
{
    internal class MemberGenerator : DocumentGenerator
    {
        public enum IgnoreReason
        {
            No,
            NoLinkNeeded,
            Prohibited
        }
        //static bool IsMsType(MemberInfo memberInfo)
        //{
        //    var assembly = memberInfo.GetAssembly();
        //    if (assembly.GetName().Name == "mscorlib")
        //        return true;
        //    var companyAttribute = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
        //    if (companyAttribute?.Company == "Microsoft Corporation")
        //        return true;
        //    return false;
        //}

        public static string LinkTo(string text, ApiEntry entry)
        {
            string escape(string s)
            {
                return s;
            } /*Regex.Replace(s, @"[<>[\]]", match =>
            {
                var v = match.ToString();
                switch (v)
                {
                    case "<":
                        return "&lt;";
                    case ">":
                        return "&gt;";
                    case "[":
                        return "&#91";
                    case "]":
                        return "&#93;";
                    default:
                        return $"\\{v}";
                }
            });*/

            text = escape(text);

            switch (ShouldBeIgnored(entry))
            {
                case IgnoreReason.NoLinkNeeded:
                    return text;
                case IgnoreReason.Prohibited:
                    return text + " <sub>prohibited</sub>";
            }

            if (MicrosoftLink.IsMsType(entry.Member))
            {
                var type = entry.Member as Type;
                var fullName = entry.FullName;
                if (type != null)
                {
                    if (type.IsGenericType && !type.IsGenericTypeDefinition)
                        type = type.GetGenericTypeDefinition();
                    fullName = type.FullName?.Replace('`', '-');
                }

                return MarkdownInline.HRef(text, escape($"https://docs.microsoft.com/en-us/dotnet/api/{fullName}?view=netframework-4.6"));
            }

            return MarkdownInline.HRef(text, escape(Path.GetFileNameWithoutExtension(entry.SuggestedFileName)));
        }

        public static IgnoreReason ShouldBeIgnored(ApiEntry apiEntry)
        {
            //if (!apiEntry.IsWhitelisted)
            //    return true;
            if (apiEntry.Member.DeclaringType?.IsEnum ?? false)
                return IgnoreReason.NoLinkNeeded;
            if (apiEntry.Member.DeclaringType?.FullName == "Sandbox.Game.Localization.MySpaceTexts")
                return IgnoreReason.NoLinkNeeded;
            if (apiEntry.Member.DeclaringType?.FullName == "VRageMath.Color")
                return IgnoreReason.NoLinkNeeded;
            if (!apiEntry.IsWhitelisted)
                return IgnoreReason.Prohibited;
            return IgnoreReason.No;
        }

        public override async Task Generate(DirectoryInfo directory, ProgrammableBlockApi api, Func<string, bool> includesPage)
        {
            var groups = api.Entries
                .Where(e => !(e.Member is Type) && ShouldBeIgnored(e) == IgnoreReason.No)
                .GroupBy(e => e.SuggestedFileName)
                .Where(g => includesPage(g.Key))
                .ToList(); // Materialize to check for issues

            var tasks = groups.Select(g => GeneratePage(api, directory, g));
            await Task.WhenAll(tasks);
        }

        async Task GeneratePage(ProgrammableBlockApi api, DirectoryInfo directory, IGrouping<string, ApiEntry> entries)
        {
            var fileName = FileHelpers.ToLongPathSafe(Path.Combine(directory.FullName, entries.Key));
            // Try creating the file. If we're not allowed to share, wait a bit and try again, for a while.
            StreamWriter file = null;
            var attempts = 0;
            while (file == null && attempts < 5)
            {
                try
                {
                    file = File.CreateText(fileName);
                }
                catch (IOException)
                {
                    attempts++;
                    await Task.Delay(100 * attempts);
                }
            }

            if (file == null) throw new IOException("Could not create file " + fileName + " after multiple attempts.");
            using (file)
            {
                var writer = new MarkdownWriter(file);
                // var firstEntry = entries.First();
                // await writer.BeginParagraphAsync();
                // await writer.WriteAsync($"← {MarkdownInline.HRef("Index", "Api-Index")} ← {MarkdownInline.HRef("Namespace Index", "Namespace-Index")} ← {LinkTo(firstEntry.DeclaringEntry.ToString(ApiEntryStringFlags.ShortDisplayName), firstEntry.DeclaringEntry)}");
                // await writer.EndParagraphAsync();

                foreach (var overload in entries)
                {
                    await writer.WriteHeaderAsync(2, "Summary");
                    switch (overload.Member)
                    {
                        case ConstructorInfo constructorInfo:
                            await WriteConstructor(api, overload, writer, constructorInfo);
                            break;
                        case FieldInfo fieldInfo:
                            await WriteField(api, overload, writer, fieldInfo);
                            break;
                        case PropertyInfo propertyInfo:
                            await WriteProperty(api, overload, writer, propertyInfo);
                            break;
                        case EventInfo eventInfo:
                            await WriteEvent(api, overload, writer, eventInfo);
                            break;
                        case MethodInfo methodInfo:
                            await WriteMethod(api, overload, writer, methodInfo);
                            break;
                    }
                }

                await writer.FlushAsync();
            }
        }

        /// <summary>
        ///     Returns a type reference with the type, each of its generic arguments and its array element type
        ///     linked separately.
        /// </summary>
        static string LinkToType(ProgrammableBlockApi api, Type type) => LinkToType(api, type, "");

        /// <summary>
        ///     Returns a type reference with <paramref name="suffix" />, the nullable mark and array brackets, written
        ///     straight after the type name, ahead of any prohibited marker.
        /// </summary>
        static string LinkToType(ProgrammableBlockApi api, Type type, string suffix)
        {
            if (type.IsGenericParameter)
                return type.Name + suffix;
            if (type.IsByRef)
                return LinkToType(api, type.GetElementType(), suffix);
            if (type.IsArray)
                return LinkToType(api, type.GetElementType(), $"[{new string(',', type.GetArrayRank() - 1)}]{suffix}");
            var nullableBase = Nullable.GetUnderlyingType(type);
            if (nullableBase != null)
                return LinkToType(api, nullableBase, "?" + suffix);

            if (!type.IsGenericType)
            {
                var entry = api.GetEntry(type, true);
                return entry == null ? type.Name + suffix : LinkTo(entry.ToString(ApiEntryStringFlags.ShortDisplayName) + suffix, entry);
            }

            var definition = type.GetGenericTypeDefinition();
            var definitionEntry = api.GetEntry(definition, true);
            var name = LinkToGenericName(api, definition, type.GetGenericArguments());
            if (definitionEntry != null && ShouldBeIgnored(definitionEntry) == IgnoreReason.Prohibited)
                return $"{name}{suffix} <sub>prohibited</sub>";
            return name + suffix;
        }

        /// <summary>
        ///     Returns the name of a constructed generic type, preceded by its generic declaring type, each linked to the
        ///     page of its definition unless prohibited.
        /// </summary>
        static string LinkToGenericName(ProgrammableBlockApi api, Type definition, Type[] arguments)
        {
            // A type nested in a generic type carries the declaring type's arguments ahead of its own.
            var prefix = "";
            var declaringType = definition.DeclaringType;
            if (declaringType != null && declaringType.IsGenericTypeDefinition)
            {
                var declaringCount = declaringType.GetGenericArguments().Length;
                prefix = LinkToGenericName(api, declaringType, arguments.Take(declaringCount).ToArray()) + ".";
                arguments = arguments.Skip(declaringCount).ToArray();
            }

            var entry = api.GetEntry(definition, true);
            var name = entry?.ToString(ApiEntryStringFlags.ShortDisplayName & ~ApiEntryStringFlags.GenericParameters) ?? definition.Name.Split('`')[0];
            if (entry != null && ShouldBeIgnored(entry) != IgnoreReason.Prohibited)
                name = LinkTo(name, entry);
            if (arguments.Length == 0)
                return prefix + name;

            // The angle brackets are encoded because the browser takes a raw <Name> for an HTML tag and drops it.
            return $"{prefix}{name}&lt;{string.Join(", ", arguments.Select(argument => LinkToType(api, argument)))}&gt;";
        }

        async Task WriteMethod(ProgrammableBlockApi api, ApiEntry overload, MarkdownWriter writer, MethodInfo methodInfo)
        {
            await writer.BeginCodeBlockAsync();
            await writer.WriteLineAsync(overload.ToString(ApiEntryStringFlags.Modifiers | ApiEntryStringFlags.GenericParameters | ApiEntryStringFlags.ParameterTypes | ApiEntryStringFlags.ParameterNames | ApiEntryStringFlags.ReturnValue | ApiEntryStringFlags.Accessors));
            await writer.EndCodeBlockAsync();
            if (overload.Documentation?.Summary != null)
                await WriteDocumentation(api, overload.Documentation?.Summary, writer);
            if (methodInfo.ReturnType != typeof(void))
            {
                await writer.WriteHeaderAsync(2, "Returns");
                await writer.BeginParagraphAsync();
                await writer.WriteAsync(LinkToType(api, methodInfo.ReturnType));
                await writer.EndParagraphAsync();
                if (overload.Documentation?.Returns != null)
                    await WriteDocumentation(api, overload.Documentation?.Returns, writer);
            }

            var parameters = methodInfo.GetParameters();
            if (parameters.Length > 0)
            {
                await writer.WriteHeaderAsync(2, "Parameters");
                foreach (var parameter in parameters)
                {
                    await writer.WriteAsync("* ");
                    await writer.WriteAsync(LinkToType(api, parameter.GetActualParameterType()));
                    await writer.WriteAsync(" ");
                    await writer.WriteAsync(parameter.Name);
                    await writer.WriteLineAsync();
                }
            }

            if (overload.Documentation?.Example != null)
            {
                await writer.WriteHeaderAsync(2, "Example");
                await WriteDocumentation(api, overload.Documentation?.Example, writer);
            }

            if (overload.Documentation?.Remarks != null)
            {
                await writer.WriteHeaderAsync(2, "Remarks");
                await WriteDocumentation(api, overload.Documentation?.Remarks, writer);
            }
        }

        async Task WriteProperty(ProgrammableBlockApi api, ApiEntry overload, MarkdownWriter writer, PropertyInfo propertyInfo)
        {
            await writer.BeginCodeBlockAsync();
            await writer.WriteLineAsync(overload.ToString(ApiEntryStringFlags.Modifiers | ApiEntryStringFlags.GenericParameters | ApiEntryStringFlags.ParameterTypes | ApiEntryStringFlags.ParameterNames | ApiEntryStringFlags.ReturnValue | ApiEntryStringFlags.Accessors));
            await writer.EndCodeBlockAsync();
            if (overload.Documentation?.Summary != null)
                await WriteDocumentation(api, overload.Documentation?.Summary, writer);
            await writer.WriteHeaderAsync(2, "Returns");
            await writer.BeginParagraphAsync();
            await writer.WriteAsync(LinkToType(api, propertyInfo.PropertyType));
            await writer.EndParagraphAsync();
            if (overload.Documentation?.Returns != null)
                await WriteDocumentation(api, overload.Documentation?.Returns, writer);

            if (overload.Documentation?.Example != null)
            {
                await writer.WriteHeaderAsync(2, "Example");
                await WriteDocumentation(api, overload.Documentation?.Example, writer);
            }

            if (overload.Documentation?.Remarks != null)
            {
                await writer.WriteHeaderAsync(2, "Remarks");
                await WriteDocumentation(api, overload.Documentation?.Remarks, writer);
            }
        }

        async Task WriteEvent(ProgrammableBlockApi api, ApiEntry overload, MarkdownWriter writer, EventInfo eventInfo)
        {
            await writer.BeginCodeBlockAsync();
            await writer.WriteLineAsync(overload.ToString(ApiEntryStringFlags.Modifiers | ApiEntryStringFlags.GenericParameters | ApiEntryStringFlags.ParameterTypes | ApiEntryStringFlags.ParameterNames | ApiEntryStringFlags.ReturnValue | ApiEntryStringFlags.Accessors));
            await writer.EndCodeBlockAsync();
            if (overload.Documentation?.Summary != null)
                await WriteDocumentation(api, overload.Documentation?.Summary, writer);
            await writer.WriteHeaderAsync(2, "Returns");
            await writer.BeginParagraphAsync();
            await writer.WriteAsync(LinkToType(api, eventInfo.EventHandlerType));
            await writer.EndParagraphAsync();
            if (overload.Documentation?.Returns != null)
                await WriteDocumentation(api, overload.Documentation?.Returns, writer);

            if (overload.Documentation?.Example != null)
            {
                await writer.WriteHeaderAsync(2, "Example");
                await WriteDocumentation(api, overload.Documentation?.Example, writer);
            }

            if (overload.Documentation?.Remarks != null)
            {
                await writer.WriteHeaderAsync(2, "Remarks");
                await WriteDocumentation(api, overload.Documentation?.Remarks, writer);
            }
        }

        async Task WriteConstructor(ProgrammableBlockApi api, ApiEntry overload, MarkdownWriter writer, ConstructorInfo constructorInfo)
        {
            await writer.BeginCodeBlockAsync();
            await writer.WriteLineAsync(overload.ToString(ApiEntryStringFlags.Modifiers | ApiEntryStringFlags.GenericParameters | ApiEntryStringFlags.ParameterTypes | ApiEntryStringFlags.ParameterNames | ApiEntryStringFlags.ReturnValue | ApiEntryStringFlags.Accessors));
            await writer.EndCodeBlockAsync();
            if (overload.Documentation?.Summary != null)
                await WriteDocumentation(api, overload.Documentation?.Summary, writer);

            var parameters = constructorInfo.GetParameters();
            if (parameters.Length > 0)
            {
                await writer.WriteHeaderAsync(2, "Parameters");
                foreach (var parameter in parameters)
                {
                    await writer.WriteAsync("* ");
                    await writer.WriteAsync(LinkToType(api, parameter.GetActualParameterType()));
                    await writer.WriteAsync(" ");
                    await writer.WriteAsync(parameter.Name);
                    await writer.WriteLineAsync();
                }
            }

            if (overload.Documentation?.Example != null)
            {
                await writer.WriteHeaderAsync(2, "Example");
                await WriteDocumentation(api, overload.Documentation?.Example, writer);
            }

            if (overload.Documentation?.Remarks != null)
            {
                await writer.WriteHeaderAsync(2, "Remarks");
                await WriteDocumentation(api, overload.Documentation?.Remarks, writer);
            }
        }

        async Task WriteField(ProgrammableBlockApi api, ApiEntry overload, MarkdownWriter writer, FieldInfo fieldInfo)
        {
            await writer.BeginCodeBlockAsync();
            await writer.WriteLineAsync(overload.ToString(ApiEntryStringFlags.Modifiers | ApiEntryStringFlags.GenericParameters | ApiEntryStringFlags.ParameterTypes | ApiEntryStringFlags.ParameterNames | ApiEntryStringFlags.ReturnValue | ApiEntryStringFlags.Accessors));
            await writer.EndCodeBlockAsync();
            if (overload.Documentation?.Summary != null)
                await WriteDocumentation(api, overload.Documentation?.Summary, writer);
            await writer.WriteHeaderAsync(2, "Returns");
            await writer.BeginParagraphAsync();
            await writer.WriteAsync(LinkToType(api, fieldInfo.FieldType));
            await writer.EndParagraphAsync();
            if (overload.Documentation?.Returns != null)
                await WriteDocumentation(api, overload.Documentation?.Returns, writer);

            if (overload.Documentation?.Example != null)
            {
                await writer.WriteHeaderAsync(2, "Example");
                await WriteDocumentation(api, overload.Documentation?.Example, writer);
            }

            if (overload.Documentation?.Remarks != null)
            {
                await writer.WriteHeaderAsync(2, "Remarks");
                await WriteDocumentation(api, overload.Documentation?.Remarks, writer);
            }
        }
    }
}