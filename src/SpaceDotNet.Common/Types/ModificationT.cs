using System.Text.Json.Serialization;

namespace SpaceDotNet.Common.Types
{
    public class Modification<T>
    {
        [JsonPropertyName("old")]
        public T Old { get; set; }
        
        [JsonPropertyName("new")]
        public T New { get; set; }
    }
}