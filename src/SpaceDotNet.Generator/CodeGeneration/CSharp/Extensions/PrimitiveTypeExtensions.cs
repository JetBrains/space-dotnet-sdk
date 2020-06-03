using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions
{
    public static class PrimitiveTypeExtensions
    {
        public static string? ToCSharpPrimitiveType(this ApiFieldType.Primitive subject) =>
            subject.Type switch
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