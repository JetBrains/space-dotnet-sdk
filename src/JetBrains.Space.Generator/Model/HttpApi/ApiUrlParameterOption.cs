using System.Text.Json.Serialization;
using JetBrains.Space.Generator.Model.HttpApi.Converters;

namespace JetBrains.Space.Generator.Model.HttpApi;

[JsonConverter(typeof(ApiUrlParameterOptionConverter))]
public abstract class ApiUrlParameterOption
{
    [JsonPropertyName("className")]
    public string? ClassName { get; set; }
        
    [JsonPropertyName("optionName")]
    public string OptionName { get; set; } = default!;
    
    [JsonPropertyName("description")]
    public ApiDescription? Description { get; set; }
        
    [JsonPropertyName("deprecation")]
    public ApiDeprecation? Deprecation { get; set; } = default;
        
    [JsonPropertyName("experimental")]
    public ApiExperimental? Experimental { get; set; } = default;

    [JsonPropertyName("featureFlag")]
    public string? FeatureFlag { get; set; }
        
    public class Var : ApiUrlParameterOption
    {
        [JsonPropertyName("parameters")]
        public List<ApiField> Parameters { get; set; } = new();
            
        [JsonPropertyName("prefixRequired")]
        public bool PrefixRequired { get; set; } = default!;
    }
        
    public class Const : ApiUrlParameterOption
    {
        [JsonPropertyName("value")]
        public string Value { get; set; } = default!;
    }
}