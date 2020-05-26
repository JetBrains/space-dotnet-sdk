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
    /// <summary>
    /// Defines the fields to fetch from the Space API.
    /// Extension methods are generated to provide a strong-typed, fluent API on top.
    /// </summary>
    /// <typeparam name="T">The type to select properties from.</typeparam>
    [PublicAPI]
    public sealed class Partial<T>
    {
        // ReSharper disable once StaticMemberInGenericType
        private static readonly string CommonTypesNamespace = typeof(Batch<>).Namespace!;
        
        // ReSharper disable once StaticMemberInGenericType
        private static readonly string CommonTypesBatchName = typeof(Batch<>).Name;
        
        private HashSet<string> _fieldNames = new HashSet<string>();

        public Partial()
        {
            if (typeof(IClassNameConvertible).IsAssignableFrom(typeof(T)))
            {
                // Support className-based inheritance
                _fieldNames.Add("className");
            }
        }

        /// <summary>
        /// Add a field name to fetch from the Space API.
        /// </summary>
        /// <remarks>This method does not check whether <typeparamref name="T"/> contains <paramref name="fieldName"/>.</remarks>
        /// <param name="fieldName">Field name to fetch.</param>
        /// <returns>The current <see cref="Partial{T}"/>.</returns>
        public Partial<T> AddFieldName(string fieldName)
        {
            _fieldNames.Add(fieldName);
            return this;
        }

        /// <summary>
        /// Add multiple field names to fetch from the Space API.
        /// </summary>
        /// <remarks>This method does not check whether <typeparamref name="T"/> contains <paramref name="fieldNames"/>.</remarks>
        /// <param name="fieldNames">Field names to fetch.</param>
        /// <returns>The current <see cref="Partial{T}"/>.</returns>
        public Partial<T> AddFieldNames(IEnumerable<string> fieldNames)
        {
            foreach (var fieldName in fieldNames)
            {
                _fieldNames.Add(fieldName);
            }
            return this;
        }

        /// <summary>
        /// Add a field name to fetch from the Space API, with a partial definition for that field.
        /// </summary>
        /// <remarks>This method does not check whether <typeparamref name="T"/> contains <paramref name="fieldName"/>.</remarks>
        /// <param name="fieldName">Field name to fetch. Will not be added if it already was added to the list of fields to fetch.</param>
        /// <param name="fieldPartial">The partial expression that defines sub-fields to fetch.</param>
        /// <returns>The current <see cref="Partial{T}"/>.</returns>
        public Partial<T> AddFieldName<TField>(string fieldName, Partial<TField> fieldPartial)
        {
            _fieldNames.Remove(fieldName);
            _fieldNames.Add(fieldName + "(" + fieldPartial + ")");
            return this;
        }
        
        /// <summary>
        /// Add all field names of <typeparamref name="T"/> to the current partial definition.
        /// </summary>
        /// <remarks>When combining <see cref="AddAllFieldNames"/> with methods such as <see cref="AddFieldName"/>, make sure to use <see cref="AddAllFieldNames"/> first in the partial definition.</remarks>
        /// <returns>The current <see cref="Partial{T}"/>.</returns>
        public Partial<T> AddAllFieldNames()
        {
            AddFieldNames(FieldsFor(typeof(T), currentDepth: 0, maxDepth: 0));
            return this;
        }

        /// <summary>
        /// Add partial for an inheritor.
        /// </summary>
        /// <param name="inheritorPartialBuilder">A <see cref="Partial{TInheritor}"/> that can specify the fields to fetch for <typeparamref name="TInheritor"/>.</param>
        /// <typeparam name="TInheritor">Type of the inheritor.</typeparam>
        /// <remarks>This method does not check whether <typeparamref name="TInheritor"/> is an inheritor of <typeparamref name="T"/>.</remarks>
        /// <returns>The current partial.</returns>
        public Partial<T> WithInherited<TInheritor>(Func<Partial<TInheritor>, Partial<TInheritor>> inheritorPartialBuilder)
            where TInheritor : IClassNameConvertible
        {
            var inheritorPartial = inheritorPartialBuilder(new Partial<TInheritor>());
            AddFieldNames(inheritorPartial._fieldNames);
            return this;
        }
        
        /// <summary>
        /// Creates a string that can be use in the Space API <code>$fields</code> query parameter.
        /// </summary>
        /// <returns>A string that can be use in the Space API <code>$fields</code> query parameter.</returns>
        public override string ToString() => string.Join(",", _fieldNames);
        
        /// <summary>
        /// Creates a recursive partial definition, fetching all fields and sub-fields recursively.
        /// </summary>
        /// <returns></returns>
        public static Partial<T> Recursive()
        {
            var partial = new Partial<T>();
            partial.AddFieldNames(FieldsFor(typeof(T)));
            return partial;
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
                            var innerFieldsToAdd = string.Join(",", derivedInnerTypes.SelectMany(it => FieldsFor(it, currentDepth + 1, maxDepth)));
                            if (!string.IsNullOrEmpty(innerFieldsToAdd))
                            {
                                fieldNameToAdd = $"{fieldNameToAdd}({innerFieldsToAdd})";
                            }
                        }
                        else
                        {
                            // Follow just innerType
                            var innerFieldsToAdd = string.Join(",", FieldsFor(innerType, currentDepth + 1, maxDepth));
                            if (!string.IsNullOrEmpty(innerFieldsToAdd))
                            {
                                fieldNameToAdd = $"{fieldNameToAdd}({innerFieldsToAdd})";
                            }
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
}