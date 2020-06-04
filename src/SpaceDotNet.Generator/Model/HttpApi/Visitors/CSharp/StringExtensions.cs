using System.Linq;
using SpaceDotNet.Generator.Utilities;

namespace SpaceDotNet.Generator.Model.HttpApi.Visitors.CSharp
{
    // TODO Refactoring
    public static class StringExtensions
    {
        private static readonly char[] IdentifierSeparators = {' ', '-', '_', '.'};

        private static string? WithStartingDigitReplaced(this string? subject)
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
        
        public static string? ToSafeIdentifier(this string? subject)
        {
            if (string.IsNullOrEmpty(subject)) return subject;

            return string.Join("", 
                    subject.WithStartingDigitReplaced()!
                        .Split(IdentifierSeparators)
                        .Select(it => it.ToUppercaseFirst()));
        }
        
        public static string? ToSafeVariableIdentifier(this string? subject)
        {
            if (string.IsNullOrEmpty(subject)) return subject;

            return subject.WithStartingDigitReplaced()!.Replace("$", string.Empty);
        }
    }
}