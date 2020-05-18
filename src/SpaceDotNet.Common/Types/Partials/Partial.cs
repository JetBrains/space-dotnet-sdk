using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using SpaceDotNet.Common.Types;

// ReSharper disable once CheckNamespace Make discovery easier
namespace SpaceDotNet.Common
{
    public sealed class EagerPartial<T> : Partial<T>
    {
        // ReSharper disable once StaticMemberInGenericType
        private static readonly string CommonTypesNamespace = typeof(Batch<>).Namespace!;
        
        // ReSharper disable once StaticMemberInGenericType
        private static readonly string CommonTypesBatchName = typeof(Batch<>).Name;

        public EagerPartial()
        {
            AddFieldNames(FieldsFor(typeof(T)));
        }
        
        private static List<string> FieldsFor(Type forType, int currentDepth = 0, int maxDepth = 2)
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
                            fieldNameToAdd = fieldNameToAdd + "(" + string.Join(",", FieldsFor(innerType, currentDepth + 1, maxDepth)) + ")";
                        }
                    }

                    if (fieldNameToAdd != null)
                    {
                        fieldNames.Add(fieldNameToAdd);
                    }
                }
            }

            return fieldNames;
        }
        
        private static List<Type> FindAllDerivedTypes(Type forType)
        {
            return forType.Assembly
                .GetTypes()
                .Where(t => t != forType && forType.IsAssignableFrom(t))
                .ToList();
        }
    }

    [PublicAPI]
    public class Partial<T>
    {
        private HashSet<string> _fieldNames = new HashSet<string>();

        public virtual Partial<T> AddFieldName(string fieldName)
        {
            _fieldNames.Add(fieldName);
            return this;
        }

        public virtual Partial<T> AddFieldNames(IEnumerable<string> fieldNames)
        {
            foreach (var fieldName in fieldNames)
            {
                _fieldNames.Add(fieldName);
            }
            return this;
        }
        
        public virtual Partial<T> AddFieldName<TField>(string fieldName, Partial<TField> fieldPartial)
        {
            _fieldNames.Add(fieldName + "(" + fieldPartial + ")");
            return this;
        }

        public override string ToString() => string.Join(",", _fieldNames);
    }
}