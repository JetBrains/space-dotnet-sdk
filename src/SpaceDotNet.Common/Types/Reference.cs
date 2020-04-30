using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public class Reference<T>
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;
    }
}