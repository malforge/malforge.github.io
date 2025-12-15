using System;
using System.Threading.Tasks;
using DocGen.Services.Markdown;

namespace DocGen.Services.XmlDocs
{
    internal class TypeRefSpan : Span
    {
        public TypeRefSpan(string textValue) : base(textValue)
        {
        }

        public override async Task WriteMarkdown(XmlDocWriteContext context, MarkdownWriter writer)
        {
            if (string.IsNullOrWhiteSpace(TextValue))
            {
                return;
            }
            try
            {
                await writer.WriteAsync(" ");
                var entry = context.ResolveReference(TextValue);
                if (entry.Key == null)
                    await writer.WriteAsync(entry.Value ?? TextValue);
                else
                    await writer.WriteAsync(MarkdownInline.HRef(entry.Value, entry.Key));
                await writer.WriteAsync(" ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}