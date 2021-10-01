using System.Text.Json.Serialization;
using JetBrains.Space.Generator.Model.HttpApi.Converters;

namespace JetBrains.Space.Generator.Model.HttpApi;

[JsonConverter(typeof(ApiResourcePathSegmentConverter))]
public abstract class ApiResourcePathSegment
{
    [JsonPropertyName("className")]
    public string? ClassName { get; set; }
        
    public class Var : ApiResourcePathSegment
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
    }
        
    public class PrefixedVar : ApiResourcePathSegment
    {
        [JsonPropertyName("prefix")]
        public string Prefix { get; set; } = default!;
            
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
    }
        
    public class Const : ApiResourcePathSegment
    {
        [JsonPropertyName("value")]
        public string Value { get; set; } = default!;
    }
}