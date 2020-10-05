using System.Text.Json.Serialization;
using SpaceDotNet.Generator.Model.HttpApi.Converters;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiMenuId
    {
        [JsonPropertyName("menuId")]
        public string MenuId { get; set; } = default!;
        
        [JsonPropertyName("context")]
        public ApiDto? Context { get; set; }
    }
}