using Markdig;
using Markdig.Renderers;
using Markdig.Syntax;
using System.Text;

namespace MdkApiGen;

public class DocGenerator
{
    private readonly MarkdownPipeline _pipeline;
    private string _template = "";
    private string _cacheBuster = "";
    
    public DocGenerator()
    {
        // Create pipeline with GitHub-flavored markdown
        _pipeline = new MarkdownPipelineBuilder()
            .UseAdvancedExtensions()
            .Build();
    }

    public void Generate(DirectoryInfo inputDir, DirectoryInfo outputDir, string title = "Documentation")
    {
        if (!inputDir.Exists)
        {
            Console.Error.WriteLine($"Error: Input directory '{inputDir.FullName}' does not exist.");
            return;
        }

        Console.WriteLine($"Generating documentation from: {inputDir.FullName}");
        Console.WriteLine($"Output directory: {outputDir.FullName}");

        // Create output directory
        if (!outputDir.Exists)
            outputDir.Create();

        // Load template
        LoadTemplate();

        // Generate cache buster
        _cacheBuster = GenerateCacheBuster();
        Console.WriteLine($"Cache-buster: {_cacheBuster}");

        // Get all markdown files
        var markdownFiles = inputDir.GetFiles("*.md", SearchOption.AllDirectories);
        Console.WriteLine($"Found {markdownFiles.Length} markdown files");

        // Build navigation structure
        var navHtml = BuildNavigation(markdownFiles, inputDir);

        // Generate HTML for each markdown file
        int generated = 0;
        foreach (var mdFile in markdownFiles)
        {
            GeneratePage(mdFile, inputDir, outputDir, navHtml, title);
            generated++;
        }

        // Copy assets
        CopyAssets(outputDir);

        Console.WriteLine($"Generated {generated} documentation pages");
    }

    private void LoadTemplate()
    {
        var templatePath = FileHelpers.FindDefaultFile("docs-template.html");
        if (!File.Exists(templatePath))
        {
            Console.Error.WriteLine($"Error: Template not found at {templatePath}");
            Environment.Exit(1);
        }
        _template = File.ReadAllText(templatePath);
        Console.WriteLine($"Loaded template from {templatePath}");
    }

    private string GenerateCacheBuster()
    {
        var cssPath = FileHelpers.FindDefaultFile("docs-styles.css");
        var jsPath = FileHelpers.FindDefaultFile("docs.js");
        
        if (!File.Exists(cssPath) || !File.Exists(jsPath))
        {
            return DateTime.UtcNow.ToString("yyyyMMddHHmmss");
        }
        
        using var sha = System.Security.Cryptography.SHA256.Create();
        var cssBytes = File.ReadAllBytes(cssPath);
        var jsBytes = File.ReadAllBytes(jsPath);
        var combined = cssBytes.Concat(jsBytes).ToArray();
        var hash = sha.ComputeHash(combined);
        return Convert.ToHexString(hash).Substring(0, 12).ToLowerInvariant();
    }

    private string BuildNavigation(FileInfo[] files, DirectoryInfo baseDir)
    {
        var nav = new StringBuilder();
        
        // Group by section based on the original Home.md structure
        var sections = new Dictionary<string, List<(string title, string file)>>
        {
            ["Getting Started"] = new(),
            ["Configuration"] = new(),
            ["Updates"] = new(),
            ["Platform Support"] = new()
        };

        foreach (var file in files.OrderBy(f => f.Name))
        {
            var fileName = Path.GetFileNameWithoutExtension(file.Name);
            var displayName = fileName.Replace("-", " ").Replace("²", "²");
            
            // Categorize based on filename
            if (fileName.StartsWith("Getting-Started"))
                sections["Getting Started"].Add((displayName, fileName + ".html"));
            else if (fileName.StartsWith("MDK") || fileName.StartsWith("Mixin") || fileName.StartsWith("Controlling") || fileName.StartsWith("Using-the-Minifier") || fileName.Contains("Programmable-Block"))
                sections["Configuration"].Add((displayName, fileName + ".html"));
            else if (fileName.StartsWith("Updating"))
                sections["Updates"].Add((displayName, fileName + ".html"));
            else if (fileName.StartsWith("Running"))
                sections["Platform Support"].Add((displayName, fileName + ".html"));
            else if (fileName == "index")
                nav.Insert(0, $"<a href=\"index.html\">Home</a>\n");
        }

        // Build navigation HTML
        foreach (var section in sections)
        {
            if (section.Value.Count > 0)
            {
                nav.AppendLine($"<h3>{section.Key}</h3>");
                nav.AppendLine("<ul>");
                foreach (var (title, file) in section.Value.OrderBy(x => x.title))
                {
                    nav.AppendLine($"    <li><a href=\"{file}\">{title}</a></li>");
                }
                nav.AppendLine("</ul>");
            }
        }

        return nav.ToString();
    }

    private void GeneratePage(FileInfo mdFile, DirectoryInfo inputDir, DirectoryInfo outputDir, string navHtml, string siteTitle)
    {
        var markdown = File.ReadAllText(mdFile.FullName);
        
        // Convert markdown to HTML
        var html = Markdown.ToHtml(markdown, _pipeline);
        
        var fileName = Path.GetFileNameWithoutExtension(mdFile.Name);
        var displayName = fileName.Replace("-", " ").Replace("²", "²");
        var browserTitle = fileName == "index" ? siteTitle : $"{displayName} - {siteTitle}";
        
        var outputPath = Path.Combine(outputDir.FullName, fileName + ".html");
        
        // Replace placeholders
        var finalHtml = _template
            .Replace("{{BROWSER_TITLE}}", browserTitle)
            .Replace("{{ROOT_PATH}}", "")
            .Replace("{{CACHE_BUSTER}}", _cacheBuster)
            .Replace("{{SIDEBAR_NAV}}", navHtml)
            .Replace("{{GENERATION_TIMESTAMP}}", $"<span>Generated {DateTime.UtcNow:yyyy-MM-dd HH:mm} UTC</span>")
            .Replace("{{CONTENT}}", html);
        
        File.WriteAllText(outputPath, finalHtml);
    }

    private void CopyAssets(DirectoryInfo outputDir)
    {
        var assets = new[] { "docs-styles.css", "docs.js", "wiki.png", "mdk2.png" };
        
        foreach (var asset in assets)
        {
            var sourcePath = FileHelpers.FindDefaultFile(asset);
            if (File.Exists(sourcePath))
            {
                var destPath = Path.Combine(outputDir.FullName, asset);
                File.Copy(sourcePath, destPath, true);
            }
        }
        
        Console.WriteLine($"Copied {assets.Length} asset files");
    }
}
