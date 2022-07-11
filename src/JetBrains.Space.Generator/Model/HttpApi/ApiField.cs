using System.Text.Json.Serialization;
using JetBrains.Space.Generator.Model.HttpApi.Converters;

namespace JetBrains.Space.Generator.Model.HttpApi;

public class ApiField
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;
        
    [JsonPropertyName("type")]
    [JsonConverter(typeof(ApiFieldTypeConverter))]
    public ApiFieldType Type { get; set; } = default!;
        
    [JsonPropertyName("optional")]
    public bool Optional { get; set; }
        
    [JsonPropertyName("description")]
    public ApiDescription? Description { get; set; }
    
    [JsonPropertyName("deprecation")]
    public ApiDeprecation? Deprecation { get; set; }
        
    [JsonPropertyName("experimental")]
    public ApiExperimental? Experimental { get; set; } = default;
        
    [JsonPropertyName("defaultValue")]
    public ApiDefaultValue? DefaultValue { get; set; }
}