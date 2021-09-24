using System;
using System.Linq;
using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions
{
    public static class ApiUrlParameterExtensions
    {
        public static string ToCSharpClassName(this ApiUrlParameter subject)
            => CSharpIdentifier.ForClassOrNamespace(subject.Name);
    }
    
    public static class ApiUrlParameterOptionExtensions
    {
        public static string ToCSharpClassName(this ApiUrlParameterOption subject)
            => CSharpIdentifier.ForClassOrNamespace(subject.OptionName);
        
        public static string ToCSharpFactoryMethodName(this ApiUrlParameterOption subject, string typeNameForUrlParameterOption, ApiUrlParameter parent)
        {
            var classNameForParent = CSharpIdentifier.ForClassOrNamespace(parent.Name
                .Split('.', StringSplitOptions.RemoveEmptyEntries).Last());
            var classNameForSubject = CSharpIdentifier.ForClassOrNamespace(subject.OptionName
                .Split('.', StringSplitOptions.RemoveEmptyEntries).Last());
            
            var factoryMethodName = CSharpIdentifier.ForClassOrNamespace(
                classNameForSubject.Replace(classNameForParent, string.Empty));

            if (factoryMethodName == typeNameForUrlParameterOption)
            {
                factoryMethodName = factoryMethodName.Replace("Identifier", string.Empty);
            }
            if (factoryMethodName == typeNameForUrlParameterOption)
            {
                factoryMethodName = $"For{factoryMethodName}";
            }
            
            return factoryMethodName;
        }
    }
}