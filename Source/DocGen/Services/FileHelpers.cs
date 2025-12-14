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
    }
}
