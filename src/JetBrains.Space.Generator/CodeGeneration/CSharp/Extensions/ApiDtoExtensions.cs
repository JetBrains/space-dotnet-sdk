using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions
{
    public static class ApiDtoExtensions
    {
        public static string ToCSharpClassName(this ApiDto subject)
            => CSharpIdentifier.ForClassOrNamespace(subject.Name);

        public static string ToCSharpFactoryMethodName(this ApiDto subject, ApiDto parent)
        {
            var classNameForParent = CSharpIdentifier.ForClassOrNamespace(parent.Name);
            var classNameForSubject = CSharpIdentifier.ForClassOrNamespace(subject.Name);
            var factoryMethodName = classNameForSubject.Replace(classNameForParent, string.Empty);

            return factoryMethodName;
        }
    }
}