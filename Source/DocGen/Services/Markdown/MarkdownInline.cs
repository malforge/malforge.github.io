using System.Text.RegularExpressions;

namespace DocGen.Services.Markdown
{
    internal static class MarkdownInline
    {
        public static string Normalize(string summary)
        {
            return Regex.Replace(summary.Trim(), @"\s{2,}", " ");
        }

        public static string Code(string text)
        {
            return SmartTrimmed(text, "`", "`");
        }

        public static string Strong(string text)
        {
            return SmartTrimmed(text, "**", "**");
        }

        public static string Emphasized(string text)
        {
            return SmartTrimmed(text, "_", "_");
        }

        //public static string HRef(string text, ApiEntry entry) => HRef(text, Path.GetFileNameWithoutExtension(entry.SuggestedFileName));
        public static string HRef(string text, string url)
        {
            return $"[{text}]({url})";
        }

        static string SmartTrimmed(string content, string start, string end)
        {
            var prefix = "";
            var suffix = "";
            var text = content.TrimStart();
            if (text.Length < content.Length)
            {
                prefix = content.Substring(0, content.Length - text.Length);
                content = text;
            }

            text = content.TrimEnd();
            if (text.Length < content.Length)
                suffix = content.Substring(text.Length);
            return $"{prefix}{start}{text}{end}{suffix}";
        }
    }
}