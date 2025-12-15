using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using DocGen.Services.Markdown;

namespace DocGen.Services.XmlDocs
{
    internal class ListParagraph : XmlDocNode
    {
        public ListParagraph(string listType, XmlDocNode header, IEnumerable<XmlDocNode> items)
        {
            ListType = listType ?? "bullet"; // Default to bullet if not specified
            Header = header;
            Items = new ReadOnlyCollection<XmlDocNode>(items?.Where(n => n != null).ToList() ?? new List<XmlDocNode>());
        }

        public string ListType { get; }
        public XmlDocNode Header { get; }
        public ReadOnlyCollection<XmlDocNode> Items { get; }

        public override async Task WriteMarkdown(XmlDocWriteContext context, MarkdownWriter writer)
        {
            // Lists are written inline as comma-separated text to avoid transaction issues
            // We don't use BeginParagraph/EndParagraph to avoid nested transactions in tables
            var first = true;
            foreach (var item in Items)
            {
                if (!first)
                    await writer.WriteAsync(", ");
                await item.WriteMarkdown(context, writer);
                first = false;
            }
        }
    }
}
