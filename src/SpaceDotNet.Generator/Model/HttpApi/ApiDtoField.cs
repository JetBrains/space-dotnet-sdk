using Newtonsoft.Json;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiDtoField
    {
        [JsonProperty("field")]
        public ApiField Field { get; set; }
    }
}