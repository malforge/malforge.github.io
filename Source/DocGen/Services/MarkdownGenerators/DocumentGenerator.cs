using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DocGen.Services.Markdown;
using DocGen.Services.XmlDocs;

namespace DocGen.Services.MarkdownGenerators
{
    internal abstract class DocumentGenerator
    {
        static readonly HashSet<char> InvalidCharacters = new HashSet<char>(Path.GetInvalidFileNameChars());

        protected static string ToMdFileName(string path)
        {
            var builder = new StringBuilder(path);
            for (var i = 0; i < builder.Length; i++)
            {
                if (InvalidCharacters.Contains(builder[i]))
                    builder[i] = '_';
            }

            builder.Append(".md");
            return builder.ToString();
        }

        protected static async Task WriteDocumentation(ProgrammableBlockApi api, XmlDocNode docs, MarkdownWriter writer)
        {
            if (docs != null)
            {
                var context = new XmlDocWriteContext(key => ResolveTypeReference(api, key));
                await docs.WriteMarkdown(context, writer);
            }
        }

        protected static KeyValuePair<string, string> ResolveTypeReference(ProgrammableBlockApi api, string key)
        {
            if (key.StartsWith("!:"))
                return new KeyValuePair<string, string>(null, key.Substring(2));

            var entry = api.Entries.FirstOrDefault(e => e.XmlDocKey == key);
            if (entry == null)
            {
                // Try to resolve the actual member from loaded assemblies to check if it's a Microsoft type
                var member = TryResolveMember(key);
                if (member != null)
                {
                    // Found the member - check if it's genuinely from Microsoft
                    if (MicrosoftLink.IsMsType(member))
                    {
                        // It's a real Microsoft type - generate MS docs link
                        // Use api.GetEntry for proper formatting (handles generics, etc.)
                        try
                        {
                            var tempEntry = api.GetEntry(member, includeBlacklisted: true);
                            var displayName = tempEntry?.ToString(ApiEntryStringFlags.ShortDisplayName) ?? key.Substring(2);
                            var name = key.Substring(2);
                            var msLink = $"https://docs.microsoft.com/en-us/dotnet/api/{name.ToLower()}?view=netframework-4.6";
                            return new KeyValuePair<string, string>(msLink, displayName);
                        }
                        catch
                        {
                            // Fallback if GetEntry fails
                            var name = key.Substring(2);
                            var msLink = $"https://docs.microsoft.com/en-us/dotnet/api/{name.ToLower()}?view=netframework-4.6";
                            return new KeyValuePair<string, string>(msLink, name);
                        }
                    }
                    else
                    {
                        // It's a Space Engineers/Keen type that's not whitelisted - mark as prohibited
                        // Use api.GetEntry to get proper formatting (including generics)
                        try
                        {
                            var tempEntry = api.GetEntry(member, includeBlacklisted: true);
                            var displayName = tempEntry?.ToString(ApiEntryStringFlags.ShortDisplayName | ApiEntryStringFlags.DeclaringTypes) ?? member.Name;
                            return new KeyValuePair<string, string>(null, $"`{displayName}`<sub>prohibited</sub>");
                        }
                        catch
                        {
                            // Fallback if GetEntry fails
                            var displayName = member.DeclaringType != null ? $"{member.DeclaringType.Name}.{member.Name}" : member.Name;
                            return new KeyValuePair<string, string>(null, $"`{displayName}`<sub>prohibited</sub>");
                        }
                    }
                }
                
                // Couldn't resolve the member - assume MS type as fallback
                var fallbackName = key.Substring(2);
                var fallbackLink = $"https://docs.microsoft.com/en-us/dotnet/api/{fallbackName.ToLower()}?view=netframework-4.6";
                return new KeyValuePair<string, string>(fallbackLink, fallbackName);
            }

            return new KeyValuePair<string, string>(Path.GetFileNameWithoutExtension(entry.SuggestedFileName), entry.ToString(ApiEntryStringFlags.ShortDisplayName));
        }

        static MemberInfo TryResolveMember(string xmlDocKey)
        {
            // XML doc keys format: T:TypeName, M:TypeName.MethodName, F:TypeName.FieldName, etc.
            if (xmlDocKey.Length < 3 || xmlDocKey[1] != ':')
                return null;

            var memberType = xmlDocKey[0];
            var name = xmlDocKey.Substring(2);

            // For type references, resolve the type directly
            if (memberType == 'T')
                return TryResolveType(name);

            // For members, extract the type and member name
            var parenIndex = name.IndexOf('(');
            var searchName = parenIndex >= 0 ? name.Substring(0, parenIndex) : name;
            var lastDot = searchName.LastIndexOf('.');
            if (lastDot < 0)
                return null;

            var typeName = searchName.Substring(0, lastDot);
            var memberName = searchName.Substring(lastDot + 1);

            var type = TryResolveType(typeName);
            if (type == null)
                return null;

            // Try to find the member based on the member type indicator
            try
            {
                switch (memberType)
                {
                    case 'F': // Field
                        return type.GetField(memberName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
                    case 'P': // Property
                        return type.GetProperty(memberName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
                    case 'E': // Event
                        return type.GetEvent(memberName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
                    case 'M': // Method (simplified - doesn't handle overloads)
                        return type.GetMethod(memberName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
                    default:
                        return type;
                }
            }
            catch
            {
                return null;
            }
        }

        static Type TryResolveType(string typeName)
        {
            // Try to find the type in all loaded assemblies
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                try
                {
                    var type = assembly.GetType(typeName);
                    if (type != null)
                        return type;
                }
                catch
                {
                    // Ignore assembly load errors
                }
            }
            return null;
        }

        public abstract Task Generate(DirectoryInfo directory, ProgrammableBlockApi api);
    }
}