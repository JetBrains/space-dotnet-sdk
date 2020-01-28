using System.Text.Json.Serialization;
using SpaceDotNet.Generator.Model.HttpApi.Converters;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    [JsonConverter(typeof(ApiResourcePathSegmentConverter))]
    public abstract class ApiResourcePathSegment
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        public class Var : ApiResourcePathSegment
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }
        }
        
        public class PrefixedVar : ApiResourcePathSegment
        {
            [JsonPropertyName("prefix")]
            public string Prefix { get; set; }
            
            [JsonPropertyName("name")]
            public string Name { get; set; }
        }
        
        public class Const : ApiResourcePathSegment
        {
            [JsonPropertyName("value")]
            public string Value { get; set; }
        }
    }
}