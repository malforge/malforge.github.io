using System.Collections.Generic;

namespace DocGen.Services.XmlDocs
{
    internal class ParamParagraph : Paragraph
    {
        public ParamParagraph(string name, IEnumerable<XmlDocNode> content) : base(ParagraphType.Param, content)
        {
            Name = name;
        }

        public string Name { get; }
    }
}