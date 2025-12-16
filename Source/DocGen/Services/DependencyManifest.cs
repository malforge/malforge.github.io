using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace DocGen.Services
{
    /// <summary>
    /// Tracks dependencies to determine if regeneration is needed
    /// </summary>
    internal class DependencyManifest
    {
        public DateTime Generated { get; set; }
        public string WhitelistHash { get; set; }
        public string TerminalHash { get; set; }
        public Dictionary<string, string> GameBinaryHashes { get; set; } = new Dictionary<string, string>();
        
        /// <summary>
        /// Checks if regeneration is needed by comparing current state against manifest
        /// </summary>
        public static bool NeedsRegeneration(string outputPath, string whitelistPath, string terminalPath, string gameBinPath)
        {
            var manifestPath = Path.Combine(outputPath, ".docgen-manifest.json");
            
            // If manifest doesn't exist, we need to regenerate
            if (!File.Exists(manifestPath))
            {
                Console.WriteLine("No previous manifest found - full regeneration needed");
                return true;
            }
            
            // Load previous manifest
            DependencyManifest previousManifest;
            try
            {
                var json = File.ReadAllText(manifestPath);
                previousManifest = JsonSerializer.Deserialize<DependencyManifest>(json);
                if (previousManifest == null)
                {
                    Console.WriteLine("Invalid manifest - full regeneration needed");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to read manifest: {ex.Message} - full regeneration needed");
                return true;
            }
            
            // Build current manifest
            var currentManifest = BuildManifest(whitelistPath, terminalPath, gameBinPath);
            
            // Compare whitelist
            if (currentManifest.WhitelistHash != previousManifest.WhitelistHash)
            {
                Console.WriteLine("Whitelist changed - regeneration needed");
                return true;
            }
            
            // Compare terminal
            if (currentManifest.TerminalHash != previousManifest.TerminalHash)
            {
                Console.WriteLine("Terminal cache changed - regeneration needed");
                return true;
            }
            
            // Compare game binaries (key DLLs only for performance)
            var keyDlls = new[] 
            { 
                "Sandbox.Common.dll", 
                "Sandbox.Game.dll", 
                "VRage.dll", 
                "VRage.Game.dll",
                "VRage.Math.dll",
                "VRage.Scripting.dll"
            };
            
            foreach (var dll in keyDlls)
            {
                if (!currentManifest.GameBinaryHashes.ContainsKey(dll))
                    continue;
                    
                if (!previousManifest.GameBinaryHashes.ContainsKey(dll))
                {
                    Console.WriteLine($"New game binary detected: {dll} - regeneration needed");
                    return true;
                }
                
                if (currentManifest.GameBinaryHashes[dll] != previousManifest.GameBinaryHashes[dll])
                {
                    Console.WriteLine($"Game binary changed: {dll} - regeneration needed");
                    return true;
                }
            }
            
            Console.WriteLine("No changes detected - skipping regeneration");
            Console.WriteLine($"  Previous generation: {previousManifest.Generated:yyyy-MM-dd HH:mm:ss} UTC");
            return false;
        }
        
        /// <summary>
        /// Builds a manifest of current dependencies
        /// </summary>
        public static DependencyManifest BuildManifest(string whitelistPath, string terminalPath, string gameBinPath)
        {
            var manifest = new DependencyManifest
            {
                Generated = DateTime.UtcNow,
                WhitelistHash = ComputeFileHash(whitelistPath),
                TerminalHash = ComputeFileHash(terminalPath)
            };
            
            // Hash key game binaries
            var keyDlls = new[] 
            { 
                "Sandbox.Common.dll", 
                "Sandbox.Game.dll", 
                "VRage.dll", 
                "VRage.Game.dll",
                "VRage.Math.dll",
                "VRage.Scripting.dll"
            };
            
            foreach (var dll in keyDlls)
            {
                var dllPath = Path.Combine(gameBinPath, dll);
                if (File.Exists(dllPath))
                {
                    manifest.GameBinaryHashes[dll] = ComputeFileHash(dllPath);
                }
            }
            
            return manifest;
        }
        
        /// <summary>
        /// Saves the manifest to the output directory
        /// </summary>
        public static void SaveManifest(DependencyManifest manifest, string outputPath)
        {
            var manifestPath = Path.Combine(outputPath, ".docgen-manifest.json");
            var json = JsonSerializer.Serialize(manifest, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            
            File.WriteAllText(manifestPath, json);
            Console.WriteLine($"Saved dependency manifest to {manifestPath}");
        }
        
        private static string ComputeFileHash(string filePath)
        {
            if (!File.Exists(filePath))
                return string.Empty;
            
            using (var sha = SHA256.Create())
            using (var stream = File.OpenRead(filePath))
            {
                var hash = sha.ComputeHash(stream);
                var sb = new StringBuilder();
                foreach (var b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
