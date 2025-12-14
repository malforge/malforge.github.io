using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DocGen.Services;

namespace DocGen.Commands
{
    public static class JsonCommand
    {
        public static async Task<int> ExecuteAsync(string[] args)
        {
            if (args.Contains("--help") || args.Contains("-h"))
            {
                ShowHelp();
                return 0;
            }

            var terminalPath = GetArgValue(args, "--terminal");
            var whitelistPath = GetArgValue(args, "--whitelist");
            var outputPath = GetArgValue(args, "--output");

            // Auto-detect terminal file if not specified
            if (string.IsNullOrEmpty(terminalPath)) terminalPath = FileHelpers.FindDefaultFile("terminal.dat");

            // Auto-detect whitelist file if not specified
            if (string.IsNullOrEmpty(whitelistPath)) whitelistPath = FileHelpers.FindDefaultFile("pbwhitelist.dat");

            if (string.IsNullOrEmpty(outputPath))
            {
                Console.Error.WriteLine("✗ Missing required argument: --output");
                ShowHelp();
                return 1;
            }

            // If output is a directory, append default filename
            if (Directory.Exists(outputPath))
            {
                outputPath = Path.Combine(outputPath, "api-data.json");
            }

            if (!File.Exists(terminalPath))
            {
                Console.Error.WriteLine($"✗ Terminal cache file not found: {terminalPath}");
                Console.Error.WriteLine("  Specify with --terminal or place terminal.dat in the current directory");
                return 1;
            }

            if (!File.Exists(whitelistPath))
            {
                Console.Error.WriteLine($"✗ Whitelist file not found: {whitelistPath}");
                Console.Error.WriteLine("  Specify with --whitelist or place pbwhitelist.dat in the current directory");
                return 1;
            }

            Console.WriteLine("Generating JSON API data...");
            Console.WriteLine($"  Terminal: {terminalPath}");
            Console.WriteLine($"  Whitelist: {whitelistPath}");
            Console.WriteLine($"  Output: {outputPath}");

            try
            {
                await ProgrammableBlockApiJson.Export(terminalPath, whitelistPath, outputPath);
                Console.WriteLine("✓ JSON API data generated successfully");
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
            Console.WriteLine("Generate JSON API data from whitelist");
            Console.WriteLine();
            Console.WriteLine("Usage: docgen json --output <file> [--terminal <file>] [--whitelist <file>]");
            Console.WriteLine();
            Console.WriteLine("Options:");
            Console.WriteLine("  --output     Output JSON file (required)");
            Console.WriteLine("  --terminal   Path to terminal.dat cache file (default: current dir, fallback: exe dir)");
            Console.WriteLine("  --whitelist  Path to pbwhitelist.dat file (default: current dir, fallback: exe dir)");
        }

        static string GetArgValue(string[] args, string flag)
        {
            var index = Array.IndexOf(args, flag);
            return index >= 0 && index < args.Length - 1 ? args[index + 1] : null;
        }
    }
}
