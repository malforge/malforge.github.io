using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using DocGen.Services.MarkdownGenerators;
using DocGen.Services.XmlDocs;
using DocGen.Steam;

namespace DocGen.Services
{
    internal class ProgrammableBlockApi
    {
        readonly Dictionary<MemberInfo, ApiEntry> _blacklistedEntryLookup = new Dictionary<MemberInfo, ApiEntry>();
        readonly Dictionary<string, XDocument> _documentationCache = new Dictionary<string, XDocument>(StringComparer.CurrentCultureIgnoreCase);
        readonly List<ApiEntry> _entries = new List<ApiEntry>();
        readonly Dictionary<MemberInfo, ApiEntry> _entryLookup = new Dictionary<MemberInfo, ApiEntry>();

        Whitelist _whitelist;

        ProgrammableBlockApi()
        {
            Entries = new ReadOnlyCollection<ApiEntry>(_entries);
        }

        public ReadOnlyCollection<ApiEntry> Entries { get; }

        static Assembly LoadAssembly(string dllFile)
        {
            try
            {
                // First try to load by assembly name to respect binding redirects etc. If that doesn't work, fall back to loading from file.
                var assemblyName = AssemblyName.GetAssemblyName(dllFile);
                try
                {
                    return Assembly.Load(assemblyName);
                }
                catch (FileNotFoundException)
                {
                    return Assembly.LoadFrom(dllFile);
                }
            }
            catch (FileLoadException)
            {
                return null;
            }
            catch (BadImageFormatException)
            {
                return null;
            }
        }

        public static async Task Update(string terminalsCacheFileName, string whitelistCacheFileName, string output, bool forceRegeneration = false)
        {
            var spaceEngineers = new SpaceEngineers();
            var gameBinPath = Path.Combine(spaceEngineers.GetInstallPath(), "bin64");
            
            // Check if regeneration is needed
            if (!forceRegeneration && !DependencyManifest.NeedsRegeneration(output, whitelistCacheFileName, terminalsCacheFileName, gameBinPath))
            {
                Console.WriteLine("✓ Skipping API generation (dependencies unchanged)");
                return;
            }
            
            if (forceRegeneration)
            {
                Console.WriteLine("Force regeneration enabled");
            }
            
            var api = await LoadAsync(whitelistCacheFileName);
            var typeDefinitions = await TypeDefinitions.LoadAsync(terminalsCacheFileName, spaceEngineers.GetInstallPath("Content\\Data"));

            await api.SaveAsync(typeDefinitions, output);
            
            // Save manifest after successful generation
            var manifest = DependencyManifest.BuildManifest(whitelistCacheFileName, terminalsCacheFileName, gameBinPath);
            DependencyManifest.SaveManifest(manifest, output);
        }

        public static async Task<ProgrammableBlockApi> LoadAsync(string whitelistCacheFileName)
        {
            var api = new ProgrammableBlockApi();
            await Task.Run(() =>
            {
                var members = new List<MemberInfo>();
                var spaceEngineers = new SpaceEngineers();
                var installPath = Path.Combine(spaceEngineers.GetInstallPath(), "bin64");
                MDKUtilityFramework.Load(installPath);
                var dllFiles = Directory.EnumerateFiles(installPath, "*.dll", SearchOption.TopDirectoryOnly)
                    .ToList();
                foreach (var file in dllFiles)
                    LoadAssembly(file);
                //var assemblies = dllFiles.Select(LoadAssembly).Where(a => a != null).ToList();
                var assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
                var whitelist = Whitelist.Load(whitelistCacheFileName);
                api._whitelist = whitelist;

                foreach (var assembly in assemblies)
                    Visit(whitelist, assembly, members);

                // Hack. I'm getting duplicated entries and atm I cannot be bothered to do a proper check
                // for why...
                var visitedMembers = new HashSet<MemberInfo>();

                foreach (var assemblyGroup in members.GroupBy(m => m.GetAssembly()))
                {
                    foreach (var typeGroup in assemblyGroup.GroupBy(m => m.DeclaringType))
                    {
                        if (typeGroup.Key == null)
                        {
                            foreach (var type in typeGroup)
                            {
                                var entry = api.GetEntry(type);
                                if (!api._entries.Contains(entry))
                                    api._entries.Add(entry);
                            }

                            continue;
                        }

                        var typeEntry = api.GetEntry(typeGroup.Key);
                        if (typeEntry != null)
                        {
                            // Don't check visitedMembers for the type here - we need to process
                            // members even if the type was already visited (e.g., nested enums)
                            if (!api._entries.Contains(typeEntry))
                                api._entries.Add(typeEntry);
                            foreach (var member in typeGroup)
                            {
                                var entry = api.GetEntry(member);
                                if (entry != null)
                                {
                                    if (!visitedMembers.Add(member))
                                        continue;
                                    if (!api._entries.Contains(entry))
                                        api._entries.Add(entry);
                                }
                            }
                        }
                    }
                }

                foreach (var entry in api.Entries)
                    entry.ResolveLinks();
            });

            return api;
        }

        static void Visit(Whitelist whitelist, Assembly assembly, List<MemberInfo> members)
        {
            if (!whitelist.IsWhitelisted(assembly))
                return;
            if (assembly.GetName().Name == "mscorlib")
                return;
            var companyAttribute = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
            if (companyAttribute?.Company == "Microsoft Corporation")
                return;
            var exportedTypes = assembly.GetExportedTypes();
            foreach (var type in exportedTypes)
                Visit(whitelist, type, members);
        }

        static void Visit(Whitelist whitelist, Type type, List<MemberInfo> members)
        {
            if (!type.IsPublic() || !whitelist.IsWhitelisted(type))
                return;
            members.Add(type);
            var typeMembers = type.GetMembers(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
            foreach (var member in typeMembers)
                Visit(whitelist, member, members);
            //var nestedTypes = type.GetNestedTypes(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
            //foreach (var nestedType in nestedTypes)
            //    Visit(whitelist, nestedType, members);
        }

        static void Visit(Whitelist whitelist, MemberInfo member, List<MemberInfo> members)
        {
            if (member is Type type)
            {
                Visit(whitelist, type, members);
                return;
            }

            if (!member.IsPublic() || !whitelist.IsWhitelisted(member))
                return;
            members.Add(member);
        }

        ApiEntry CreateEntry(MemberInfo memberInfo)
        {
            var entry = ApiEntry.Create(this, _whitelist, memberInfo);
            if (entry == null)
                return null;

            string docFileName = null;
            if (memberInfo is Type type)
            {
                if (type.IsGenericType) type = type.GetGenericTypeDefinition();
                docFileName = Path.ChangeExtension(new Uri(type.Assembly.CodeBase).LocalPath, "xml");
            }
            else
            {
                type = memberInfo.DeclaringType;
                if (type?.IsGenericType ?? false) type = type.GetGenericTypeDefinition();
                var codeBase = type?.Assembly.CodeBase;
                if (codeBase != null)
                    docFileName = Path.ChangeExtension(new Uri(codeBase).LocalPath, "xml");
            }

            if (docFileName != null)
            {
                if (!_documentationCache.TryGetValue(docFileName, out var documentation))
                    _documentationCache[docFileName] = documentation = File.Exists(docFileName) ? XDocument.Load(docFileName) : null;
                var doc = documentation?.XPathSelectElement($"/doc/members/member[@name='{entry.XmlDocKey}']");
                entry.Documentation = XmlDoc.Generate(doc);
            }

            return entry;
        }

        public ApiEntry GetEntry(MemberInfo memberInfo, bool includeBlacklisted = false)
        {
            if (_entryLookup.TryGetValue(memberInfo, out var entry))
            {
                if (entry != null || (includeBlacklisted && _blacklistedEntryLookup.TryGetValue(memberInfo, out entry)))
                    return entry;
                return null;
            }

            entry = CreateEntry(memberInfo);
            if (entry == null)
            {
                _entryLookup[memberInfo] = null;
                return null;
            }

            if (_whitelist.IsWhitelisted(memberInfo))
            {
                _entryLookup[memberInfo] = entry;
                return entry;
            }

            _blacklistedEntryLookup[memberInfo] = null;
            return includeBlacklisted ? entry : null;
        }

        public async Task SaveAsync(TypeDefinitions typeDefinitions, string path)
        {
            // Load type overrides config if it exists
            var configPath = FileHelpers.FindDefaultFile("docgen-overrides.txt");
            var typeOverrides = TypeOverridesConfig.Load(configPath);
            if (typeOverrides.Count > 0)
                Console.WriteLine($"Loaded {typeOverrides.Count} type override(s) from {configPath}");

            var generators = new DocumentGenerator[]
            {
                new ApiIndexGenerator(),
                new TypeGenerator(typeDefinitions, typeOverrides),
                new MemberGenerator(),
                new NamespaceIndexGenerator(),
                new NamespaceGenerator()
            };

            var directory = new DirectoryInfo(path);
            if (!directory.Exists)
                directory.Create();
            await Task.Run(() => { Task.WaitAll(generators.Select(g => g.Generate(directory, this)).ToArray()); });
        }

        public bool IsAdditionalEntry(ApiEntry entry)
        {
            return _entries.Contains(entry);
        }
    }
}