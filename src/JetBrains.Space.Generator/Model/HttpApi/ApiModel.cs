using System.Text.Json.Serialization;

namespace JetBrains.Space.Generator.Model.HttpApi;

public class ApiModel
{
    [JsonPropertyName("dto")]
    public List<ApiDto> Dto { get; set; } = new();
        
    [JsonPropertyName("enums")]
    public List<ApiEnum> Enums { get; set; } = new();
        
    [JsonPropertyName("urlParams")]
    public List<ApiUrlParameter> UrlParameters { get; set; } = new();
        
    [JsonPropertyName("resources")]
    public List<ApiResource> Resources { get; set; } = new();
        
    [JsonPropertyName("menuIds")]
    public List<ApiMenuId> MenuIds { get; set; } = new();
}