using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Annotations;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    [PublicAPI]
    public static class BatchEnumerator
    {
        public delegate Task<Batch<T>> RetrieveBatch<T>(string? skip);
        
        public static async IAsyncEnumerable<T> AllItems<T>(RetrieveBatch<T> batchResponse, string? initialSkip = null)
        {
            await foreach (var batch in AllPages(batchResponse, initialSkip))
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
            
        public static async IAsyncEnumerable<Batch<T>> AllPages<T>(RetrieveBatch<T> batchResponse, string? initialSkip = null)
        {
            var batch = await batchResponse(initialSkip);
            yield return batch;

            while (batch.HasNext())
            {
                batch = await batchResponse(batch.Next);
                yield return batch;
            }
        }
    }
}