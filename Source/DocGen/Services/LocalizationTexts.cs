using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml.XPath;

namespace DocGen.Services
{
    public class LocalizationTexts
    {
        readonly Dictionary<string, string> _texts = new Dictionary<string, string>();

        public static LocalizationTexts Load(string fileName)
        {
            var text = new LocalizationTexts();
            var document = XDocument.Load(fileName);
            text.Load(document);
            return text;
        }

        void Load(XDocument document)
        {
            _texts.Clear();
            var data = document.XPathSelectElements("/root/data");
            foreach (var element in data)
            {
                var key = (string)element.Attribute("name");
                var value = (string)element.Element("Value");
                if (key != null && value != null)
                    _texts[key] = value;
            }
        }
    }
}