using JetBrains.Annotations;
using JetBrains.Space.Common.Types;

// ReSharper disable once CheckNamespace Make discovery easier
namespace JetBrains.Space.Common;

/// <summary>
/// Extensions methods for <see cref="Partial{T}"/> of <see cref="SyncBatch{T}"/>.
/// </summary>
[PublicAPI]
public static class SyncBatchPartialExtensions
{
    /// <summary>
    /// Add field name of the Data property in the <see cref="SyncBatch{T}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="SyncBatch{T}"/>.</param>
    /// <typeparam name="T">The type of the items in <see cref="SyncBatch{T}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="SyncBatch{T}"/>, with an added field name.</returns>
    public static Partial<SyncBatch<T>> WithData<T>(this Partial<SyncBatch<T>> it) 
        => it.AddFieldName("data");
        
    /// <summary>
    /// Add field name of the Data property in the <see cref="SyncBatch{T}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="SyncBatch{T}"/>.</param>
    /// <param name="partialBuilder">A child <see cref="Partial{T}"/> of <typeparamref name="T"/>.</param>
    /// <typeparam name="T">The type of the items in <see cref="SyncBatch{T}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="SyncBatch{T}"/>, with an added field name.</returns>
    public static Partial<SyncBatch<T>> WithData<T>(this Partial<SyncBatch<T>> it, Func<Partial<T>, Partial<T>> partialBuilder) 
        => it.AddFieldName("data", partialBuilder(new Partial<T>()));
        
    /// <summary>
    /// Add field name of the Etag property in the <see cref="SyncBatch{T}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="SyncBatch{T}"/>.</param>
    /// <typeparam name="T">The type of the items in <see cref="SyncBatch{T}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="SyncBatch{T}"/>, with an added field name.</returns>
    public static Partial<SyncBatch<T>> WithEtag<T>(this Partial<SyncBatch<T>> it) 
        => it.AddFieldName("etag");
        
    /// <summary>
    /// Add field name of the HasMore property in the <see cref="SyncBatch{T}"/>.
    /// </summary>
    /// <param name="it">The <see cref="Partial{T}"/> of <see cref="SyncBatch{T}"/>.</param>
    /// <typeparam name="T">The type of the items in <see cref="SyncBatch{T}"/>.</typeparam>
    /// <returns>The <see cref="Partial{T}"/> of <see cref="SyncBatch{T}"/>, with an added field name.</returns>
    public static Partial<SyncBatch<T>> WithHasMore<T>(this Partial<SyncBatch<T>> it) 
        => it.AddFieldName("hasMore");
}