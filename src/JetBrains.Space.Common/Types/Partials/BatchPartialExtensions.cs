using System;
using JetBrains.Annotations;
using JetBrains.Space.Common.Types;

// ReSharper disable once CheckNamespace Make discovery easier
namespace JetBrains.Space.Common;

/// <summary>
/// Extensions methods for <see cref="Partial{T}"/> of <see cref="Batch{T}"/>.
/// </summary>
[PublicAPI]
public static class BatchPartialExtensions
{
    /// <summary>
    /// Add field name of the Data property in the <see cref="Batch{T}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Batch{T}"/>.</param>
    /// <typeparam name="T">The type of the items in <see cref="Batch{T}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="Batch{T}"/>, with an added field name.</returns>
    public static Partial<Batch<T>> WithData<T>(this Partial<Batch<T>> it) 
        => it.AddFieldName("data");
        
    /// <summary>
    /// Add field name of the Data property in the <see cref="Batch{T}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Batch{T}"/>.</param>
    /// <param name="partialBuilder">A child <see cref="Partial{T}"/> of <typeparamref name="T"/>.</param>
    /// <typeparam name="T">The type of the items in <see cref="Batch{T}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="Batch{T}"/>, with an added field name.</returns>
    public static Partial<Batch<T>> WithData<T>(this Partial<Batch<T>> it, Func<Partial<T>, Partial<T>> partialBuilder) 
        => it.AddFieldName("data", partialBuilder(new Partial<T>()));
        
    /// <summary>
    /// Add field name of the Next property in the <see cref="Batch{T}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Batch{T}"/>.</param>
    /// <typeparam name="T">The type of the items in <see cref="Batch{T}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="Batch{T}"/>, with an added field name.</returns>
    public static Partial<Batch<T>> WithNext<T>(this Partial<Batch<T>> it) 
        => it.AddFieldName("next");
        
    /// <summary>
    /// Add field name of the TotalCount property in the <see cref="Batch{T}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="Batch{T}"/>.</param>
    /// <typeparam name="T">The type of the items in <see cref="Batch{T}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="Batch{T}"/>, with an added field name.</returns>
    public static Partial<Batch<T>> WithTotalCount<T>(this Partial<Batch<T>> it) 
        => it.AddFieldName("totalCount");
}