using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

/// <summary>
/// Helper class to enumerate <see cref="SyncBatch{T}"/>.
/// </summary>
[PublicAPI]
public static class SyncBatchEnumerator
{
    /// <summary>
    /// Delegate is called to retrieve a batch of data. It should take into account the <paramref name="etag"/> value.
    /// </summary>
    /// <param name="etag">The etag value to start iterating from.</param>
    /// <param name="cancellationToken">Cancellation token that can be used.</param>
    /// <typeparam name="T">Return type of the batch items.</typeparam>
    public delegate Task<SyncBatch<T>> RetrieveSyncBatch<T>(string? etag, CancellationToken cancellationToken);
        
    /// <summary>
    /// Enumerates all items in a batch.
    /// </summary>
    /// <param name="batchResponse">Delegate implementation to retrieve a batch of data.</param>
    /// <param name="initialEtag">Initial etag value to start iterating from.</param>
    /// <param name="cancellationToken">Cancellation token that can be used to cancel enumeration.</param>
    /// <typeparam name="T">Return type of the batch items.</typeparam>
    /// <returns>An <see cref="IAsyncEnumerable{T}"/> of items.</returns>
    public static async IAsyncEnumerable<T> AllItems<T>(RetrieveSyncBatch<T> batchResponse, string? initialEtag = null, [EnumeratorCancellation]CancellationToken cancellationToken = default)
    {
        // ReSharper disable once MethodSupportsCancellation
        await foreach (var batch in AllPages(batchResponse, initialEtag).WithCancellation(cancellationToken))
        {
            if (batch.Data != null)
            {
                foreach (var item in batch.Data)
                {
                    yield return item;
                }
            }
            else
            {
                yield break;
            }
        }
    }

    /// <summary>
    /// Enumerates all pages in a batch.
    /// </summary>
    /// <param name="batchResponse">Delegate implementation to retrieve a batch of data.</param>
    /// <param name="initialEtag">Initial etag value to start iterating from.</param>
    /// <param name="cancellationToken">Cancellation token that can be used to cancel enumeration.</param>
    /// <typeparam name="T">Return type of the batch items.</typeparam>
    /// <returns>An <see cref="IAsyncEnumerable{T}"/> of <see cref="SyncBatch{T}"/>.</returns>
    public static async IAsyncEnumerable<SyncBatch<T>> AllPages<T>(RetrieveSyncBatch<T> batchResponse, string? initialEtag = null, [EnumeratorCancellation]CancellationToken cancellationToken = default)
    {
        if (cancellationToken.IsCancellationRequested) yield break;
        var batch = await batchResponse(initialEtag, cancellationToken);
        yield return batch;

        while (batch.HasMore && batch.Etag != null)
        {
            if (cancellationToken.IsCancellationRequested) yield break;
            batch = await batchResponse(batch.Etag, cancellationToken);
            yield return batch;
        }
    }
}