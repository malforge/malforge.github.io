using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DocGen.Services.XmlDocs;
using DocGen.Steam;

namespace DocGen.Services
{
    internal static class ProgrammableBlockApiJson
    {
        public static async Task<bool> Export(string terminalsCacheFileName, string whitelistCacheFileName, string outputPath, bool forceRegeneration = false)
        {
            var spaceEngineers = new SpaceEngineers();
            var gameBinPath = Path.Combine(spaceEngineers.GetInstallPath(), "bin64");
            var outputDir = Path.GetDirectoryName(outputPath);
            
            // Check if regeneration is needed
            if (!forceRegeneration && !string.IsNullOrEmpty(outputDir) && 
                !DependencyManifest.NeedsRegeneration(outputDir, whitelistCacheFileName, terminalsCacheFileName, gameBinPath, "json"))
            {
                Console.WriteLine("✓ Skipping JSON generation (dependencies unchanged)");
                return false;
            }
            
            if (forceRegeneration)
            {
                Console.WriteLine("Force regeneration enabled");
            }
            
            var api = await ProgrammableBlockApi.LoadAsync(whitelistCacheFileName);
            var typeDefinitions = await TypeDefinitions.LoadAsync(terminalsCacheFileName, spaceEngineers.GetInstallPath("Content\\Data"));

            // Load type overrides config if it exists
            var configPath = FileHelpers.FindDefaultFile("docgen-overrides.txt");
            var typeOverrides = TypeOverridesConfig.Load(configPath);
            if (typeOverrides.Count > 0)
                Console.WriteLine($"Loaded {typeOverrides.Count} type override(s) from {configPath}");

            var jsonData = BuildJsonData(api, typeDefinitions, typeOverrides);

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };

            var json = JsonSerializer.Serialize(jsonData, options);
            FileHelpers.EnsureDirectoryExists(outputPath);
            File.WriteAllText(outputPath, json);
            
            // Save manifest after successful generation (if we have an output directory)
            if (!string.IsNullOrEmpty(outputDir))
            {
                var manifest = DependencyManifest.BuildManifest(whitelistCacheFileName, terminalsCacheFileName, gameBinPath);
                DependencyManifest.SaveManifest(manifest, outputDir, "json");
            }

            return true;
        }

        static ApiJsonData BuildJsonData(ProgrammableBlockApi api, TypeDefinitions typeDefinitions, TypeOverridesConfig typeOverrides)
        {
            var result = new ApiJsonData
            {
                GeneratedDate = DateTime.UtcNow,
                Types = new List<TypeJsonData>(),
                Namespaces = new List<NamespaceJsonData>()
            };

            // Group entries by namespace
            var namespaceGroups = api.Entries
                .Where(e => e.IsWhitelisted && e.Member is Type)
                .GroupBy(e => e.NamespaceName)
                .OrderBy(g => g.Key);

            foreach (var nsGroup in namespaceGroups)
            {
                var namespaceData = new NamespaceJsonData
                {
                    Name = nsGroup.Key,
                    Types = new List<string>()
                };

                foreach (var entry in nsGroup.OrderBy(e => e.Name))
                {
                    var type = (Type)entry.Member;
                    namespaceData.Types.Add(entry.FullName);

                    var typeData = new TypeJsonData
                    {
                        FullName = entry.FullName,
                        PageName = Path.GetFileNameWithoutExtension(entry.SuggestedFileName),
                        Name = entry.Name,
                        Namespace = entry.NamespaceName,
                        Assembly = entry.AssemblyName,
                        XmlDocKey = entry.XmlDocKey,
                        IsStatic = entry.IsStatic,
                        Kind = GetTypeKind(type),
                        Modifiers = type.GetModifiers().ToCodeString(),
                        Signature = entry.ToString(ApiEntryStringFlags.Modifiers | ApiEntryStringFlags.GenericParameters),
                        Documentation = ConvertDocumentation(entry.Documentation),
                        Members = new List<MemberJsonData>(),
                        BlockInfo = GetBlockInfo(type, typeDefinitions, typeOverrides)
                    };

                    // Add base type if exists
                    if (entry.BaseEntry != null)
                    {
                        typeData.BaseType = entry.BaseEntry.FullName;
                    }

                    // Add interfaces
                    if (entry.InheritedEntries.Count > 0)
                    {
                        typeData.Interfaces = entry.InheritedEntries.Select(e => e.FullName).ToList();
                    }

                    // Add members
                    foreach (var memberEntry in entry.MemberEntries.Where(m => m.IsWhitelisted).OrderBy(m => m.Name))
                    {
                        var memberData = ConvertMember(memberEntry);
                        if (memberData != null)
                        {
                            typeData.Members.Add(memberData);
                        }
                    }

                    result.Types.Add(typeData);
                }

                result.Namespaces.Add(namespaceData);
            }

            AddProhibitedTypes(api, result);

            return result;
        }

        /// <summary>
        ///     Adds the types a script can obtain but not name. They are flagged rather than merely present:
        ///     an entry with no members is already what a permitted type with no permitted members looks
        ///     like, so absence of members cannot also mean "prohibited". BaseType and Interfaces are left
        ///     off, because a prohibited type's real ancestors include other prohibited types that have no
        ///     entry here - AccessibleAs carries only the ancestors a script may actually name.
        /// </summary>
        static void AddProhibitedTypes(ProgrammableBlockApi api, ApiJsonData result)
        {
            var byNamespace = result.Namespaces.ToDictionary(n => n.Name, StringComparer.Ordinal);

            foreach (var prohibited in api.ProhibitedTypes)
            {
                var entry = prohibited.Entry;
                var type = (Type)entry.Member;

                result.Types.Add(new TypeJsonData
                {
                    FullName = entry.FullName,
                    PageName = Path.GetFileNameWithoutExtension(prohibited.SuggestedFileName),
                    Name = entry.Name,
                    Namespace = entry.NamespaceName,
                    Assembly = entry.AssemblyName,
                    XmlDocKey = entry.XmlDocKey,
                    Kind = GetTypeKind(type),
                    Modifiers = type.GetModifiers().ToCodeString(),
                    Signature = entry.ToString(ApiEntryStringFlags.Modifiers | ApiEntryStringFlags.GenericParameters),
                    IsStatic = entry.IsStatic,
                    Prohibited = true,
                    AccessibleAs = prohibited.AccessibleAs.Select(a => a.FullName).ToList(),
                    Members = new List<MemberJsonData>()
                });

                if (!byNamespace.TryGetValue(entry.NamespaceName, out var namespaceData))
                {
                    namespaceData = new NamespaceJsonData { Name = entry.NamespaceName, Types = new List<string>() };
                    byNamespace[entry.NamespaceName] = namespaceData;
                    result.Namespaces.Add(namespaceData);
                }

                namespaceData.Types.Add(entry.FullName);
            }

            result.Types = result.Types.OrderBy(t => t.Namespace, StringComparer.Ordinal)
                .ThenBy(t => t.Name, StringComparer.Ordinal).ToList();
            result.Namespaces = result.Namespaces.OrderBy(n => n.Name, StringComparer.Ordinal).ToList();
        }

        static string GetTypeKind(Type type)
        {
            if (type.IsEnum) return "enum";
            if (type.IsInterface) return "interface";
            if (type.IsClass) return "class";
            if (type.IsValueType) return "struct";
            return "unknown";
        }

        static BlockInfoJsonData GetBlockInfo(Type type, TypeDefinitions typeDefinitions, TypeOverridesConfig typeOverrides)
        {
            // Find matching block definitions by type name
            var typeName = type.FullName;
            var blockDef = typeDefinitions.Definitions.FirstOrDefault(d => d.TypeName == typeName);
            
            BlockInfoJsonData result = null;
            
            if (blockDef.TypeName != null)
            {
                result = new BlockInfoJsonData
                {
                    DisplayName = blockDef.DisplayName,
                    TypeId = blockDef.TypeId,
                    SubtypeId = blockDef.SubtypeId,
                    Size = blockDef.Size,
                    Group = blockDef.Group
                };
            }

            // Check for overrides
            if (typeOverrides.TryGetOverride(typeName, out var overrideMessage))
            {
                if (result == null)
                    result = new BlockInfoJsonData();
                result.OverrideMessage = overrideMessage;
            }

            return result;
        }

        static MemberJsonData ConvertMember(ApiEntry entry)
        {
            var member = entry.Member;
            var data = new MemberJsonData
            {
                Name = entry.Name,
                PageName = Path.GetFileNameWithoutExtension(entry.SuggestedFileName),
                XmlDocKey = entry.XmlDocKey,
                IsStatic = entry.IsStatic,
                Signature = entry.ToString(ApiEntryStringFlags.Default),
                Documentation = ConvertDocumentation(entry.Documentation)
            };

            switch (member)
            {
                case ConstructorInfo ctor:
                    data.Kind = "constructor";
                    data.Parameters = GetParameters(ctor.GetParameters());
                    break;
                case MethodInfo method:
                    data.Kind = "method";
                    data.ReturnType = GetTypeName(method.ReturnType);
                    data.Parameters = GetParameters(method.GetParameters());
                    if (method.IsGenericMethod)
                    {
                        data.GenericParameters = method.GetGenericArguments().Select(t => t.Name).ToList();
                    }
                    break;
                case PropertyInfo property:
                    data.Kind = "property";
                    data.ReturnType = GetTypeName(property.PropertyType);
                    data.CanRead = property.CanRead && property.GetMethod?.IsPublic == true;
                    data.CanWrite = property.CanWrite && property.SetMethod?.IsPublic == true;
                    break;
                case FieldInfo field:
                    data.Kind = "field";
                    data.ReturnType = GetTypeName(field.FieldType);
                    data.IsReadOnly = field.IsInitOnly;
                    data.IsConstant = field.IsLiteral;
                    if (field.IsLiteral && field.DeclaringType.IsEnum)
                    {
                        data.ConstantValue = field.GetRawConstantValue()?.ToString();
                    }
                    break;
                case EventInfo evt:
                    data.Kind = "event";
                    data.ReturnType = GetTypeName(evt.EventHandlerType);
                    break;
                default:
                    return null;
            }

            return data;
        }

        static string GetTypeName(Type type)
        {
            if (type == null) return null;
            
            // Handle common types
            var alias = type.GetLanguageAlias();
            if (alias != null) return alias;

            // Handle generic types
            if (type.IsGenericType)
            {
                var name = type.Name;
                var tickIndex = name.IndexOf('`');
                if (tickIndex > 0)
                    name = name.Substring(0, tickIndex);
                
                var args = type.GetGenericArguments();
                return $"{type.Namespace}.{name}<{string.Join(", ", args.Select(GetTypeName))}>";
            }

            return type.FullName ?? type.Name;
        }

        static List<ParameterJsonData> GetParameters(ParameterInfo[] parameters)
        {
            if (parameters == null || parameters.Length == 0)
                return null;

            return parameters.Select(p => new ParameterJsonData
            {
                Name = p.Name,
                Type = GetTypeName(p.ParameterType.IsByRef ? p.ParameterType.GetElementType() : p.ParameterType),
                IsOut = p.IsOut,
                IsRef = p.ParameterType.IsByRef && !p.IsOut,
                HasDefaultValue = p.HasDefaultValue,
                DefaultValue = p.HasDefaultValue ? p.DefaultValue?.ToString() : null
            }).ToList();
        }

        static DocumentationJsonData ConvertDocumentation(XmlDoc doc)
        {
            if (doc == null)
                return null;

            var result = new DocumentationJsonData
            {
                Summary = ExtractText(doc.Summary),
                Remarks = ExtractText(doc.Remarks),
                Returns = ExtractText(doc.Returns),
                Example = ExtractText(doc.Example)
            };

            // Extract param documentation from the root member paragraph
            if (doc.Root != null)
            {
                var paramParagraphs = doc.Root.Content
                    .OfType<ParamParagraph>()
                    .ToList();

                if (paramParagraphs.Any())
                {
                    result.Parameters = paramParagraphs.Select(p => new ParamDocJsonData
                    {
                        Name = p.Name,
                        Description = ExtractText(p)
                    }).ToList();
                }
            }

            return result;
        }

        static string ExtractText(XmlDocNode node)
        {
            if (node == null)
                return null;

            // For simple spans (includes TypeRefSpan, ParamRefSpan, TypeParamRefSpan, CodeSpan)
            if (node is Span span)
                return span.TextValue;

            // For paragraphs, extract text from all child nodes
            if (node is Paragraph paragraph)
            {
                var text = string.Join("", paragraph.Content.Select(ExtractText));
                return string.IsNullOrWhiteSpace(text) ? null : text.Trim();
            }

            // Default: return empty string for unknown node types
            return "";
        }
    }

    // JSON data classes
    internal class ApiJsonData
    {
        public DateTime GeneratedDate { get; set; }
        public List<TypeJsonData> Types { get; set; }
        public List<NamespaceJsonData> Namespaces { get; set; }
    }

    internal class NamespaceJsonData
    {
        public string Name { get; set; }
        public List<string> Types { get; set; }
    }

    internal class TypeJsonData
    {
        /// <summary>
        ///     Namespace plus short name. Not unique: nested types drop their declaring type, so
        ///     BoundingBox+ComparerType and BoundingBoxD+ComparerType both land on VRageMath.ComparerType.
        ///     Use <see cref="PageName" /> when a stable identity or a link target is needed.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        ///     The name this entry's generated page uses - unique, and the basename of its .md/.html file.
        /// </summary>
        public string PageName { get; set; }
        public string Name { get; set; }
        public string Namespace { get; set; }
        public string Assembly { get; set; }
        public string XmlDocKey { get; set; }
        public string Kind { get; set; }
        public string Modifiers { get; set; }
        public string Signature { get; set; }
        public bool IsStatic { get; set; }

        /// <summary>
        ///     Set when a script can obtain a value of this type but may not name it. Such an entry
        ///     documents nothing itself - see <see cref="AccessibleAs" /> for what to write instead.
        /// </summary>
        public bool? Prohibited { get; set; }

        /// <summary>
        ///     Only on prohibited entries: the nearest permitted types this one may be held as, most
        ///     derived first.
        /// </summary>
        public List<string> AccessibleAs { get; set; }

        public string BaseType { get; set; }
        public List<string> Interfaces { get; set; }
        public DocumentationJsonData Documentation { get; set; }
        public List<MemberJsonData> Members { get; set; }
        public BlockInfoJsonData BlockInfo { get; set; }
    }

    internal class BlockInfoJsonData
    {
        public string DisplayName { get; set; }
        public string TypeId { get; set; }
        public string SubtypeId { get; set; }
        public string Size { get; set; }
        public string Group { get; set; }
        public string OverrideMessage { get; set; }
    }

    internal class MemberJsonData
    {
        public string Kind { get; set; }
        public string Name { get; set; }

        /// <summary>
        ///     The name this member's generated page uses, if it has its own page - the basename of its
        ///     .md/.html file. See <see cref="TypeJsonData.PageName" />.
        /// </summary>
        public string PageName { get; set; }
        public string XmlDocKey { get; set; }
        public string Signature { get; set; }
        public bool IsStatic { get; set; }
        public string ReturnType { get; set; }
        public List<ParameterJsonData> Parameters { get; set; }
        public List<string> GenericParameters { get; set; }
        public bool? CanRead { get; set; }
        public bool? CanWrite { get; set; }
        public bool? IsReadOnly { get; set; }
        public bool? IsConstant { get; set; }
        public string ConstantValue { get; set; }
        public DocumentationJsonData Documentation { get; set; }
    }

    internal class ParameterJsonData
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsOut { get; set; }
        public bool IsRef { get; set; }
        public bool HasDefaultValue { get; set; }
        public string DefaultValue { get; set; }
    }

    internal class DocumentationJsonData
    {
        public string Summary { get; set; }
        public string Remarks { get; set; }
        public string Returns { get; set; }
        public string Example { get; set; }
        public List<ParamDocJsonData> Parameters { get; set; }
    }

    internal class ParamDocJsonData
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
