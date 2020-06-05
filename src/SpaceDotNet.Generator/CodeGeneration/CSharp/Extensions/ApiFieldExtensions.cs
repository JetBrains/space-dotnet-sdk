using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions
{
    public static class ApiFieldExtensions
    {
        public static string ToCSharpVariableName(this ApiField subject)
            => CSharpIdentifier.ForVariable(subject.Name);
        
        public static string ToCSharpBackingFieldName(this ApiField subject)
            => CSharpIdentifier.ForBackingField(subject.Name);
        
        public static string ToCSharpPropertyName(this ApiField subject)
            => CSharpIdentifier.ForClassOrNamespace(subject.Name);
    }
}