using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DocGen.Services;

namespace DocGen.Commands
{
    public static class TerminalsCommand
    {
        public static async Task<int> ExecuteAsync(string[] args)
        {
            if (args.Contains("--help") || args.Contains("-h"))
            {
                ShowHelp();
                return 0;
            }

            var cachePath = GetArgValue(args, "--terminal");
            var outputPath = GetArgValue(args, "--output") ?? "List-Of-Terminal-Properties-And-Actions.md";

            // If output is a directory (no .md extension), use default filename
            if (!outputPath.EndsWith(".md", StringComparison.OrdinalIgnoreCase)) outputPath = Path.Combine(outputPath, "List-Of-Terminal-Properties-And-Actions.md");

            // Auto-detect cache file if not specified
            if (string.IsNullOrEmpty(cachePath)) cachePath = FileHelpers.FindDefaultFile("terminal.dat");

            if (!File.Exists(cachePath))
            {
                Console.Error.WriteLine($"✗ Terminal cache file not found: {cachePath}");
                Console.Error.WriteLine("  Specify with --terminal or place terminal.dat in the current directory");
                return 1;
            }

            Console.WriteLine("Generating terminal documentation...");
            Console.WriteLine($"  Cache: {cachePath}");
            Console.WriteLine($"  Output: {outputPath}");

            try
            {
                await Terminals.Update(cachePath, outputPath, status => Console.WriteLine($"  {status}"));
                Console.WriteLine("✓ Terminal documentation generated successfully");
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
            Console.WriteLine("Generate terminal properties/actions listing");
            Console.WriteLine();
            Console.WriteLine("Usage: docgen terminals [--terminal <file>] [--output <file>]");
            Console.WriteLine();
            Console.WriteLine("Options:");
            Console.WriteLine("  --terminal   Path to terminal.dat cache file (default: current dir, fallback: exe dir)");
            Console.WriteLine("  --output     Output file or directory (default: List-Of-Terminal-Properties-And-Actions.md)");
            Console.WriteLine("               If directory specified, uses default filename within it");
        }

        static string GetArgValue(string[] args, string flag)
        {
            var index = Array.IndexOf(args, flag);
            return index >= 0 && index < args.Length - 1 ? args[index + 1] : null;
        }
    }
}