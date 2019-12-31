using Newtonsoft.Json;

namespace SpaceDotNet.Client
{
    public class Modification<T>
    {
        [JsonProperty("old")]
        public T Old { get; set; }
        
        [JsonProperty("new")]
        public T New { get; set; }
    }
}