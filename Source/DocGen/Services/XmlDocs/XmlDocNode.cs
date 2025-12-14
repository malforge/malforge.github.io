using System.Threading.Tasks;
using DocGen.Services.Markdown;

namespace DocGen.Services.XmlDocs
{
    internal abstract class XmlDocNode
    {
        public abstract Task WriteMarkdown(XmlDocWriteContext context, MarkdownWriter writer);
    }
}