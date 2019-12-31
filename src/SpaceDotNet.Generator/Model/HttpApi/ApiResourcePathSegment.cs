using Newtonsoft.Json;
using SpaceDotNet.Generator.Model.HttpApi.Converters;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    [JsonConverter(typeof(ApiResourcePathSegmentConverter))]
    public abstract class ApiResourcePathSegment
    {
        public class Var : ApiResourcePathSegment
        {
            [JsonProperty("name")]
            public string Name { get; set; }
        }
        
        public class PrefixedVar : ApiResourcePathSegment
        {
            [JsonProperty("prefix")]
            public string Prefix { get; set; }
            
            [JsonProperty("name")]
            public string Name { get; set; }
        }
        
        public class Const : ApiResourcePathSegment
        {
            [JsonProperty("value")]
            public string Value { get; set; }
        }
    }
}