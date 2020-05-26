using System.Collections.Generic;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public class Batch<T>
    {
        [JsonPropertyName("data")]
        public List<T>? Data { get; set; }

        [JsonPropertyName("next")]
        public string? Next { get; set; }

        [JsonPropertyName("totalCount")]
        public int? TotalCount { get; set; }

        public bool HasNext() => TotalCount != null && !string.IsNullOrEmpty(Next) && int.TryParse(Next, out var next) && next != TotalCount;
    }
}