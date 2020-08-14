using System.Linq;
using SpaceDotNet.Common.Utilities;

namespace SpaceDotNet.Common.Json.Serialization.Internal
{
    internal static class CSharpIdentifier
    {
        private static readonly char[] IdentifierSeparators = { ' ', '-', '_', '.', '/' };
        
        public static string ForClassOrNamespace(string subject) =>
            string.Join("", 
                subject
                    .Replace("{", "For-")
                    .Replace("}", string.Empty)
                    .Replace("'s", string.Empty)
                    .Split(IdentifierSeparators)
                    .Select(it => StringExtensions.ToUppercaseFirst(it)));
    }
}