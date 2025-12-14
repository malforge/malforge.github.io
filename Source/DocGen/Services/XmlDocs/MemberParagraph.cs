using System.Collections.Generic;

namespace DocGen.Services.XmlDocs
{
    internal class MemberParagraph : Paragraph
    {
        public MemberParagraph(IEnumerable<XmlDocNode> content) : base(ParagraphType.Member, content)
        {
        }
    }
}