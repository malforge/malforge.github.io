using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DocGen.Services;
using DocGen.Steam;

namespace DocGen.Commands
{
    public static class SpritesCommand
    {
        public static async Task<int> ExecuteAsync(string[] args)
        {
            if (args.Contains("--help") || args.Contains("-h"))
            {
                ShowHelp();
                return 0;
            }

            var outputPath = GetArgValue(args, "--output") ?? "Sprite-Listing.md";
            var sePath = GetArgValue(args, "--se-path");

            // If output is a directory (no .md extension), use default filename
            if (!outputPath.EndsWith(".md", StringComparison.OrdinalIgnoreCase)) outputPath = Path.Combine(outputPath, "Sprite-Listing.md");

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

            Console.WriteLine("Generating sprite documentation...");
            Console.WriteLine($"  Output: {outputPath}");

            try
            {
                await Sprites.UpdateAsync(dataPath, outputPath, binPath);
                Console.WriteLine("✓ Sprite documentation generated successfully");
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
            Console.WriteLine("Generate sprite/icon documentation");
            Console.WriteLine();
            Console.WriteLine("Usage: docgen sprites [--output <file>] [--se-path <directory>]");
            Console.WriteLine();
            Console.WriteLine("Options:");
            Console.WriteLine("  --output     Output file or directory (default: Sprite-Listing.md)");
            Console.WriteLine("               If directory specified, uses default filename within it");
            Console.WriteLine("  --se-path    Space Engineers installation path (auto-detected if not specified)");
        }

        static string GetArgValue(string[] args, string flag)
        {
            var index = Array.IndexOf(args, flag);
            return index >= 0 && index < args.Length - 1 ? args[index + 1] : null;
        }
    }
}