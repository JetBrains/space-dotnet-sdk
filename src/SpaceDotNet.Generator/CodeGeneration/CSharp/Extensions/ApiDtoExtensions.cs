using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions
{
    public static class ApiDtoExtensions
    {
        public static string ToCSharpClassName(this ApiDto subject)
        {
            var classNameForDto = CSharpIdentifier.ForClassOrNamespace(subject.Name);
            if (classNameForDto.EndsWith("Request"))
            {
                return classNameForDto;
            }
            return $"{classNameForDto}Dto";
        }
    }
}