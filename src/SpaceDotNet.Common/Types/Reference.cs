using System.Text.Json.Serialization;

namespace SpaceDotNet.Common.Types
{
    public class Reference<T>
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}