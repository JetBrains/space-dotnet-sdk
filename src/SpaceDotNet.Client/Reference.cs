using System.Text.Json.Serialization;

namespace SpaceDotNet.Client
{
    public class Reference<T>
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}