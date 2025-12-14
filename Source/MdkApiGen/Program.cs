using MdkApiGen;

if (args.Length < 4)
{
    Console.WriteLine("API Index Generator");
    Console.WriteLine("Usage: WikiGenerator --input <api-directory> [--input <api-directory>...] --output <output-directory>");
    Console.WriteLine();
    Console.WriteLine("Options:");
    Console.WriteLine("  --input, -i   The api directory containing markdown files (can be specified multiple times)");
    Console.WriteLine("  --output, -o  The output directory for generated index.html");
    return 1;
}

List<DirectoryInfo> inputDirs = new();
DirectoryInfo? outputDir = null;

for (int i = 0; i < args.Length - 1; i++)
{
    if (args[i] == "--input" || args[i] == "-i")
    {
        inputDirs.Add(new DirectoryInfo(args[i + 1]));
    }
    else if (args[i] == "--output" || args[i] == "-o")
    {
        outputDir = new DirectoryInfo(args[i + 1]);
    }
}

if (inputDirs.Count == 0 || outputDir == null)
{
    Console.Error.WriteLine("Error: At least one --input and --output arguments are required.");
    return 1;
}

var generator = new ApiIndexGenerator();
generator.Generate(inputDirs, outputDir);

return 0;
