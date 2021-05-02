using System.Collections.Generic;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace JetBrains.Space.Common.Types
{
    /// <summary>
    /// A class that represents a batch of items.
    /// </summary>
    /// <typeparam name="T">The type of the items in the <see cref="Batch{T}"/>.</typeparam>
    [PublicAPI]
    public class Batch<T> 
        : IPropagatePropertyAccessPath
    {
        /// <summary>
        /// Get the collection of items in the batch.
        /// </summary>
        [JsonPropertyName("data")]
        public List<T>? Data { get; set; }

        /// <summary>
        /// Get the next batch.
        /// When not null, represents the start of the next batch that can be used as a skip parameter to methods returning a batch.
        /// </summary>
        [JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Get the total count of items in all batches of the entire result set.
        /// </summary>
        /// <remarks>
        /// Not every batch result provides a value for the total result count, and this value may be <value>null</value>.
        /// </remarks>
        [JsonPropertyName("totalCount")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Is another batch available?
        /// </summary>
        /// <returns><see langword="true"/> if another batch is available; <see langword="false"/> otherwise.</returns>
        public bool HasNext()
        {
            // According to internal discussion, a batch is exhausted if there is no more data...
            if (Data != null)
            {
                return Data.Count > 0 && !string.IsNullOrEmpty(Next);
            }

            // ...but if no data was requested, see if there is a total count and use that...
            if (TotalCount != null)
            {
                return !string.IsNullOrEmpty(Next) && Next != TotalCount.ToString();
            }

            // ...in other cases, return to prevent infinite loops.
            return false;
        }

        /// <inheritdoc />
        public void SetAccessPath(string path, bool validateHasBeenSet)
        {
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(Data)}()", validateHasBeenSet, Data);
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(Next)}()", validateHasBeenSet, Next);
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(TotalCount)}()", validateHasBeenSet, TotalCount);
        }
    }
}