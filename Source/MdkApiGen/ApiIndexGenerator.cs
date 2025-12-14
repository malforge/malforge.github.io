using Markdig;
using System.Net;
using System.Text;
using System.Text.Json;

namespace MdkApiGen;

class ApiIndexGenerator
{
    private readonly MarkdownPipeline _pipeline;
    private Dictionary<string, ApiNode> _apiTree = new();
    private List<ApiFile> _allFiles = new();
    private HashSet<string> _referencedAssets = new();
    private string _baseTreeHtml = ""; // Base tree HTML with placeholders
    private string _searchFeedbackHtml = ""; // Feedback section for search results
    private string _customIndexHtml = ""; // Custom index page content from _index.md
    private HashSet<string> _generatedPaths = new(); // Track all generated files/folders for safe cleanup
    private string _cacheBuster = ""; // Cache-busting query string for CSS/JS
    private string _pageTemplate = ""; // HTML page template

    public ApiIndexGenerator()
    {
        _pipeline = new MarkdownPipelineBuilder()
            .UseAdvancedExtensions()
            .Use(new LinkRewriterExtension(_referencedAssets))
            .Build();
    }

    public void Generate(List<DirectoryInfo> apiDirs, DirectoryInfo outputDir)
    {
        foreach (var apiDir in apiDirs)
        {
            if (!apiDir.Exists)
            {
                Console.Error.WriteLine($"Error: API directory '{apiDir.FullName}' does not exist.");
                return;
            }
        }

        Console.WriteLine($"Generating API pages from {apiDirs.Count} input director{(apiDirs.Count == 1 ? "y" : "ies")}:");
        foreach (var apiDir in apiDirs)
        {
            Console.WriteLine($"  - {apiDir.FullName}");
        }
        Console.WriteLine($"Output directory: {outputDir.FullName}");

        // Generate cache-busting timestamp
        _cacheBuster = DateTime.UtcNow.ToString("yyyyMMddHHmmss");
        Console.WriteLine($"Cache-buster: {_cacheBuster}");

        // Clean output directory safely
        CleanOutputDirectory(outputDir);

        // Load page template
        LoadPageTemplate();

        // Load search feedback from first directory's parent
        LoadSearchFeedback(apiDirs[0]);
        
        // Load custom index from first directory's parent
        LoadCustomIndex(apiDirs[0]);
        
        // Scan all input directories
        foreach (var apiDir in apiDirs)
        {
            ScanApiFiles(apiDir);
        }
        
        BuildTree();
        GenerateSidebarTreeFile(outputDir);
        GeneratePages(outputDir);
        CopyReferencedAssets(apiDirs, outputDir);
        GenerateStylesCss(outputDir);
        CopyJavaScript(outputDir);
        CopyImages(outputDir);
        GenerateSearchIndex(outputDir);
        GenerateEnhancedSearchIndex(apiDirs, outputDir);
        
        // Create key file to mark this as a safe directory to clean
        CreateKeyFile(outputDir);

        Console.WriteLine($"\nGeneration complete! {_allFiles.Count} API pages generated.");
    }

    private void CleanOutputDirectory(DirectoryInfo outputDir)
    {
        const string KEY_FILE = ".mdkapigen";

        if (!outputDir.Exists)
        {
            Console.WriteLine("Creating output directory...");
            outputDir.Create();
            return;
        }

        var keyFile = Path.Combine(outputDir.FullName, KEY_FILE);

        if (!File.Exists(keyFile))
        {
            Console.Error.WriteLine();
            Console.Error.WriteLine("ERROR: Output directory exists but is not marked as safe to clean.");
            Console.Error.WriteLine($"Expected key file: {keyFile}");
            Console.Error.WriteLine();
            Console.Error.WriteLine("This safety check prevents accidentally deleting important files.");
            Console.Error.WriteLine("If you're sure this directory should be cleaned:");
            Console.Error.WriteLine($"  1. Verify the contents of: {outputDir.FullName}");
            Console.Error.WriteLine($"  2. Manually delete the directory, OR");
            Console.Error.WriteLine($"  3. Create an empty file named: {KEY_FILE}");
            Console.Error.WriteLine();
            throw new InvalidOperationException("Output directory not safe to clean - missing key file");
        }

        Console.WriteLine("Cleaning output directory...");

        // Try to load previous manifest
        GenerationManifest? previousManifest = null;
        try
        {
            var manifestJson = File.ReadAllText(keyFile);
            previousManifest = JsonSerializer.Deserialize<GenerationManifest>(manifestJson);
        }
        catch (JsonException)
        {
            // Legacy key file (plain text) - delete everything for backwards compatibility
            Console.WriteLine("Legacy key file detected - performing full cleanup");
            foreach (var file in outputDir.GetFiles())
            {
                file.Delete();
            }
            foreach (var dir in outputDir.GetDirectories())
            {
                dir.Delete(true);
            }
            Console.WriteLine("Output directory cleaned");
            return;
        }

        if (previousManifest == null)
        {
            Console.WriteLine("No previous manifest found - skipping cleanup");
            return;
        }

        // Delete only tracked files from previous generation
        int filesDeleted = 0;
        int dirsDeleted = 0;

        foreach (var relPath in previousManifest.Files)
        {
            var fullPath = Path.Combine(outputDir.FullName, relPath);
            if (File.Exists(fullPath))
            {
                try
                {
                    File.Delete(fullPath);
                    filesDeleted++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Warning: Could not delete {relPath}: {ex.Message}");
                }
            }
        }

        // Delete directories in reverse order (deepest first) to handle nested structures
        foreach (var relPath in previousManifest.Directories.OrderByDescending(p => p.Length))
        {
            var fullPath = Path.Combine(outputDir.FullName, relPath.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar));
            if (Directory.Exists(fullPath))
            {
                try
                {
                    // Only delete if empty (all files should already be deleted)
                    if (!Directory.EnumerateFileSystemEntries(fullPath).Any())
                    {
                        Directory.Delete(fullPath);
                        dirsDeleted++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Warning: Could not delete directory {relPath}: {ex.Message}");
                }
            }
        }

        Console.WriteLine($"Cleaned {filesDeleted} files and {dirsDeleted} directories from previous generation");
    }

    private void CreateKeyFile(DirectoryInfo outputDir)
    {
        const string KEY_FILE = ".mdkapigen";
        var keyFilePath = Path.Combine(outputDir.FullName, KEY_FILE);

        // Create manifest with all generated files
        var manifest = new GenerationManifest
        {
            Generated = DateTime.UtcNow,
            Files = _generatedPaths.Where(p => !p.EndsWith(Path.DirectorySeparatorChar) && !p.EndsWith(Path.AltDirectorySeparatorChar)).OrderBy(p => p).ToList(),
            Directories = _generatedPaths.Where(p => p.EndsWith(Path.DirectorySeparatorChar) || p.EndsWith(Path.AltDirectorySeparatorChar)).OrderBy(p => p).ToList()
        };

        var json = JsonSerializer.Serialize(manifest, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText(keyFilePath, json);
        Console.WriteLine($"Created manifest tracking {manifest.Files.Count} files and {manifest.Directories.Count} directories");
    }

    private void LoadSearchFeedback(DirectoryInfo apiDir)
    {
        var feedbackPath = FileHelpers.FindDefaultFile("_searchfeedback.md");
        
        if (File.Exists(feedbackPath))
        {
            var feedbackMarkdown = File.ReadAllText(feedbackPath);

            try
            {
                _searchFeedbackHtml = Markdown.ToHtml(feedbackMarkdown, _pipeline);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine();
                Console.Error.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.Error.WriteLine("❌ MARKDOWN PARSING FAILED (_searchfeedback.md)");
                Console.Error.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.Error.WriteLine($"File: {feedbackPath}");
                Console.Error.WriteLine($"Size: {new FileInfo(feedbackPath).Length:N0} bytes");
                Console.Error.WriteLine($"Lines: {feedbackMarkdown.Split('\n').Length:N0}");
                Console.Error.WriteLine();
                Console.Error.WriteLine($"Error Type: {ex.GetType().Name}");
                Console.Error.WriteLine($"Error Message: {ex.Message}");
                Console.Error.WriteLine();
                Console.Error.WriteLine("First 500 characters of file:");
                Console.Error.WriteLine("───────────────────────────────────────────────────────────────");
                Console.Error.WriteLine(feedbackMarkdown.Substring(0, Math.Min(500, feedbackMarkdown.Length)));
                if (feedbackMarkdown.Length > 500)
                    Console.Error.WriteLine($"... ({feedbackMarkdown.Length - 500} more characters)");
                Console.Error.WriteLine("═══════════════════════════════════════════════════════════════");
                throw;
            }

            Console.WriteLine($"Loaded search feedback template from {feedbackPath}");
        }
        else
        {
            // Default feedback if file doesn't exist
            _searchFeedbackHtml = "<p><small>If search isn't meeting your needs, please provide feedback!</small></p>";
            Console.WriteLine($"Warning: {feedbackPath} not found, using default");
        }
    }

    private void LoadCustomIndex(DirectoryInfo apiDir)
    {
        var indexPath = FileHelpers.FindDefaultFile("_index.md");
        
        if (File.Exists(indexPath))
        {
            var indexMarkdown = File.ReadAllText(indexPath);

            try
            {
                _customIndexHtml = Markdown.ToHtml(indexMarkdown, _pipeline);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine();
                Console.Error.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.Error.WriteLine("❌ MARKDOWN PARSING FAILED (_index.md)");
                Console.Error.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.Error.WriteLine($"File: {indexPath}");
                Console.Error.WriteLine($"Size: {new FileInfo(indexPath).Length:N0} bytes");
                Console.Error.WriteLine($"Lines: {indexMarkdown.Split('\n').Length:N0}");
                Console.Error.WriteLine();
                Console.Error.WriteLine($"Error Type: {ex.GetType().Name}");
                Console.Error.WriteLine($"Error Message: {ex.Message}");
                Console.Error.WriteLine();
                Console.Error.WriteLine("First 500 characters of file:");
                Console.Error.WriteLine("───────────────────────────────────────────────────────────────");
                Console.Error.WriteLine(indexMarkdown.Substring(0, Math.Min(500, indexMarkdown.Length)));
                if (indexMarkdown.Length > 500)
                    Console.Error.WriteLine($"... ({indexMarkdown.Length - 500} more characters)");
                Console.Error.WriteLine("═══════════════════════════════════════════════════════════════");
                throw;
            }

            Console.WriteLine($"Loaded custom index page from {indexPath}");
        }
        else
        {
            Console.WriteLine($"No custom index found at {indexPath}");
        }
    }

    private void LoadPageTemplate()
    {
        var templatePath = FileHelpers.FindDefaultFile("page-template.html");
        
        if (!File.Exists(templatePath))
        {
            Console.Error.WriteLine($"Error: page-template.html not found at {templatePath}");
            Console.Error.WriteLine("  Checked: current directory and executable directory");
            throw new FileNotFoundException("page-template.html is required but was not found", templatePath);
        }

        _pageTemplate = File.ReadAllText(templatePath);
        Console.WriteLine($"Loaded page template from {templatePath}");
    }

    private void ScanApiFiles(DirectoryInfo apiDir)
    {
        var mdFiles = Directory.GetFiles(apiDir.FullName, "*.md", SearchOption.AllDirectories);

        foreach (var file in mdFiles)
        {
            var fileName = Path.GetFileNameWithoutExtension(file);
            var relativePath = Path.GetRelativePath(apiDir.FullName, file);

            _allFiles.Add(new ApiFile
            {
                FileName = fileName,
                FullPath = file,
                RelativePath = relativePath,
                HtmlPath = Path.ChangeExtension(relativePath, ".html")
            });
        }

        Console.WriteLine($"Found {_allFiles.Count} API files");
    }

    private void CopyReferencedAssets(List<DirectoryInfo> apiDirs, DirectoryInfo outputDir)
    {
        if (_referencedAssets.Count == 0)
        {
            Console.WriteLine("No asset files referenced in markdown");
            return;
        }
            
        Console.WriteLine($"Found {_referencedAssets.Count} referenced asset files");
        Console.WriteLine("Copying referenced assets...");
        int copied = 0;
        int notFound = 0;
        
        foreach (var assetPath in _referencedAssets)
        {
            // Try to find the asset in any of the input directories
            string? sourceFile = null;
            DirectoryInfo? sourceDir = null;
            
            foreach (var apiDir in apiDirs)
            {
                var candidatePath = Path.Combine(apiDir.FullName, assetPath);
                if (File.Exists(candidatePath))
                {
                    sourceFile = candidatePath;
                    sourceDir = apiDir;
                    break;
                }
            }
            
            if (sourceFile != null && sourceDir != null)
            {
                var relativePath = Path.GetRelativePath(sourceDir.FullName, sourceFile);
                var outputPath = Path.Combine(outputDir.FullName, relativePath);
                var outputFileDir = Path.GetDirectoryName(outputPath);
                
                if (!string.IsNullOrEmpty(outputFileDir))
                {
                    Directory.CreateDirectory(outputFileDir);
                    // Track directory (store relative path with trailing separator)
                    var relativeDir = Path.GetRelativePath(outputDir.FullName, outputFileDir) + Path.DirectorySeparatorChar;
                    _generatedPaths.Add(relativeDir);
                }
                
                File.Copy(sourceFile, outputPath, overwrite: true);
                // Track generated file
                _generatedPaths.Add(Path.GetRelativePath(outputDir.FullName, outputPath));
                copied++;
            }
            else
            {
                Console.WriteLine($"Warning: Referenced asset not found: {assetPath}");
                notFound++;
            }
        }
        
        Console.WriteLine($"Copied {copied} referenced asset files");
        if (notFound > 0)
        {
            Console.WriteLine($"Warning: {notFound} referenced assets were not found");
        }
    }

    private void BuildTree()
    {
        foreach (var file in _allFiles)
        {
            // Skip members (contain @) - we don't show them in the sidebar anymore
            if (file.FileName.Contains("@"))
                continue;

            // For nested types (Outer+Inner), keep them as a single node at the namespace level
            // but display with . separator (Outer.Inner)
            string fileName = file.FileName;
            string displayName = fileName.Replace('+', '.');
            
            // Split by dots for namespace hierarchy
            // But if this contains a +, we want to put the whole type (with all nested parts) at the right level
            // Example: VRage.Game.GUI.TextPanel.MySpriteDrawFrame+ClearClipToken
            //   -> Navigate to VRage.Game.GUI.TextPanel
            //   -> Add node "MySpriteDrawFrame.ClearClipToken"
            
            var parts = fileName.Split('.');
            var currentDict = _apiTree;

            // Navigate through namespace parts (all but the last, which is the type)
            for (int i = 0; i < parts.Length - 1; i++)
            {
                var part = parts[i];
                
                if (!currentDict.ContainsKey(part))
                {
                    currentDict[part] = new ApiNode
                    {
                        Name = part,
                        Children = new Dictionary<string, ApiNode>(),
                        Files = new List<ApiFile>()
                    };
                }
                
                currentDict = currentDict[part].Children;
            }

            // The last part is the type (might contain + for nested types)
            var typePart = parts[^1];
            var typeDisplayName = typePart.Replace('+', '.');
            
            if (!currentDict.ContainsKey(typePart))
            {
                currentDict[typePart] = new ApiNode
                {
                    Name = typeDisplayName, // Use display name with . instead of +
                    Children = new Dictionary<string, ApiNode>(),
                    Files = new List<ApiFile>()
                };
            }

            currentDict[typePart].Files.Add(file);
        }

        Console.WriteLine($"Built tree with {_apiTree.Count} root namespaces");
        
        // Mark namespaces (post-process to set IsNamespace flag)
        MarkNamespaces(_apiTree);
        
        // Generate base tree HTML template (will be customized per page)
        Console.WriteLine("Generating base tree template...");
        GenerateBaseTreeTemplate();
    }

    private void MarkNamespaces(Dictionary<string, ApiNode> nodes)
    {
        foreach (var node in nodes.Values)
        {
            // A node is a TYPE if it has a file without @ (the type definition itself)
            // Otherwise it's a namespace
            var hasTypeFile = node.Files.Any(f => !f.FileName.Contains("@"));
            node.IsNamespace = !hasTypeFile;
            
            // Recursively mark children
            if (node.Children.Count > 0)
            {
                MarkNamespaces(node.Children);
            }
        }
    }

    private void GenerateBaseTreeTemplate()
    {
        var sb = new StringBuilder();
        // Sort root nodes: document nodes (no namespace) first, then namespace/type nodes
        foreach (var rootNs in _apiTree.OrderBy(kvp => kvp.Value.IsNamespace ? 1 : 0).ThenBy(kvp => kvp.Key))
        {
            RenderNodeTemplate(sb, rootNs.Value, 0);
        }
        _baseTreeHtml = sb.ToString();
    }

    private void GenerateSidebarTreeFile(DirectoryInfo outputDir)
    {
        Console.WriteLine("Generating sidebar tree file...");
        
        // Generate the tree HTML (it's already in _baseTreeHtml)
        // Replace {{ROOT}} with empty string since all pages are at root level
        var treeHtml = _baseTreeHtml.Replace("{{ROOT}}", "");
        
        var outputPath = Path.Combine(outputDir.FullName, "sidebar-tree.html");
        File.WriteAllText(outputPath, treeHtml);
        
        // Track generated file
        _generatedPaths.Add(Path.GetRelativePath(outputDir.FullName, outputPath));
        Console.WriteLine($"Generated sidebar tree file: sidebar-tree.html");
    }

    private void GeneratePages(DirectoryInfo outputDir)
    {
        Console.WriteLine("Starting page generation...");
        int count = 0;
        foreach (var file in _allFiles)
        {
            var markdownContent = File.ReadAllText(file.FullPath);

            string htmlContent;
            try
            {
                htmlContent = Markdown.ToHtml(markdownContent, _pipeline);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine();
                Console.Error.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.Error.WriteLine("❌ MARKDOWN PARSING FAILED");
                Console.Error.WriteLine("═══════════════════════════════════════════════════════════════");
                Console.Error.WriteLine($"File: {file.FullPath}");
                Console.Error.WriteLine($"File name: {file.FileName}");
                Console.Error.WriteLine($"Relative path: {file.RelativePath}");
                Console.Error.WriteLine($"Size: {new FileInfo(file.FullPath).Length:N0} bytes");
                Console.Error.WriteLine($"Lines: {markdownContent.Split('\n').Length:N0}");
                Console.Error.WriteLine($"Progress: {count}/{_allFiles.Count} files processed before failure");
                Console.Error.WriteLine();
                Console.Error.WriteLine($"Error Type: {ex.GetType().Name}");
                Console.Error.WriteLine($"Error Message: {ex.Message}");
                Console.Error.WriteLine();
                Console.Error.WriteLine("First 500 characters of file:");
                Console.Error.WriteLine("───────────────────────────────────────────────────────────────");
                Console.Error.WriteLine(markdownContent.Substring(0, Math.Min(500, markdownContent.Length)));
                if (markdownContent.Length > 500)
                    Console.Error.WriteLine($"... ({markdownContent.Length - 500} more characters)");
                Console.Error.WriteLine("═══════════════════════════════════════════════════════════════");
                throw;
            }

            // Split the filename into namespace/parent and name
            var fullName = FormatName(file.FileName);
            string namespacePart = "";
            string namePart = fullName;
            
            // Handle different separators: @ for members, + for nested types, . for namespaces
            int memberIndex = fullName.LastIndexOf('@');
            int nestedTypeIndex = fullName.LastIndexOf('+');
            int lastDotIndex = fullName.LastIndexOf('.');
            
            // Determine what to split on (priority: @ > + > .)
            if (memberIndex > 0)
            {
                // It's a member - split at @
                namespacePart = fullName.Substring(0, memberIndex).Replace('+', '.');
                namePart = fullName.Substring(memberIndex + 1);
            }
            else if (nestedTypeIndex > 0)
            {
                // It's a nested type - split at +
                namespacePart = fullName.Substring(0, nestedTypeIndex);
                namePart = fullName.Substring(nestedTypeIndex + 1);
            }
            else if (lastDotIndex > 0)
            {
                // It's a regular type - split at last .
                namespacePart = fullName.Substring(0, lastDotIndex);
                namePart = fullName.Substring(lastDotIndex + 1);
            }
            
            var fullHtml = GenerateHtmlPage(file, namespacePart, namePart, htmlContent);

            var outputPath = Path.Combine(outputDir.FullName, file.HtmlPath);
            var outputFileDir = Path.GetDirectoryName(outputPath);
            if (!string.IsNullOrEmpty(outputFileDir))
            {
                Directory.CreateDirectory(outputFileDir);
                // Track directory (store relative path with trailing separator)
                var relativeDir = Path.GetRelativePath(outputDir.FullName, outputFileDir) + Path.DirectorySeparatorChar;
                _generatedPaths.Add(relativeDir);
            }

            File.WriteAllText(outputPath, fullHtml);
            // Track generated file (store relative path)
            _generatedPaths.Add(Path.GetRelativePath(outputDir.FullName, outputPath));
            
            count++;
            if (count % 100 == 0)
            {
                Console.WriteLine($"  Generated {count}/{_allFiles.Count} pages...");
            }
        }

        Console.WriteLine($"Generated {_allFiles.Count} HTML pages");

        // Generate index.html
        GenerateIndexPage(outputDir);
    }

    private void GenerateIndexPage(DirectoryInfo outputDir)
    {
        string content;
        string title;

        if (!string.IsNullOrEmpty(_customIndexHtml))
        {
            // Use custom _index.md from wiki root
            content = _customIndexHtml;
            title = "API Reference";
            Console.WriteLine("Generated index.html from _index.md");
        }
        else
        {
            // Fallback: Look for index.md in any of the scanned files
            var indexFile = _allFiles.FirstOrDefault(f => f.FileName.Equals("index", StringComparison.OrdinalIgnoreCase));
            
            if (indexFile != null && File.Exists(indexFile.FullPath))
            {
                // Use custom index.md if it exists
                var markdownContent = File.ReadAllText(indexFile.FullPath);

                try
                {
                    content = Markdown.ToHtml(markdownContent, _pipeline);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine();
                    Console.Error.WriteLine("═══════════════════════════════════════════════════════════════");
                    Console.Error.WriteLine("❌ MARKDOWN PARSING FAILED (index.md)");
                    Console.Error.WriteLine("═══════════════════════════════════════════════════════════════");
                    Console.Error.WriteLine($"File: {indexFile.FullPath}");
                    Console.Error.WriteLine($"Size: {new FileInfo(indexFile.FullPath).Length:N0} bytes");
                    Console.Error.WriteLine($"Lines: {markdownContent.Split('\n').Length:N0}");
                    Console.Error.WriteLine();
                    Console.Error.WriteLine($"Error Type: {ex.GetType().Name}");
                    Console.Error.WriteLine($"Error Message: {ex.Message}");
                    Console.Error.WriteLine();
                    Console.Error.WriteLine("First 500 characters of file:");
                    Console.Error.WriteLine("───────────────────────────────────────────────────────────────");
                    Console.Error.WriteLine(markdownContent.Substring(0, Math.Min(500, markdownContent.Length)));
                    if (markdownContent.Length > 500)
                        Console.Error.WriteLine($"... ({markdownContent.Length - 500} more characters)");
                    Console.Error.WriteLine("═══════════════════════════════════════════════════════════════");
                    throw;
                }

                title = "API Reference";
                Console.WriteLine("Generated index.html from index.md");
            }
            else
            {
                // Generate default index page
                content = @"<p>Welcome to the MDK-SE API Reference documentation.</p>
<p>Use the navigation on the left to browse namespaces, types, and members.</p>
<h2>Namespaces</h2>
<ul>
<li><strong>Sandbox</strong> - Core Space Engineers API</li>
<li><strong>VRage</strong> - VRage engine API</li>
<li><strong>VRageMath</strong> - Mathematics library</li>
</ul>";
                title = "API Reference";
                Console.WriteLine("Generated default index.html");
            }
        }

        // Create a dummy ApiFile for index.html (no depth, at root)
        var indexPageFile = new ApiFile
        {
            FileName = "index",
            FullPath = "",
            RelativePath = "index.html",
            HtmlPath = "index.html"
        };

        var fullHtml = GenerateHtmlPage(indexPageFile, "", title, content);
        var outputPath = Path.Combine(outputDir.FullName, "index.html");
        File.WriteAllText(outputPath, fullHtml);
        // Track generated file
        _generatedPaths.Add(Path.GetRelativePath(outputDir.FullName, outputPath));
    }

    private string GenerateHtmlPage(ApiFile currentFile, string namespacePart, string namePart, string content)
    {
        // Calculate relative path to root for CSS
        var depth = currentFile.HtmlPath.Count(c => c == Path.DirectorySeparatorChar || c == Path.AltDirectorySeparatorChar);
        var rootPath = depth > 0 ? string.Join("/", Enumerable.Repeat("..", depth)) + "/" : "";
        
        // Use full name for browser title
        var browserTitle = string.IsNullOrEmpty(namespacePart) ? namePart : $"{namespacePart}.{namePart}";

        // Generate page header (title section)
        string pageHeader = "";
        if (currentFile.FileName != "index")
        {
            if (!string.IsNullOrEmpty(namespacePart))
            {
                var headerBuilder = new StringBuilder();
                headerBuilder.AppendLine("            <div class=\"page-header\">");
                
                // Check if namespace/parent has a corresponding page
                var namespaceFile = _allFiles.FirstOrDefault(f => FormatName(f.FileName) == namespacePart);
                if (namespaceFile != null)
                {
                    var namespaceHtmlPath = namespaceFile.HtmlPath.Replace('\\', '/');
                    headerBuilder.AppendLine($"                <div class=\"page-namespace\"><a href=\"{rootPath}{namespaceHtmlPath}\">{WebUtility.HtmlEncode(namespacePart)}</a></div>");
                }
                else
                {
                    headerBuilder.AppendLine($"                <div class=\"page-namespace\">{WebUtility.HtmlEncode(namespacePart)}</div>");
                }
                
                headerBuilder.AppendLine($"                <h1>{FormatDocumentName(namePart, false)}</h1>");
                headerBuilder.AppendLine("            </div>");
                pageHeader = headerBuilder.ToString();
            }
            else
            {
                pageHeader = $"            <h1>{FormatDocumentName(namePart, false)}</h1>\n";
            }
        }

        // Replace placeholders in template
        var html = _pageTemplate
            .Replace("{{BROWSER_TITLE}}", browserTitle)
            .Replace("{{ROOT_PATH}}", rootPath)
            .Replace("{{CACHE_BUSTER}}", _cacheBuster)
            .Replace("{{CURRENT_FILE_NAME}}", currentFile.FileName)
            .Replace("{{GENERATION_TIMESTAMP}}", $"Generated {DateTime.UtcNow:yyyy-MM-dd HH:mm} UTC")
            .Replace("{{PAGE_HEADER}}", pageHeader)
            .Replace("{{CONTENT}}", content);

        return html;
    }

    private void RenderNode(StringBuilder sb, ApiNode node, string rootPath, int depth, string currentPageFileName)
    {
        var indent = new string(' ', (depth + 3) * 4);
        
        // Get the type file (not a member - no @ in filename)
        var typeFile = node.Files.FirstOrDefault(f => !f.FileName.Contains("@"));
        
        // Determine node type: namespace or type
        var cssClass = node.IsNamespace ? "namespace" : "type";
        
        // Render as expandable if it has children
        if (node.Children.Count > 0)
        {
            // Check if this node is in the path to the current page
            bool isInPath = IsNodeInPathToPage(node, currentPageFileName);

            // Node has children - render as expandable
            var openAttr = isInPath ? " open" : "";
            sb.AppendLine($"{indent}<details class=\"{cssClass}\"{openAttr}>");
            sb.AppendLine($"{indent}    <summary>{FormatDocumentName(node.Name, node.IsNamespace)}</summary>");
            sb.AppendLine($"{indent}    <ul>");

            // Render child nodes - document nodes first, then namespace/type nodes
            foreach (var child in node.Children.OrderBy(kvp => kvp.Value.IsNamespace ? 1 : 0).ThenBy(kvp => kvp.Key))
            {
                sb.AppendLine($"{indent}        <li>");
                RenderNode(sb, child.Value, rootPath, depth + 1, currentPageFileName);
                sb.AppendLine($"{indent}        </li>");
            }

            sb.AppendLine($"{indent}    </ul>");
            sb.AppendLine($"{indent}</details>");
        }
        else if (typeFile != null)
        {
            // Type/namespace without children - render as simple link
            var activeClass = typeFile.FileName == currentPageFileName ? " active" : "";
            sb.AppendLine($"{indent}<a href=\"{rootPath}{typeFile.HtmlPath}\" class=\"{cssClass}-link{activeClass}\">{FormatDocumentName(node.Name, node.IsNamespace)}</a>");
        }
    }

    private bool IsNodeInPathToPage(ApiNode node, string currentPageFileName)
    {
        // Check if any file in this node matches the current page
        if (node.Files.Any(f => f.FileName == currentPageFileName))
            return true;

        // Check if any child node is in the path
        foreach (var child in node.Children.Values)
        {
            if (IsNodeInPathToPage(child, currentPageFileName))
                return true;
        }

        return false;
    }

    private void RenderNodeTemplate(StringBuilder sb, ApiNode node, int depth)
    {
        var indent = new string(' ', (depth + 3) * 4);
        
        // Get the type file (not a member - no @ in filename)
        var typeFile = node.Files.FirstOrDefault(f => !f.FileName.Contains("@"));
        
        // Determine node type: namespace or type
        var cssClass = node.IsNamespace ? "namespace" : "type";
        
        // Render as expandable if it has children
        if (node.Children.Count > 0)
        {
            // Node has children - render as expandable with placeholders
            sb.AppendLine($"{indent}<details class=\"{cssClass}\">");
            sb.AppendLine($"{indent}    <summary>{FormatDocumentName(node.Name, node.IsNamespace)}</summary>");
            sb.AppendLine($"{indent}    <ul>");

            // Render child nodes - document nodes first, then namespace/type nodes
            foreach (var child in node.Children.OrderBy(kvp => kvp.Value.IsNamespace ? 1 : 0).ThenBy(kvp => kvp.Key))
            {
                sb.AppendLine($"{indent}        <li>");
                RenderNodeTemplate(sb, child.Value, depth + 1);
                sb.AppendLine($"{indent}        </li>");
            }

            sb.AppendLine($"{indent}    </ul>");
            sb.AppendLine($"{indent}</details>");
        }
        else if (typeFile != null)
        {
            // Type/namespace without children - render as simple link
            sb.AppendLine($"{indent}<a href=\"{{{{ROOT}}}}{typeFile.HtmlPath}\" class=\"{cssClass}-link\" data-file=\"{typeFile.FileName}\">{FormatDocumentName(node.Name, node.IsNamespace)}</a>");
        }
    }

    private string CustomizeTreeForPage(string baseTree, string currentFileName, string rootPath)
    {
        // Replace root path placeholder
        var customized = baseTree.Replace("{{ROOT}}", rootPath);
        
        // Find and mark active link
        customized = System.Text.RegularExpressions.Regex.Replace(
            customized,
            $@"<a([^>]*data-file=""{System.Text.RegularExpressions.Regex.Escape(currentFileName)}""[^>]*)>",
            m =>
            {
                var attrs = m.Groups[1].Value;
                if (attrs.Contains("class=\""))
                    attrs = attrs.Replace("class=\"", "class=\"active ");
                else
                    attrs += " class=\"active\"";
                return $"<a{attrs}>";
            });
        
        // Find and mark active namespace-link or type-link
        customized = System.Text.RegularExpressions.Regex.Replace(
            customized,
            $@"<a href=""([^""]*)"" class=""(namespace-link|type-link)"" data-file=""{System.Text.RegularExpressions.Regex.Escape(currentFileName)}"">",
            m => $"<a href=\"{m.Groups[1].Value}\" class=\"{m.Groups[2].Value} active\" data-file=\"{currentFileName}\">");
        
        return customized;
    }

    private string EscapeForJavaScript(string html)
    {
        return html
            .Replace("\\", "\\\\")
            .Replace("'", "\\'")
            .Replace("`", "\\`")
            .Replace("$", "\\$")
            .Replace("\r\n", "\\n")
            .Replace("\n", "\\n")
            .Replace("\r", "\\n");
    }

    private string FormatName(string name)
    {
        // Replace curly braces with angle brackets for generics
        name = name.Replace('{', '<').Replace('}', '>');

        // Handle .ctor
        if (name == ".ctor")
            name = "Constructors";

        return name;
    }

    private string FormatDocumentName(string name, bool isNamespace)
    {
        // First apply standard formatting
        name = FormatName(name);
        
        // For root documents (not namespaces/types), replace dashes and underscores with non-breaking spaces
        // A root document has no dots AND is not a namespace (i.e., it's a standalone document file)
        if (!name.Contains('.') && !isNamespace && (name.Contains('-') || name.Contains('_')))
        {
            name = name.Replace('-', '\u00A0').Replace('_', '\u00A0');
        }
        
        // HTML encode to handle < and > from generics
        return WebUtility.HtmlEncode(name);
    }

    private void GenerateStylesCss(DirectoryInfo outputDir)
    {
        var templatePath = FileHelpers.FindDefaultFile("styles.css");
        if (!File.Exists(templatePath))
        {
            Console.Error.WriteLine($"Error: styles.css template not found at {templatePath}");
            Console.Error.WriteLine("  Checked: current directory and executable directory");
            return;
        }

        var css = File.ReadAllText(templatePath);
        var outputPath = Path.Combine(outputDir.FullName, "styles.css");
        File.WriteAllText(outputPath, css);
        // Track generated file
        _generatedPaths.Add(Path.GetRelativePath(outputDir.FullName, outputPath));
        Console.WriteLine($"Copied styles.css from {templatePath}");
    }
    private void CopyJavaScript(DirectoryInfo outputDir)
    {
        var jsSourcePath = FileHelpers.FindDefaultFile("api-index.js");
        var jsOutputPath = Path.Combine(outputDir.FullName, "api-index.js");

        if (File.Exists(jsSourcePath))
        {
            // Read the JS template and replace the placeholder with actual feedback HTML
            var jsContent = File.ReadAllText(jsSourcePath);
            jsContent = jsContent.Replace("SEARCH_FEEDBACK_PLACEHOLDER", EscapeForJavaScript(_searchFeedbackHtml));

            File.WriteAllText(jsOutputPath, jsContent);
            // Track generated file
            _generatedPaths.Add(Path.GetRelativePath(outputDir.FullName, jsOutputPath));
            Console.WriteLine($"Copied api-index.js from {jsSourcePath}");
        }
        else
        {
            Console.Error.WriteLine($"Error: api-index.js template not found at {jsSourcePath}");
            Console.Error.WriteLine("  Checked: current directory and executable directory");
        }
    }
    
    private void CopyImages(DirectoryInfo outputDir)
    {
        var wikiImagePath = FileHelpers.FindDefaultFile("wiki.png");
        if (File.Exists(wikiImagePath))
        {
            var outputPath = Path.Combine(outputDir.FullName, "wiki.png");
            File.Copy(wikiImagePath, outputPath, overwrite: true);
            _generatedPaths.Add(Path.GetRelativePath(outputDir.FullName, outputPath));
            Console.WriteLine($"Copied wiki.png from {wikiImagePath}");
        }
        
        var mdkImagePath = FileHelpers.FindDefaultFile("mdk2.png");
        if (File.Exists(mdkImagePath))
        {
            var outputPath = Path.Combine(outputDir.FullName, "mdk2.png");
            File.Copy(mdkImagePath, outputPath, overwrite: true);
            _generatedPaths.Add(Path.GetRelativePath(outputDir.FullName, outputPath));
            Console.WriteLine($"Copied mdk2.png from {mdkImagePath}");
        }
    }
    
    private void GenerateSearchIndex(DirectoryInfo outputDir)
    {
        Console.WriteLine("Generating search index...");
        
        var searchItems = new List<object>();
        
        foreach (var file in _allFiles)
        {
            var fullName = FormatName(file.FileName);
            string itemType;
            string displayName;
            
            // Determine type: namespace, type, or member
            int memberIndex = fullName.LastIndexOf('@');
            int nestedTypeIndex = fullName.LastIndexOf('+');
            
            if (memberIndex > 0)
            {
                itemType = "member";
                displayName = fullName.Substring(memberIndex + 1);
            }
            else if (nestedTypeIndex > 0)
            {
                itemType = "type";
                displayName = fullName.Substring(nestedTypeIndex + 1);
            }
            else
            {
                // Check if it's a namespace or type
                var node = FindNodeByFileName(file.FileName);
                itemType = (node?.IsNamespace ?? false) ? "namespace" : "type";
                var lastDot = fullName.LastIndexOf('.');
                displayName = lastDot > 0 ? fullName.Substring(lastDot + 1) : fullName;
            }
            
            searchItems.Add(new
            {
                name = displayName,
                fullName = fullName,
                type = itemType,
                path = file.HtmlPath.Replace('\\', '/')
            });
        }
        
        var json = JsonSerializer.Serialize(searchItems, new JsonSerializerOptions
        {
            WriteIndented = false
        });

        var outputPath = Path.Combine(outputDir.FullName, "search-index-old.json");
        File.WriteAllText(outputPath, json);
        // Track generated file
        _generatedPaths.Add(Path.GetRelativePath(outputDir.FullName, outputPath));
        Console.WriteLine($"Generated old search index with {searchItems.Count} items");
    }
    
    private void GenerateEnhancedSearchIndex(List<DirectoryInfo> apiDirs, DirectoryInfo outputDir)
    {
        Console.WriteLine("Generating enhanced search index from api-data.json...");
        
        // Try to find api-data.json in the input directories
        string? apiDataPath = null;
        foreach (var apiDir in apiDirs)
        {
            var candidatePath = Path.Combine(apiDir.FullName, "api-data.json");
            if (File.Exists(candidatePath))
            {
                apiDataPath = candidatePath;
                break;
            }
        }
        
        if (apiDataPath == null)
        {
            Console.WriteLine("Warning: api-data.json not found, skipping enhanced search index");
            return;
        }
        
        try
        {
            var jsonContent = File.ReadAllText(apiDataPath);
            var apiData = JsonSerializer.Deserialize<ApiDataJson>(jsonContent);
            
            if (apiData == null || apiData.Types == null)
            {
                Console.WriteLine("Warning: Could not deserialize api-data.json");
                return;
            }
            
            // Build a set of existing files from the current index for quick lookup
            var existingFiles = new HashSet<string>(_allFiles.Select(f => f.FileName), StringComparer.OrdinalIgnoreCase);
            
            var searchItems = new List<object>();
            int skippedMembers = 0;
            var skippedTypes = new List<string>();
            
            // Add all types
            foreach (var type in apiData.Types)
            {
                // Files are flat in the output directory with dots in the filename
                // Example: Sandbox.ModAPI.Ingame.ChargeMode.html
                var typePath = type.FullName + ".html";
                
                searchItems.Add(new
                {
                    name = type.Name,
                    fullName = type.FullName,
                    type = "type",
                    kind = type.Kind,
                    ns = type.Namespace,
                    path = typePath,
                    summary = type.Documentation?.Summary
                });
                
                // Check if this type has an override message (which means members are suppressed)
                bool hasOverride = type.BlockInfo?.OverrideMessage != null;
                
                // Add all members of this type (unless overridden)
                if (type.Members != null && !hasOverride)
                {
                    foreach (var member in type.Members)
                    {
                        // Check if this member has its own file (uses @ separator)
                        var memberFileName = $"{type.FullName}@{member.Name}";
                        bool hasOwnFile = existingFiles.Contains(memberFileName);
                        
                        string memberPath;
                        if (hasOwnFile)
                        {
                            // Member has its own page: TypeName@MemberName.html
                            memberPath = type.FullName + "@" + member.Name + ".html";
                        }
                        else
                        {
                            // Member is on the type's page with an anchor
                            memberPath = type.FullName + ".html#" + member.Name;
                        }
                        
                        searchItems.Add(new
                        {
                            name = member.Name,
                            fullName = $"{type.FullName}.{member.Name}",
                            type = "member",
                            kind = member.Kind,
                            parent = type.FullName,
                            ns = type.Namespace,
                            path = memberPath,
                            summary = member.Documentation?.Summary,
                            isStatic = member.IsStatic
                        });
                    }
                }
                else if (type.Members != null && hasOverride)
                {
                    skippedMembers += type.Members.Count;
                    skippedTypes.Add(type.FullName);
                }
            }
            
            // Add namespaces
            if (apiData.Namespaces != null)
            {
                foreach (var ns in apiData.Namespaces)
                {
                    var nsPath = ns.Name + ".html";
                    
                    searchItems.Add(new
                    {
                        name = ns.Name.Split('.').Last(),
                        fullName = ns.Name,
                        type = "namespace",
                        kind = "namespace",
                        path = nsPath,
                        typeCount = ns.Types?.Count ?? 0
                    });
                }
            }
            
            var json = JsonSerializer.Serialize(searchItems, new JsonSerializerOptions
            {
                WriteIndented = false
            });
            
            var outputPath = Path.Combine(outputDir.FullName, "search-index.json");
            File.WriteAllText(outputPath, json);
            // Track generated file
            _generatedPaths.Add(Path.GetRelativePath(outputDir.FullName, outputPath));
            
            var memberCount = searchItems.Count - apiData.Types.Count - (apiData.Namespaces?.Count ?? 0);
            Console.WriteLine($"Generated search index with {searchItems.Count} items ({apiData.Types.Count} types, {memberCount} members, {apiData.Namespaces?.Count ?? 0} namespaces)");
            
            if (skippedMembers > 0)
            {
                Console.WriteLine($"  Skipped {skippedMembers} members from {skippedTypes.Count} overridden type(s): {string.Join(", ", skippedTypes.Select(t => t.Split('.').Last()))}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Warning: Failed to generate enhanced search index: {ex.Message}");
        }
    }
    
    private ApiNode? FindNodeByFileName(string fileName)
    {
        // Simple lookup - navigate the tree to find the node
        var parts = fileName.Split('.');
        Dictionary<string, ApiNode>? currentDict = _apiTree;
        
        foreach (var part in parts)
        {
            if (currentDict == null || !currentDict.ContainsKey(part))
                return null;
            
            var node = currentDict[part];
            if (parts[parts.Length - 1] == part)
                return node;
            
            currentDict = node.Children;
        }
        
        return null;
    }
}

class ApiFile
{
    public string FileName { get; set; } = string.Empty;
    public string FullPath { get; set; } = string.Empty;
    public string RelativePath { get; set; } = string.Empty;
    public string HtmlPath { get; set; } = string.Empty;
}

class ApiNode
{
    public string Name { get; set; } = string.Empty;
    public Dictionary<string, ApiNode> Children { get; set; } = new();
    public List<ApiFile> Files { get; set; } = new();
    public bool IsNamespace { get; set; } = false;
}

class GenerationManifest
{
    public DateTime Generated { get; set; }
    public List<string> Files { get; set; } = new();
    public List<string> Directories { get; set; } = new();
}

// Classes for deserializing api-data.json
class ApiDataJson
{
    public DateTime GeneratedDate { get; set; }
    public List<TypeJsonData> Types { get; set; } = new();
    public List<NamespaceJsonData> Namespaces { get; set; } = new();
}

class NamespaceJsonData
{
    public string Name { get; set; } = string.Empty;
    public List<string> Types { get; set; } = new();
}

class TypeJsonData
{
    public string FullName { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Namespace { get; set; } = string.Empty;
    public string Kind { get; set; } = string.Empty;
    public DocumentationJsonData? Documentation { get; set; }
    public List<MemberJsonData>? Members { get; set; }
    public BlockInfoJsonData? BlockInfo { get; set; }
}

class BlockInfoJsonData
{
    public string? OverrideMessage { get; set; }
}

class MemberJsonData
{
    public string Kind { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public bool IsStatic { get; set; }
    public DocumentationJsonData? Documentation { get; set; }
}

class DocumentationJsonData
{
    public string? Summary { get; set; }
}
