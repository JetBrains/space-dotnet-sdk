using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    internal static class ListParameter
    {
        public static string? JoinToString<T>(this IList<T>? subject, string parameterName, Func<T, string?> transform)
        {
            if (subject == null)
            {
                return null;
            }

            var builder = new StringBuilder();
            for (var i = 0; i < subject.Count; i++)
            {
                builder.Append(transform(subject[i]));
                if (i != subject.Count - 1)
                {
                    builder.Append($"&{parameterName}=");
                }
            }
            return builder.ToString();
        }
    }
    
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