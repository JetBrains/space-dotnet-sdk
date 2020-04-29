using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public static class BatchEnumerator
    {
        public delegate Task<Batch<T>> RetrieveBatch<T>(string? skip);
        
        public static async IAsyncEnumerable<T> AllItems<T>(RetrieveBatch<T> batchResponse)
        {
            await foreach (var batch in AllPages(batchResponse))
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
            
        public static async IAsyncEnumerable<Batch<T>> AllPages<T>(RetrieveBatch<T> batchResponse)
        {
            var batch = await batchResponse(null);
            do
            {
                yield return batch;

                if (batch.HasNext())
                {
                    batch = await batchResponse(batch.Next);
                }
            } while (batch.HasNext());
        }
    }
}