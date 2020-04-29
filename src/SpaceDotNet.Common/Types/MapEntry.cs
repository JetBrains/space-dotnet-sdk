using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public class MapEntry<TKey, TValue>
    {
        [Required]
        [JsonPropertyName("key")]
        public TKey Key { get; set; } = default!;

        [Required]
        [JsonPropertyName("value")]
        public TValue Value { get; set; } = default!;
    }
}