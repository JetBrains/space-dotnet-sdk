using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace SpaceDotNet.Client
{
    public static class ObjectToFieldDescriptor
    {
        public static string FieldsFor(Type forType, int currentDepth = 0, int maxDepth = 2)
        {
            var fieldNames = new List<string>();

            foreach (var propertyInfo in forType.GetProperties())
            {
                if (propertyInfo.GetCustomAttribute(typeof(JsonPropertyAttribute)) is JsonPropertyAttribute jsonNameProperty)
                {
                    var fieldNameToAdd = jsonNameProperty.PropertyName;
                    var innerType = propertyInfo.PropertyType;
                    if (innerType.IsGenericType)
                    {
                        // Follow e.g. generic lists
                        innerType = innerType.GenericTypeArguments[0];
                    }
                    if (innerType.Namespace == forType.Namespace && currentDepth < maxDepth)
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