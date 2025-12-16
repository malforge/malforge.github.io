using MdkApiGen;

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
