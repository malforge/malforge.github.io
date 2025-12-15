using System;
using System.IO;

namespace DocGen.Services
{
    /// <summary>
    /// Helper methods for file and path operations.
    /// </summary>
    internal static class FileHelpers
    {
        /// <summary>
        /// Finds a default file by searching in the current working directory first,
        /// then falling back to the executable directory.
        /// </summary>
        /// <param name="fileName">The file name to search for</param>
        /// <returns>The full path to the file (may not exist)</returns>
        public static string FindDefaultFile(string fileName)
        {
            // First check current working directory
            var currentDirPath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            if (File.Exists(currentDirPath))
                return currentDirPath;

            // Fall back to executable directory
            return Path.Combine(AppContext.BaseDirectory, fileName);
        }

        /// <summary>
        /// Ensures that the directory for the specified file path exists.
        /// Creates the directory if it doesn't exist.
        /// </summary>
        /// <param name="filePath">The full path to a file</param>
        public static void EnsureDirectoryExists(string filePath)
        {
            var directory = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }
    }
}
