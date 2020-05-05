using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Common
{
    [PublicAPI]
    public static class ObjectToFieldDescriptor
    {
        private static readonly string CommonTypesNamespace = typeof(Batch<>).Namespace!;
        private static readonly string CommonTypesBatchName = typeof(Batch<>).Name;
        
        public static string FieldsFor(Type forType, int currentDepth = 0, int maxDepth = 2)
        {
            var fieldNames = new List<string>();

            if (forType.IsGenericType && forType.Name == CommonTypesBatchName)
            {
                maxDepth++;
            }
            if (forType.IsGenericType && forType.Namespace != CommonTypesNamespace)
            {
                forType = forType.GetGenericArguments().First();
            }

            foreach (var propertyInfo in forType.GetProperties())
            {
                if (propertyInfo.GetCustomAttribute(typeof(JsonPropertyNameAttribute)) is JsonPropertyNameAttribute jsonPropertyName)
                {
                    var fieldNameToAdd = jsonPropertyName.Name;
                    var innerType = propertyInfo.PropertyType;
                    if (innerType.IsGenericType)
                    {
                        // Follow e.g. generic lists
                        innerType = innerType.GenericTypeArguments[0];
                    }
                    if ((innerType.Namespace == forType.Namespace || forType.Namespace == CommonTypesNamespace) && currentDepth < maxDepth)
                    {
                        var derivedInnerTypes = FindAllDerivedTypes(innerType);
                        if (derivedInnerTypes.Count > 0)
                        {
                            // Follow all derived types of innerType
                            fieldNameToAdd = fieldNameToAdd + "(" + string.Join(",", derivedInnerTypes.Select(it => FieldsFor(it, currentDepth + 1, maxDepth))) + ")";
                        }
                        else
                        {
                            // Follow just innerType
                            fieldNameToAdd = fieldNameToAdd + "(" + FieldsFor(innerType, currentDepth + 1, maxDepth) + ")";
                        }
                    }

                    if (fieldNameToAdd != null)
                    {
                        fieldNames.Add(fieldNameToAdd);
                    }
                }
            }

            return string.Join(",", fieldNames);
        }
        
        private static List<Type> FindAllDerivedTypes(Type forType)
        {
            return forType.Assembly
                .GetTypes()
                .Where(t => t != forType && forType.IsAssignableFrom(t))
                .ToList();

        } 
    }
}