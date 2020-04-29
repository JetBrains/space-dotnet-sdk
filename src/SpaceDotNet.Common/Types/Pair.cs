using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public class Pair<TFirst, TSecond>
    {
        [Required]
        [JsonPropertyName("first")]
        public TFirst First { get; set; } = default!;

        [Required]
        [JsonPropertyName("second")]
        public TSecond Second { get; set; } = default!;
    }
}