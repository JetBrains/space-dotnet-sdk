using System;
using System.Text;
using SpaceDotNet.Generator.CodeGeneration.Extensions;
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

        public static string ToCSharpVariableInstanceOrDefaultValue(this ApiField subject, CodeGenerationContext context)
        {
            var variableName = subject.ToCSharpVariableName();
            var defaultValue = subject.ToCSharpDefaultValueForAssignment(context);
            
            if (!string.IsNullOrEmpty(defaultValue))
            {
                return $"({variableName} ?? {defaultValue})";
            }

            return variableName;
        }
        
        public static string? ToCSharpDefaultValueForParameterList(this ApiField subject, CodeGenerationContext context)
        {
            if (subject.DefaultValue != null)
            {
                switch (subject.DefaultValue)
                {
                    case ApiDefaultValue.Const.Primitive primitive:
                        return primitive.Expression;
                    
                    case ApiDefaultValue.Const.EnumEntry enumEntry:
                        if (FeatureFlags.GenerateOptionalParameterDefaultReferenceTypes)
                        {
                            return subject.ToCSharpDefaultValueForAssignment(context);
                        }
                        else if (FeatureFlags.GenerateAlternativeForOptionalParameterDefaultReferenceTypes)
                        {
                            return CSharpExpression.NullLiteral;
                        }
                        else
                        {
                            return null;
                        }

                    case ApiDefaultValue.Collection collection:
                        if (FeatureFlags.GenerateOptionalParameterDefaultReferenceTypes)
                        {
                            return subject.ToCSharpDefaultValueForAssignment(context);
                        }
                        else if (FeatureFlags.GenerateAlternativeForOptionalParameterDefaultReferenceTypes)
                        {
                            return CSharpExpression.NullLiteral;
                        }
                        else
                        {
                            return null;
                        }

                    case ApiDefaultValue.Map map:
                        if (FeatureFlags.GenerateOptionalParameterDefaultReferenceTypes)
                        {
                            return subject.ToCSharpDefaultValueForAssignment(context);
                        }
                        else if (FeatureFlags.GenerateAlternativeForOptionalParameterDefaultReferenceTypes)
                        {
                            return CSharpExpression.NullLiteral;
                        }
                        else
                        {
                            return null;
                        }

                    case ApiDefaultValue.Reference reference:
                        throw new NotSupportedException(nameof(ApiDefaultValue.Reference) + " is not supported yet.");
                }
            } 
            
            if (subject.Type.Nullable)
            {
                return CSharpExpression.NullLiteral;
            }

            return null;
        }
        
        public static string? ToCSharpDefaultValueForAssignment(this ApiField subject, CodeGenerationContext context)
        {
            if (subject.DefaultValue == null) return null;
            
            if (subject.DefaultValue is ApiDefaultValue.Const.EnumEntry enumEntry)
            {
                var apiEnumRef = subject.Type as ApiFieldType.Enum;
                if (apiEnumRef == null || !context.TryGetEnum(apiEnumRef.EnumRef!.Id, out var apiEnum) || apiEnum == null)
                {
                    throw new NotSupportedException("For " + nameof(ApiDefaultValue.Const.EnumEntry) + ", the field type should be of type" + nameof(ApiFieldType.Enum) + ".");
                }

                var typeNameForEnum = apiEnum.ToCSharpClassName();
                var identifierForValue = CSharpIdentifier.ForClassOrNamespace(enumEntry.EntryName);

                return $"{typeNameForEnum}.{identifierForValue}";
            }
            else if (subject.DefaultValue is ApiDefaultValue.Collection collection)
            {
                var typeNameForArrayElement = subject.Type.GetArrayElementTypeOrType().ToCSharpType(context);

                var builder = new StringBuilder();
                builder.Append($"new List<{typeNameForArrayElement}>()");

                if (collection.Elements.Count > 0)
                {
                    throw new NotSupportedException("Default values with populated collections are not supported yet.");
                }
                
                return builder.ToString();
            }
            else if (subject.DefaultValue is ApiDefaultValue.Map map)
            {
                var typeNameForMapValue = subject.Type.GetMapValueTypeOrType().ToCSharpType(context);

                var builder = new StringBuilder();
                builder.Append($"new Dictionary<string, {typeNameForMapValue}>()");

                if (map.Elements.Count > 0)
                {
                    throw new NotSupportedException("Default values with populated maps are not supported yet.");
                }
                
                return builder.ToString();
            }
            else if (subject.DefaultValue is ApiDefaultValue.Reference reference)
            {
                throw new NotSupportedException(nameof(ApiDefaultValue.Reference) + " is not supported yet.");
            }

            return null;
        }
    }
}