using System.Linq;
using JetBrains.Space.Common.Utilities;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp
{
    public static class CSharpIdentifier
    {
        private static readonly char[] IdentifierSeparators = { ' ', '-', '_', '.', '/' };
        
        private static readonly string[] ReservedKeywords =
        {
            "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const", "continue",
            "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float",
            "for", "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new", "null", "object",
            "operator", "out", "override", "params", "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof",
            "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe",
            "ushort", "using", "virtual", "void", "volatile", "while"
        };

        private static string WithStartingDigitReplaced(this string subject)
        {
            if (string.IsNullOrEmpty(subject)) return subject;
            
            return subject[0] switch
            {
                '0' => $"Zero{subject.Substring(1)}",
                '1' => $"One{subject.Substring(1)}",
                '2' => $"Two{subject.Substring(1)}",
                '3' => $"Three{subject.Substring(1)}",
                '4' => $"Four{subject.Substring(1)}",
                '5' => $"Five{subject.Substring(1)}",
                '6' => $"Six{subject.Substring(1)}",
                '7' => $"Seven{subject.Substring(1)}",
                '8' => $"Eight{subject.Substring(1)}",
                '9' => $"Nine{subject.Substring(1)}",
                _ => subject
            };
        }
        
        public static string ForClassOrNamespace(string subject) =>
            string.Join("", 
                subject
                    .WithStartingDigitReplaced()
                    .Replace(" ", "_")
                    .Replace(":", "_")
                    .Replace("{", "For-")
                    .Replace("}", string.Empty)
                    .Replace("[", string.Empty)
                    .Replace("]", string.Empty)
                    .Replace("?", string.Empty)
                    .Replace("'s", string.Empty)
                    .Split(IdentifierSeparators)
                    .Select(it => it.ToUppercaseFirst()));

        public static string ForVariable(string subject)
        {
            var variableName = subject
                .WithStartingDigitReplaced()
                .Replace("$", string.Empty);
            
            return ReservedKeywords.Contains(variableName) ? "@" + variableName : variableName;
        }

        public static string ForBackingField(string subject) =>
            "_" + subject
                .WithStartingDigitReplaced()
                .Replace("$", string.Empty);
    }
}