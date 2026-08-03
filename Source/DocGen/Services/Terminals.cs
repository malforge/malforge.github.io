using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DocGen.Services
{
    public class Terminals
    {
        readonly List<BlockInfo> _blocks = new List<BlockInfo>();

        Terminals()
        {
            Blocks = new ReadOnlyCollection<BlockInfo>(_blocks);
        }

        public ReadOnlyCollection<BlockInfo> Blocks { get; }

        public static async Task Update(string fileName, string output, Action<string> updateStatusFn)
        {
            // Check if regeneration is needed (simple timestamp check)
            if (File.Exists(output) && File.GetLastWriteTimeUtc(output) >= File.GetLastWriteTimeUtc(fileName))
            {
                updateStatusFn?.Invoke("Skipping (output up-to-date)");
                return;
            }
            
            updateStatusFn?.Invoke("Loading cache...");
            var terminals = await Task.Run(() => Load(fileName));
            updateStatusFn?.Invoke("Saving document...");
            await Task.Run(() => terminals.Save(output));
            updateStatusFn?.Invoke("Done.");
        }

        public static Terminals Load(string fileName)
        {
            var document = XDocument.Load(fileName);
            var terminals = new Terminals();
            terminals.Load(document.Element("terminals"));
            return terminals;
        }

        public void Save(string fileName)
        {
            var document = new StringBuilder();
            var blocks = Blocks.OrderBy(GetDisplayName, StringComparer.OrdinalIgnoreCase).ToList();
            document.AppendLine("## Overview");
            document.AppendLine("**Note: Terminal actions and properties are for all intents and purposes obsolete since all vanilla block interfaces now contain proper API access to _most of_ this information. It is highly recommended you use those for less overhead.**");
            document.AppendLine();
            document.AppendLine("Blocks are listed by their type definition. A block can be fetched through any of the interfaces listed beneath it, so the same actions and properties apply to every one of them.");
            document.AppendLine();

            foreach (var block in blocks)
            {
                var name = GetDisplayName(block);
                document.AppendLine($"[{name}](#{name.ToLower()})  ");
            }

            document.AppendLine();

            foreach (var block in blocks)
            {
                document.AppendLine($"## {GetDisplayName(block)}");
                document.AppendLine();

                var interfaces = GetFetchableAs(block);
                if (interfaces.Any())
                {
                    document.AppendLine("Available as: " + string.Join(", ", interfaces.Select(i => $"`{i}`")));
                    document.AppendLine();
                }

                var actions = block.Actions.OrderBy(a => a.Name).ToList();
                if (actions.Any())
                {
                    document.AppendLine("### Actions");
                    document.AppendLine();
                    document.AppendLine("|Name|Description|");
                    document.AppendLine("|-|-|");
                    foreach (var action in actions)
                        document.AppendLine($"|{action.Name}|{action.Text}|");
                    document.AppendLine();
                }

                var properties = block.Properties.OrderBy(a => a.Name).ToList();
                if (properties.Any())
                {
                    document.AppendLine("### Properties");
                    document.AppendLine();
                    document.AppendLine("|Name|Type|");
                    document.AppendLine("|-|-|");
                    foreach (var property in properties)
                        document.AppendLine($"|{property.Name}|{TranslateType(property.Type)}|");
                    document.AppendLine();
                }
            }

            FileHelpers.EnsureDirectoryExists(fileName);
            File.WriteAllText(fileName, document.ToString());
        }

        void Load(XElement root)
        {
            _blocks.Clear();
            _blocks.AddRange(root.Elements("block").Select(element => new BlockInfo(element)));
        }

        string TranslateType(string name)
        {
            if (name == null)
                return string.Empty;
            switch (name.ToUpper())
            {
                case "BOOLEAN":
                    return "bool";
                case "CHAR":
                    return "char";
                case "SBYTE":
                    return "sbyte";
                case "BYTE":
                    return "byte";
                case "INT16":
                    return "short";
                case "UINT16":
                    return "ushort";
                case "INT32":
                    return "int";
                case "UINT32":
                    return "uint";
                case "INT64":
                    return "long";
                case "UINT64":
                    return "ulong";
                case "SINGLE":
                    return "float";
                case "DOUBLE":
                    return "double";
                case "DECIMAL":
                    return "decimal";
                case "STRING":
                    return "string";
                default:
                    return name;
            }
        }

        string GetBlockName(string name)
        {
            if (name == null)
                return string.Empty;
            var endPt = name.LastIndexOf('.');
            if (endPt >= 0)
                return name.Substring(endPt + 1);
            return name;
        }

        const string TerminalBlockInterface = "IMyTerminalBlock";

        /// <summary>
        ///     The interfaces worth telling someone about: the ones they can actually fetch the block through.
        /// </summary>
        /// <remarks>
        ///     Only interfaces descending from <c>IMyTerminalBlock</c> qualify, which drops the cross-cutting ones
        ///     such as <c>IMyCubeBlock</c>, <c>IMyEntity</c> and <c>IMyInventoryOwner</c> that every block carries
        ///     and none of which help you find it. <c>IMyTerminalBlock</c> itself is left out because it is true of
        ///     everything, unless a block has nothing else, in which case it is the honest answer.
        /// </remarks>
        List<string> GetFetchableAs(BlockInfo block)
        {
            var interfaces = block.TerminalInterfaces
                .Select(GetBlockName)
                .Where(name => name != TerminalBlockInterface)
                .ToList();

            return interfaces.Count > 0 ? interfaces : new List<string> { TerminalBlockInterface };
        }

        /// <summary>
        ///     What a block is listed under. The type definition, because it is the one thing every block has:
        ///     a dozen block classes carry no terminal interface attribute, so the interface name is blank for
        ///     them. Falls back to the interface name for older cache files that predate the type definition.
        /// </summary>
        string GetDisplayName(BlockInfo block) =>
            !string.IsNullOrEmpty(block.TypeId) ? block.TypeId : GetBlockName(block.BlockInterfaceType);

        public readonly struct TerminalAction
        {
            public readonly string Name;
            public readonly string Text;

            public TerminalAction(string name, string text)
            {
                Name = name;
                Text = text;
            }
        }

        public readonly struct TerminalProperty
        {
            public readonly string Name;
            public readonly string Type;

            public TerminalProperty(string name, string type)
            {
                Name = name;
                Type = type;
            }
        }

        public class BlockInfo
        {
            public BlockInfo(XElement element)
            {
                TypeId = (string)element.Attribute("typedefinition");
                BlockInterfaceType = (string)element.Attribute("type");
                Subtype = (string)element.Attribute("subtype");
                ClassName = (string)element.Attribute("class");
                var ingameInterfaces = element.Elements("interface")
                    .Where(i => !string.IsNullOrEmpty((string)i.Attribute("name")))
                    .OrderBy(i => (string)i.Attribute("name"), StringComparer.Ordinal)
                    .ToList();
                IngameInterfaces = new ReadOnlyCollection<string>(
                    ingameInterfaces.Select(i => (string)i.Attribute("name")).ToList());
                TerminalInterfaces = new ReadOnlyCollection<string>(
                    ingameInterfaces
                        .Where(i => string.Equals((string)i.Attribute("terminal"), "true", StringComparison.OrdinalIgnoreCase))
                        .Select(i => (string)i.Attribute("name"))
                        .ToList());
                var actions = new List<TerminalAction>();
                var elements = element.Elements("action");
                foreach (var action in elements)
                    actions.Add(new TerminalAction((string)action.Attribute("name"), (string)action.Attribute("text")));
                var properties = new List<TerminalProperty>();
                elements = element.Elements("property");
                foreach (var property in elements)
                    properties.Add(new TerminalProperty((string)property.Attribute("name"), (string)property.Attribute("type")));
                Actions = new ReadOnlyCollection<TerminalAction>(actions);
                Properties = new ReadOnlyCollection<TerminalProperty>(properties);
            }

            /// <summary>The block's object builder type without its prefix. The key a block is listed under.</summary>
            public string TypeId { get; }

            /// <summary>
            ///     The ingame interface the game declares for this block. Empty for the blocks the game never
            ///     annotated, so it cannot be relied on.
            /// </summary>
            public string BlockInterfaceType { get; }

            /// <summary>Which subtype the extractor sampled to produce these actions and properties.</summary>
            public string Subtype { get; }

            /// <summary>The runtime block class, for tracing an entry back to the game.</summary>
            public string ClassName { get; }

            /// <summary>Every ingame interface the block implements.</summary>
            public ReadOnlyCollection<string> IngameInterfaces { get; }

            /// <summary>
            ///     Those of <see cref="IngameInterfaces" /> descending from <c>IMyTerminalBlock</c>, which are the
            ///     ones a script can actually fetch the block through. The extractor marks these, since only it
            ///     has the type hierarchy to hand.
            /// </summary>
            public ReadOnlyCollection<string> TerminalInterfaces { get; }

            public ReadOnlyCollection<TerminalProperty> Properties { get; set; }

            public ReadOnlyCollection<TerminalAction> Actions { get; set; }

            public void Write(TextWriter writer)
            {
                writer.WriteLine(BlockInterfaceType);
                foreach (var action in Actions)
                    writer.WriteLine($"- action {action.Name}");
                foreach (var property in Properties)
                    writer.WriteLine($"- action {property.Name} {DetermineType(property.Type)}");
            }

            string DetermineType(string propertyTypeName)
            {
                return propertyTypeName;
            }

            public XElement ToXElement()
            {
                var root = new XElement("block",
                    new XAttribute("typedefinition", TypeId ?? ""),
                    new XAttribute("subtype", Subtype ?? ""),
                    new XAttribute("class", ClassName ?? ""),
                    new XAttribute("type", BlockInterfaceType ?? ""));
                foreach (var ingameInterface in IngameInterfaces)
                    root.Add(new XElement("interface", new XAttribute("name", ingameInterface)));
                foreach (var action in Actions)
                    root.Add(new XElement("action", new XAttribute("name", action.Name), new XAttribute("text", action.Text)));
                foreach (var property in Properties)
                    root.Add(new XElement("property", new XAttribute("name", property.Name), new XAttribute("type", DetermineType(property.Type))));
                return root;
            }
        }
    }
}