using System;
using System.Collections.Generic;
using System.IO;

namespace DocGen.Services
{
    /// <summary>
    /// Configuration for suppressing member documentation on specific types.
    /// </summary>
    internal class TypeOverridesConfig
    {
        readonly Dictionary<string, string> _overrides = new Dictionary<string, string>(StringComparer.Ordinal);

        /// <summary>
        /// Loads type overrides from a config file.
        /// Format:
        /// [Fully.Qualified.TypeName]
        /// Custom message to display instead of member tables.
        /// Can span multiple lines until the next [TypeName].
        /// </summary>
        public static TypeOverridesConfig Load(string filePath)
        {
            var config = new TypeOverridesConfig();

            if (!File.Exists(filePath))
                return config; // Return empty config if file doesn't exist

            string currentType = null;
            var currentMessage = new List<string>();

            foreach (var line in File.ReadAllLines(filePath))
            {
                var trimmed = line.Trim();

                // Skip empty lines and comments
                if (string.IsNullOrWhiteSpace(trimmed) || trimmed.StartsWith("#") || trimmed.StartsWith("//"))
                    continue;

                // Check for type declaration: [TypeName]
                if (trimmed.StartsWith("[") && trimmed.EndsWith("]"))
                {
                    // Save previous type if any
                    if (currentType != null && currentMessage.Count > 0)
                    {
                        config._overrides[currentType] = string.Join(Environment.NewLine, currentMessage).Trim();
                        currentMessage.Clear();
                    }

                    // Start new type
                    currentType = trimmed.Substring(1, trimmed.Length - 2).Trim();
                }
                else if (currentType != null)
                {
                    // Collect message lines for current type
                    currentMessage.Add(line); // Keep original formatting/indentation
                }
            }

            // Save last type
            if (currentType != null && currentMessage.Count > 0)
            {
                config._overrides[currentType] = string.Join(Environment.NewLine, currentMessage).Trim();
            }

            return config;
        }

        /// <summary>
        /// Tries to get a custom message for the specified type.
        /// </summary>
        /// <param name="fullTypeName">Fully qualified type name</param>
        /// <param name="message">The custom message to display</param>
        /// <returns>True if an override exists for this type</returns>
        public bool TryGetOverride(string fullTypeName, out string message)
        {
            return _overrides.TryGetValue(fullTypeName, out message);
        }

        /// <summary>
        /// Gets the number of configured overrides.
        /// </summary>
        public int Count => _overrides.Count;
    }
}
