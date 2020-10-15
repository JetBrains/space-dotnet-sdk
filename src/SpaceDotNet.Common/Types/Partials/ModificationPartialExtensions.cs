using System;
using JetBrains.Annotations;
using SpaceDotNet.Common.Types;

// ReSharper disable once CheckNamespace Make discovery easier
namespace SpaceDotNet.Common
{
    /// <summary>
    /// Extensions methods for <see cref="Partial{T}"/> of <see cref="Modification{T}"/>.
    /// </summary>
    [PublicAPI]
    public static class ModificationPartialExtensions
    {
        /// <summary>
        /// Add field name of the Old property in the <see cref="Batch{T}"/>.
        /// </summary>
        /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Modification{T}"/>.</param>
        /// <typeparam name="T">The type of the element in <see cref="Modification{T}"/>.</typeparam>
        /// <returns>The <see cref="Partial{T}"/> of <see cref="Modification{T}"/>, with an added field name.</returns>
        public static Partial<Modification<T>> WithOld<T>(this Partial<Modification<T>> it)
            => it.AddFieldName("old");
        
        /// <summary>
        /// Add field name of the Old property in the <see cref="Batch{T}"/>.
        /// </summary>
        /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Modification{T}"/>.</param>
        /// <param name="partialBuilder">A child <see cref="Partial{T}"/> of <typeparamref name="T"/>.</param>
        /// <typeparam name="T">The type of the element in <see cref="Modification{T}"/>.</typeparam>
        /// <returns>The <see cref="Partial{T}"/> of <see cref="Modification{T}"/>, with an added field name.</returns>
        public static Partial<Modification<T>> WithOld<T>(this Partial<Modification<T>> it, Func<Partial<T>, Partial<T>> partialBuilder) 
            => it.AddFieldName("old", partialBuilder(new Partial<T>()));
        
        /// <summary>
        /// Add field name of the New property in the <see cref="Batch{T}"/>.
        /// </summary>
        /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Modification{T}"/>.</param>
        /// <typeparam name="T">The type of the element in <see cref="Modification{T}"/>.</typeparam>
        /// <returns>The <see cref="Partial{T}"/> of <see cref="Modification{T}"/>, with an added field name.</returns>
        public static Partial<Modification<T>> WithNew<T>(this Partial<Modification<T>> it) 
            => it.AddFieldName("new");
        
        /// <summary>
        /// Add field name of the New property in the <see cref="Batch{T}"/>.
        /// </summary>
        /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Modification{T}"/>.</param>
        /// <param name="partialBuilder">A child <see cref="Partial{T}"/> of <typeparamref name="T"/>.</param>
        /// <typeparam name="T">The type of the element in <see cref="Modification{T}"/>.</typeparam>
        /// <returns>The <see cref="Partial{T}"/> of <see cref="Modification{T}"/>, with an added field name.</returns>
        public static Partial<Modification<T>> WithNew<T>(this Partial<Modification<T>> it, Func<Partial<T>, Partial<T>> partialBuilder) 
            => it.AddFieldName("new", partialBuilder(new Partial<T>()));
    }
}