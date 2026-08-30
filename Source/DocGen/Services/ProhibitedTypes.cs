using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DocGen.Services
{
    /// <summary>
    ///     A type a script can obtain but cannot name, together with the types it may be held as.
    ///     IMyEntity.Components is the motivating case: it returns IMyEntityComponentContainer, which the
    ///     whitelist does not permit, but its base interface IMyComponentContainer is permitted, so the
    ///     value is perfectly usable once assigned to that. Documenting the return type as merely
    ///     "prohibited" tells the reader the property is useless, which is wrong.
    /// </summary>
    internal class ProhibitedType
    {
        public ProhibitedType(ApiEntry entry, IReadOnlyList<ApiEntry> accessibleAs)
        {
            Entry = entry;
            AccessibleAs = accessibleAs;
            SuggestedFileName = entry.SuggestedFileName;
        }

        /// <summary>The blacklisted entry, so names and signatures are derived exactly as elsewhere.</summary>
        public ApiEntry Entry { get; }

        /// <summary>
        ///     The nearest documented ancestors, most derived first. Never empty: a prohibited type with no
        ///     documented ancestor is a dead end, and there is nothing useful to say about it beyond the
        ///     "prohibited" marker its type reference already carries.
        /// </summary>
        public IReadOnlyList<ApiEntry> AccessibleAs { get; }

        /// <summary>The page this type gets, named exactly as a documented type page would be.</summary>
        public string SuggestedFileName { get; set; }
    }

    internal static class ProhibitedTypeFinder
    {
        /// <summary>
        ///     Finds every type a script can get hold of through the documented API but may not name, and
        ///     that has a documented ancestor to use in its place.
        /// </summary>
        public static List<ProhibitedType> Find(ProgrammableBlockApi api)
        {
            // "Documented" rather than "whitelisted". System.ValueType and System.Enum pass a whitelist
            // check but have no page and are useless as advice - nobody needs telling that a struct is a
            // ValueType. Only types the reader can navigate to belong in AccessibleAs.
            var documented = new HashSet<Type>(api.Entries.Where(e => e.IsWhitelisted && e.Member is Type)
                .Select(e => (Type)e.Member));

            var obtainable = new HashSet<Type>();
            foreach (var entry in api.Entries)
            {
                if (!entry.IsWhitelisted)
                    continue;

                switch (entry.Member)
                {
                    case MethodInfo method:
                        Consider(obtainable, method.ReturnType);
                        ConsiderOutputParameters(obtainable, method.GetParameters());
                        break;
                    case PropertyInfo property:
                        Consider(obtainable, property.PropertyType);
                        break;
                    case FieldInfo field:
                        Consider(obtainable, field.FieldType);
                        break;
                    case ConstructorInfo constructor:
                        ConsiderOutputParameters(obtainable, constructor.GetParameters());
                        break;
                }
            }

            var results = new List<ProhibitedType>();
            foreach (var type in obtainable)
            {
                if (documented.Contains(type) || !IsGameType(type))
                    continue;

                var permitted = AncestorsOf(type).Where(documented.Contains).ToList();
                if (permitted.Count == 0)
                    continue;

                // Reduce to the most derived options. Listing MyCharacter as usable via MyEntity when it is
                // also usable via IMyCharacter is noise; only the nearest choices help.
                var redundant = new HashSet<Type>(permitted.SelectMany(AncestorsOf).Where(permitted.Contains));
                var nearest = permitted.Where(t => !redundant.Contains(t)).ToList();
                if (nearest.Count == 0)
                    continue;

                var entry = api.GetEntry(type, true);
                if (entry == null)
                    continue;

                var accessible = nearest.Select(t => api.GetEntry(t)).Where(e => e != null).ToList();
                if (accessible.Count == 0)
                    continue;

                results.Add(new ProhibitedType(entry, accessible));
            }

            results = results.OrderBy(r => r.Entry.FullName, StringComparer.Ordinal).ToList();

            // The page name is derived the same lossy way a documented type name is, so it can land on a
            // name already in use. Give way rather than overwrite another page.
            var taken = new HashSet<string>(api.Entries.Select(e => e.SuggestedFileName), StringComparer.OrdinalIgnoreCase);
            foreach (var result in results)
            {
                if (!taken.Add(result.SuggestedFileName))
                    result.SuggestedFileName = Path.GetFileNameWithoutExtension(result.SuggestedFileName) + "-prohibited.md";
            }

            return results;
        }

        static void ConsiderOutputParameters(HashSet<Type> obtainable, ParameterInfo[] parameters)
        {
            // Only out and ref parameters hand a value back. A plain input parameter cannot be how a script
            // first obtains one, so pointing at a base type there would help nobody.
            foreach (var parameter in parameters)
            {
                if (parameter.ParameterType.IsByRef || parameter.IsOut)
                    Consider(obtainable, parameter.ParameterType);
            }
        }

        static void Consider(HashSet<Type> obtainable, Type type)
        {
            var resolved = Unwrap(type);
            if (resolved != null && resolved != typeof(void))
                obtainable.Add(resolved);
        }

        /// <summary>
        ///     Reduces a type as it appears in a signature to the type actually being documented: byref,
        ///     pointer and array wrappers fall away, and a constructed generic reduces to its definition.
        ///     Skipping this is what makes a naive implementation report an array of Vector3, or a
        ///     ListReader of MyDefinitionId, as prohibited when both are perfectly well documented.
        /// </summary>
        static Type Unwrap(Type type)
        {
            while (type != null && (type.IsByRef || type.IsPointer || type.IsArray))
                type = type.GetElementType();

            if (type == null || type.IsGenericParameter)
                return null;

            if (type.IsGenericType && !type.IsGenericTypeDefinition)
                type = type.GetGenericTypeDefinition();

            return type;
        }

        /// <summary>
        ///     Framework types are out of scope. They are documented on learn.microsoft.com, the reader is
        ///     linked there already, and "you may use it as System.ValueType" is not advice.
        /// </summary>
        static bool IsGameType(Type type)
        {
            var ns = type.Namespace;
            if (string.IsNullOrEmpty(ns))
                return false;
            return !ns.StartsWith("System", StringComparison.Ordinal) && !ns.StartsWith("Microsoft", StringComparison.Ordinal);
        }

        static IEnumerable<Type> AncestorsOf(Type type)
        {
            for (var baseType = type.BaseType; baseType != null && baseType != typeof(object); baseType = baseType.BaseType)
                yield return Normalise(baseType);

            Type[] interfaces;
            try
            {
                interfaces = type.GetInterfaces();
            }
            catch
            {
                yield break;
            }

            foreach (var item in interfaces)
                yield return Normalise(item);
        }

        static Type Normalise(Type type) => type.IsGenericType && !type.IsGenericTypeDefinition ? type.GetGenericTypeDefinition() : type;
    }
}
