using Newtonsoft.Json;

namespace SpaceDotNet.Client
{
    public class Reference<T>
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}