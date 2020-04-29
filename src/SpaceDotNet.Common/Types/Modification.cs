using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public class Modification<T>
    {
        [Required]
        [JsonPropertyName("old")]
        public T Old { get; set; } = default!;
        
        [Required]
        [JsonPropertyName("new")]
        public T New { get; set; } = default!;
    }
}