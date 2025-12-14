using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace DocGen.Services
{
    /// <summary>
    ///     Framework initialization and configuration
    /// </summary>
    public class MDKUtilityFramework
    {
        static readonly Dictionary<string, AssemblyName> AssemblyNames = new Dictionary<string, AssemblyName>();
        static readonly Dictionary<string, Assembly> LoadedAssemblies = new Dictionary<string, Assembly>();
        static readonly HashSet<string> FailedAssemblies = new HashSet<string>();

        /// <summary>
        ///     Gets the game binary path as defined through <see cref="Load" />.
        /// </summary>
        public static string GameBinPath { get; internal set; }

        /// <summary>
        ///     Initializes the mock system. Pass in the path to the Space Engineers Bin64 folder.
        /// </summary>
        /// <param name="mdkOptionsPath">The path to the MDK options file</param>
        public static void Load(string gameBinPath)
        {
            var directory = new DirectoryInfo(gameBinPath);

            foreach (var dllFileName in directory.EnumerateFiles("*.dll"))
            {
                AssemblyName assemblyName;
                try
                {
                    assemblyName = AssemblyName.GetAssemblyName(dllFileName.FullName);
                }
                catch (BadImageFormatException)
                {
                    // Not a .NET assembly or wrong platform, ignore
                    continue;
                }

                AssemblyNames[assemblyName.FullName] = assemblyName;
                //AssemblyNames[dllFileName.FullName.Replace("\\", "\\\\")] = assemblyName;
            }

            AppDomain.CurrentDomain.AssemblyResolve += OnResolveAssembly;

            GameBinPath = directory.FullName;
        }

        static Assembly OnResolveAssembly(object sender, ResolveEventArgs args)
        {
            // Check if already loaded
            if (LoadedAssemblies.TryGetValue(args.Name, out var loadedAssembly))
                return loadedAssembly;

            // Check if previously failed to prevent infinite loops
            if (FailedAssemblies.Contains(args.Name))
                return null;

            if (AssemblyNames.TryGetValue(args.Name, out var assemblyName))
            {
                // Mark as in-progress BEFORE attempting load to prevent re-entry
                FailedAssemblies.Add(args.Name);

                try
                {
                    var assembly = Assembly.Load(assemblyName);
                    // Success - remove from failed set and add to loaded
                    FailedAssemblies.Remove(args.Name);
                    LoadedAssemblies[args.Name] = assembly;
                    return assembly;
                }
                catch
                {
                    // Already in FailedAssemblies, just return null
                    return null;
                }
            }

            // Not in our list - try to let the runtime resolve it (for system assemblies)
            FailedAssemblies.Add(args.Name);
            try
            {
                var assembly = Assembly.Load(new AssemblyName(args.Name));
                FailedAssemblies.Remove(args.Name);
                LoadedAssemblies[args.Name] = assembly;
                return assembly;
            }
            catch
            {
                // Really can't find it
                return null;
            }
        }
    }
}