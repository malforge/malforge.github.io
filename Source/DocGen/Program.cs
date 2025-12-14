using System;
using System.Linq;
using System.Threading.Tasks;
using DocGen.Commands;

namespace DocGen
{
    internal class Program
    {
        static async Task<int> Main(string[] args)
        {
            if (args.Length == 0)
            {
                PrintHelp();
                return 1;
            }

            // Check if first arg contains comma - if so, it's multiple commands
            var firstArg = args[0].ToLower();
            if (firstArg.Contains(','))
            {
                var commands = firstArg.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(c => c.Trim())
                    .ToArray();
                var remainingArgs = new string[args.Length - 1];
                Array.Copy(args, 1, remainingArgs, 0, args.Length - 1);
                return await ExecuteMultipleCommands(commands, remainingArgs);
            }

            var command = firstArg;

            try
            {
                var remainingArgs = new string[args.Length - 1];
                Array.Copy(args, 1, remainingArgs, 0, args.Length - 1);

                if (command == "api")
                    return await ApiCommand.ExecuteAsync(remainingArgs);
                if (command == "terminals")
                    return await TerminalsCommand.ExecuteAsync(remainingArgs);
                if (command == "sprites")
                    return await SpritesCommand.ExecuteAsync(remainingArgs);
                if (command == "types")
                    return await TypesCommand.ExecuteAsync(remainingArgs);
                if (command == "json")
                    return await JsonCommand.ExecuteAsync(remainingArgs);
                if (command == "help" || command == "--help" || command == "-h")
                    return ShowHelp();
                return ShowUnknownCommand(command);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"✗ Fatal error: {ex.Message}");
                return 1;
            }
        }

        static async Task<int> ExecuteMultipleCommands(string[] commands, string[] remainingArgs)
        {
            var failures = 0;
            var total = commands.Length;

            Console.WriteLine($"Executing {total} command(s)...");
            Console.WriteLine();

            for (var i = 0; i < commands.Length; i++)
            {
                var cmd = commands[i].ToLower();
                Console.WriteLine($"[{i + 1}/{total}] Running '{cmd}' command...");

                try
                {
                    int result;
                    if (cmd == "api")
                        result = await ApiCommand.ExecuteAsync(remainingArgs);
                    else if (cmd == "terminals")
                        result = await TerminalsCommand.ExecuteAsync(remainingArgs);
                    else if (cmd == "sprites")
                        result = await SpritesCommand.ExecuteAsync(remainingArgs);
                    else if (cmd == "types")
                        result = await TypesCommand.ExecuteAsync(remainingArgs);
                    else if (cmd == "json")
                        result = await JsonCommand.ExecuteAsync(remainingArgs);
                    else
                        result = ShowUnknownCommand(cmd);

                    if (result != 0)
                    {
                        failures++;
                        Console.Error.WriteLine($"      ✗ '{cmd}' command failed");
                    }
                    else
                        Console.WriteLine($"      ✓ '{cmd}' command completed");
                }
                catch (Exception ex)
                {
                    failures++;
                    Console.Error.WriteLine($"      ✗ '{cmd}' command failed: {ex.Message}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("═══════════════════════════════════════════════");

            if (failures == 0)
            {
                Console.WriteLine($"✓ All {total} command(s) completed successfully!");
                return 0;
            }

            Console.Error.WriteLine($"✗ Completed with {failures}/{total} failure(s)");
            return 1;
        }

        static int ShowHelp()
        {
            PrintHelp();
            return 0;
        }

        static int ShowUnknownCommand(string cmd)
        {
            Console.Error.WriteLine($"Unknown command: {cmd}");
            Console.Error.WriteLine();
            PrintHelp();
            return 1;
        }

        static void PrintHelp()
        {
            Console.WriteLine("DocGen - Space Engineers Documentation Generator");
            Console.WriteLine();
            Console.WriteLine("Usage: docgen <command> [options]");
            Console.WriteLine("   or: docgen <command1>,<command2>,... [options]");
            Console.WriteLine();
            Console.WriteLine("Commands:");
            Console.WriteLine("  api        Generate API documentation from whitelist");
            Console.WriteLine("  terminals  Generate terminal properties/actions listing");
            Console.WriteLine("  sprites    Generate sprite/icon documentation");
            Console.WriteLine("  types      Generate type definition listing");
            Console.WriteLine("  json       Generate JSON API data from whitelist");
            Console.WriteLine();
            Console.WriteLine("Global Options:");
            Console.WriteLine("  --output     Output directory or file (command-specific defaults)");
            Console.WriteLine();
            Console.WriteLine("Examples:");
            Console.WriteLine("  docgen api --output ./docs");
            Console.WriteLine("  docgen api,terminals,sprites --output ./docs");
            Console.WriteLine("  docgen api,sprites,types --output ./docs");
            Console.WriteLine();
            Console.WriteLine("Run 'docgen <command> --help' for command-specific options");
            Console.WriteLine();
            Console.WriteLine("Note: Data files will be auto-detected from executable directory:");
            Console.WriteLine("      --whitelist uses pbwhitelist.dat (api command)");
            Console.WriteLine("      --terminal uses terminal.dat (terminals command)");
        }
    }
}