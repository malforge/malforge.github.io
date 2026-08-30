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
        /// Rewrites a path so Windows accepts it even when it exceeds MAX_PATH (260 characters).
        /// The \\?\ prefix bypasses the Win32 path parser, which is the only way to get long paths without
        /// the machine-wide LongPathsEnabled registry setting - a setting that is off by default. Without
        /// this, an over-long page is silently never written, so which pages exist depends on how deep the
        /// repository happens to be checked out. Left untouched on Linux and macOS, which have no limit.
        /// </summary>
        /// <param name="path">The path to rewrite</param>
        /// <returns>A path safe to hand to the file APIs on any platform</returns>
        public static string ToLongPathSafe(string path)
        {
            if (string.IsNullOrEmpty(path))
                return path;

            // Only Windows needs this, and only for paths that are not prefixed already.
            if (Path.DirectorySeparatorChar != '\\' || path.StartsWith(@"\\?\", StringComparison.Ordinal))
                return path;

            // The prefix requires a fully qualified, already normalised path.
            var fullPath = Path.GetFullPath(path);

            // UNC paths take a different prefix: \\server\share becomes \\?\UNC\server\share.
            if (fullPath.StartsWith(@"\\", StringComparison.Ordinal))
                return @"\\?\UNC\" + fullPath.Substring(2);

            return @"\\?\" + fullPath;
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
