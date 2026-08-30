using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DocGen.Services.Markdown;

namespace DocGen.Services.MarkdownGenerators
{
    /// <summary>
    ///     Writes a page for each type a script can obtain but may not name. Without one, a reader who meets
    ///     IMyEntityComponentContainer in IntelliSense and searches for it finds nothing at all, and learns
    ///     neither that it is prohibited nor what to write instead. A search result that says "prohibited,
    ///     use IMyComponentContainer" is the whole point of these pages.
    /// </summary>
    internal class ProhibitedTypeGenerator : DocumentGenerator
    {
        public override async Task Generate(DirectoryInfo directory, ProgrammableBlockApi api)
        {
            var tasks = api.ProhibitedTypes.Select(prohibited => GeneratePage(directory, prohibited));
            await Task.WhenAll(tasks);
        }

        static async Task GeneratePage(DirectoryInfo directory, ProhibitedType prohibited)
        {
            var fileName = FileHelpers.ToLongPathSafe(Path.Combine(directory.FullName, prohibited.SuggestedFileName));
            using (var file = File.CreateText(fileName))
            {
                var writer = new MarkdownWriter(file);
                var entry = prohibited.Entry;

                await writer.BeginParagraphAsync();
                await writer.WriteLineAsync($"{MarkdownInline.Strong("Assembly:")} {entry.AssemblyName}.dll");
                await writer.EndParagraphAsync();

                await writer.BeginCodeBlockAsync();
                await writer.WriteLineAsync(entry.ToString(ApiEntryStringFlags.Modifiers | ApiEntryStringFlags.GenericParameters));
                await writer.EndCodeBlockAsync();

                await writer.WriteHeaderAsync(2, "Prohibited");

                await writer.BeginParagraphAsync();
                await writer.WriteLineAsync("You cannot write this type's name in a script. You can still use a value of it, "
                                            + "by holding it in a variable of a type you are allowed to name:");
                await writer.EndParagraphAsync();

                await writer.WriteHeaderAsync(2, prohibited.AccessibleAs.Count == 1 ? "Use it as" : "Use it as one of");

                foreach (var accessible in prohibited.AccessibleAs)
                {
                    await writer.WriteUnorderedListItemAsync(
                        MarkdownInline.HRef(accessible.FullName, Path.GetFileNameWithoutExtension(accessible.SuggestedFileName)));
                }

                await writer.BeginCodeBlockAsync();
                await writer.WriteLineAsync($"{prohibited.AccessibleAs[0].Name} value = /* the {entry.Name} you were given */;");
                await writer.EndCodeBlockAsync();
            }
        }
    }
}
