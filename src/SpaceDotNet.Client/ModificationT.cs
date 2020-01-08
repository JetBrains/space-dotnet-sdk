using System.Text.Json.Serialization;

namespace SpaceDotNet.Client
{
    public class Modification<T>
    {
        [JsonPropertyName("old")]
        public T Old { get; set; }
        
        [JsonPropertyName("new")]
        public T New { get; set; }
    }
}