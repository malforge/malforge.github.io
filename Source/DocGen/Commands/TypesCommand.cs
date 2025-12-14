using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DocGen.Services;
using DocGen.Steam;

namespace DocGen.Commands
{
    public static class TypesCommand
    {
        public static async Task<int> ExecuteAsync(string[] args)
        {
            if (args.Contains("--help") || args.Contains("-h"))
            {
                ShowHelp();
                return 0;
            }

            var terminalPath = GetArgValue(args, "--terminal");
            var outputPath = GetArgValue(args, "--output") ?? "Type-Definition-Listing.md";
            var sePath = GetArgValue(args, "--se-path");

            // Auto-detect terminal file if not specified
            if (string.IsNullOrEmpty(terminalPath)) terminalPath = FileHelpers.FindDefaultFile("terminal.dat");

            // If output is a directory (no .md extension), use default filename
            if (!outputPath.EndsWith(".md", StringComparison.OrdinalIgnoreCase)) outputPath = Path.Combine(outputPath, "Type-Definition-Listing.md");

            if (!File.Exists(terminalPath))
            {
                Console.Error.WriteLine($"✗ Terminal cache file not found: {terminalPath}");
                Console.Error.WriteLine("  Specify with --terminal or place terminal.dat in the current directory");
                return 1;
            }

            var spaceEngineers = new SpaceEngineers();
            string dataPath;
            string binPath;

            if (sePath == null)
            {
                var autoPath = spaceEngineers.GetInstallPath();
                if (autoPath == null)
                {
                    Console.Error.WriteLine("✗ Could not auto-detect Space Engineers installation.");
                    Console.Error.WriteLine("  Use --se-path to specify the installation directory.");
                    return 1;
                }

                Console.WriteLine($"  Detected Space Engineers: {autoPath}");
                dataPath = spaceEngineers.GetInstallPath("Content", "Data");
                binPath = spaceEngineers.GetInstallPath("Bin64");
            }
            else
            {
                dataPath = Path.Combine(sePath, "Content", "Data");
                binPath = Path.Combine(sePath, "Bin64");
            }

            Console.WriteLine("Generating type definition listing...");
            Console.WriteLine($"  Terminal: {terminalPath}");
            Console.WriteLine($"  Output: {outputPath}");

            try
            {
                await TypeDefinitions.UpdateAsync(terminalPath, dataPath, outputPath, binPath);
                Console.WriteLine("✓ Type definition listing generated successfully");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"✗ Error: {ex.Message}");
                return 1;
            }
        }

        static void ShowHelp()
        {
            Console.WriteLine("Generate type definition listing");
            Console.WriteLine();
            Console.WriteLine("Usage: docgen types [--terminal <file>] [--output <file>] [--se-path <directory>]");
            Console.WriteLine();
            Console.WriteLine("Options:");
            Console.WriteLine("  --terminal   Path to terminal.dat cache file (default: current dir, fallback: exe dir)");
            Console.WriteLine("  --output     Output markdown file (default: Type-Definition-Listing.md)");
            Console.WriteLine("  --se-path    Space Engineers installation path (auto-detected if not specified)");
        }

        static string GetArgValue(string[] args, string flag)
        {
            var index = Array.IndexOf(args, flag);
            return index >= 0 && index < args.Length - 1 ? args[index + 1] : null;
        }
    }
}