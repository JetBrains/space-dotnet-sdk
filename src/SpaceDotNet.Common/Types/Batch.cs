using System.Collections.Generic;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
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
        /// The collection of items in the batch.
        /// </summary>
        [JsonPropertyName("data")]
        public List<T>? Data { get; set; }

        /// <summary>
        /// When not null, represents the start of the next batch that can be used as a skip parameter to methods returning a batch.
        /// </summary>
        [JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// The total count of items in all batches of the entire result set.
        /// </summary>
        [JsonPropertyName("totalCount")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Is another batch available?
        /// </summary>
        /// <returns><see langword="true"/> if another batch is available; <see langword="false"/> otherwise.</returns>
        public bool HasNext() => TotalCount != null && !string.IsNullOrEmpty(Next) && Next != TotalCount.ToString();
        
        /// <inheritdoc />
        public void SetAccessPath(string path, bool validateHasBeenSet)
        {
            PropagatePropertyAccessPathHelper.SetAccessPathForValue($"{path}->With{nameof(Data)}()", validateHasBeenSet, Data);
        }
    }
}