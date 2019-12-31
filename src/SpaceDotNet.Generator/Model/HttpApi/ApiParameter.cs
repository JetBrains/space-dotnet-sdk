using Newtonsoft.Json;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiParameter
    {
        [JsonProperty("field")]
        public ApiField Field { get; set; }
        
        [JsonProperty("path")]
        public bool Path { get; set; }
    }
}