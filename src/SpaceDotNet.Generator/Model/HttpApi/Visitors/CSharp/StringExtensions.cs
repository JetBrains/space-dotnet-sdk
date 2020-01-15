using System.Linq;
using SpaceDotNet.Generator.Utilities;

namespace SpaceDotNet.Generator.Model.HttpApi.Visitors.CSharp
{
    public static class StringExtensions
    {
        private static readonly char[] IdentifierSeparators = {' ', '-', '_', '.'};
        
        public static string? ToSafeIdentifier(this string? subject)
        {
            if (string.IsNullOrEmpty(subject)) return subject;

            return string.Join("", 
                    subject
                        .Split(IdentifierSeparators)
                        .Select(it => it.ToUppercaseFirst()));
        }
        
        public static string? ToSafeVariableIdentifier(this string? subject)
        {
            if (string.IsNullOrEmpty(subject)) return subject;

            return subject.Replace("$", string.Empty);
        }

        public static string? ToCSharpPrimitiveType(this string? subject) =>
            (subject ?? "Generic") switch
            {
                "Byte" => "byte",
                "Short" => "short",
                "Int" => "int",
                "Long" => "long",
                "Float" => "float",
                "Double" => "double",
                "Boolean" => "bool",
                "String" => "string",
                "Date" => "SpaceDate",
                "DateTime" => "SpaceTime",
                _ => "object"
            };
    }
}