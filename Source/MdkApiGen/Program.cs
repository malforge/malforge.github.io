using MdkApiGen;

// Check for docs mode first
if (args.Length > 0 && args[0] == "--docs")
{
    if (args.Length < 5)
    {
        Console.WriteLine("Documentation Generator");
        Console.WriteLine("Usage: MdkApiGen --docs --input <docs-directory> --output <output-directory>");
        Console.WriteLine();
        Console.WriteLine("Options:");
        Console.WriteLine("  --input, -i      The directory containing markdown documentation files");
        Console.WriteLine("  --output, -o     The output directory for generated HTML");
        Console.WriteLine("  --title          Documentation site title (default: 'Documentation')");
        return 1;
    }

    DirectoryInfo? docsInputDir = null;
    DirectoryInfo? docsOutputDir = null;
    string title = "Documentation";

    for (int i = 1; i < args.Length; i++)
    {
        if (args[i] == "--input" || args[i] == "-i")
        {
            if (i + 1 < args.Length)
                docsInputDir = new DirectoryInfo(args[i + 1]);
        }
        else if (args[i] == "--output" || args[i] == "-o")
        {
            if (i + 1 < args.Length)
                docsOutputDir = new DirectoryInfo(args[i + 1]);
        }
        else if (args[i] == "--title")
        {
            if (i + 1 < args.Length)
                title = args[i + 1];
        }
    }

    if (docsInputDir == null || docsOutputDir == null)
    {
        Console.Error.WriteLine("Error: Both --input and --output are required.");
        return 1;
    }

    var docGen = new DocGenerator();
    docGen.Generate(docsInputDir, docsOutputDir, title);
    return 0;
}

if (args.Length < 4)
{
    Console.WriteLine("API Index Generator");
    Console.WriteLine("Usage: WikiGenerator --input <api-directory> [--input <api-directory>...] --output <output-directory>");
    Console.WriteLine();
    Console.WriteLine("Options:");
    Console.WriteLine("  --input, -i          The api directory containing markdown files (can be specified multiple times)");
    Console.WriteLine("  --output, -o         The output directory for generated index.html");
    Console.WriteLine("  --index-file         Custom _index.md file (default: _index.md)");
    Console.WriteLine("  --feedback-file      Custom _searchfeedback.md file (default: _searchfeedback.md)");
    Console.WriteLine("  --api-type           API type: 'pb' or 'mod' (used for API switcher)");
    Console.WriteLine("  --force              Force regeneration of all files, ignoring timestamps");
    return 1;
}

List<DirectoryInfo> inputDirs = new();
DirectoryInfo? outputDir = null;
string? customIndexFile = null;
string? customFeedbackFile = null;
string? apiType = null;
bool forceRegeneration = false;

for (int i = 0; i < args.Length; i++)
{
    if (args[i] == "--input" || args[i] == "-i")
    {
        if (i + 1 < args.Length)
            inputDirs.Add(new DirectoryInfo(args[i + 1]));
    }
    else if (args[i] == "--output" || args[i] == "-o")
    {
        if (i + 1 < args.Length)
            outputDir = new DirectoryInfo(args[i + 1]);
    }
    else if (args[i] == "--index-file")
    {
        if (i + 1 < args.Length)
            customIndexFile = args[i + 1];
    }
    else if (args[i] == "--feedback-file")
    {
        if (i + 1 < args.Length)
            customFeedbackFile = args[i + 1];
    }
    else if (args[i] == "--api-type")
    {
        if (i + 1 < args.Length)
            apiType = args[i + 1].ToLower();
    }
    else if (args[i] == "--force")
    {
        forceRegeneration = true;
    }
}

if (inputDirs.Count == 0 || outputDir == null)
{
    Console.Error.WriteLine("Error: At least one --input and --output arguments are required.");
    return 1;
}

var generator = new ApiIndexGenerator();
generator.Generate(inputDirs, outputDir, customIndexFile, customFeedbackFile, forceRegeneration, apiType);

return 0;
