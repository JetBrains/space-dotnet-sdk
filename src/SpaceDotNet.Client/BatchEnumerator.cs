using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    /// <summary>
    /// Helper class to enumerate <see cref="Batch{T}"/>.
    /// </summary>
    [PublicAPI]
    public static class BatchEnumerator
    {
        /// <summary>
        /// Delegate is called to retrieve a batch of data. It should take into account the <paramref name="skip"/> value.
        /// </summary>
        /// <param name="skip">Skip value, defines the number of items to skip.</param>
        /// <param name="cancellationToken">Cancellation token that can be used.</param>
        /// <typeparam name="T">Return type of the batch items.</typeparam>
        public delegate Task<Batch<T>> RetrieveBatch<T>(string? skip, CancellationToken cancellationToken);
        
        /// <summary>
        /// Enumerates all items in a batch.
        /// </summary>
        /// <param name="batchResponse">Delegate implementation to retrieve a batch of data.</param>
        /// <param name="initialSkip">Initial number of items that can be skipped.</param>
        /// <param name="cancellationToken">Cancellation token that can be used to cancel enumeration.</param>
        /// <typeparam name="T">Return type of the batch items.</typeparam>
        /// <returns>An <see cref="IAsyncEnumerable{T}"/> of items.</returns>
        public static async IAsyncEnumerable<T> AllItems<T>(RetrieveBatch<T> batchResponse, string? initialSkip = null, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            // ReSharper disable once MethodSupportsCancellation
            await foreach (var batch in AllPages(batchResponse, initialSkip).WithCancellation(cancellationToken))
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
        /// <param name="initialSkip">Initial number of items that can be skipped.</param>
        /// <param name="cancellationToken">Cancellation token that can be used to cancel enumeration.</param>
        /// <typeparam name="T">Return type of the batch items.</typeparam>
        /// <returns>An <see cref="IAsyncEnumerable{T}"/> of <see cref="Batch{T}"/>.</returns>
        public static async IAsyncEnumerable<Batch<T>> AllPages<T>(RetrieveBatch<T> batchResponse, string? initialSkip = null, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            if (cancellationToken.IsCancellationRequested) yield break;
            var batch = await batchResponse(initialSkip, cancellationToken);
            yield return batch;

            while (batch.HasNext())
            {
                if (cancellationToken.IsCancellationRequested) yield break;
                batch = await batchResponse(batch.Next, cancellationToken);
                yield return batch;
            }
        }
    }
}