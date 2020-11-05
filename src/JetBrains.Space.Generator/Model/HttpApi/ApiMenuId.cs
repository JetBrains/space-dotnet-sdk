using System.Text.Json.Serialization;

namespace JetBrains.Space.Generator.Model.HttpApi
{
    public class ApiMenuId
    {
        [JsonPropertyName("menuId")]
        public string MenuId { get; set; } = default!;
        
        [JsonPropertyName("context")]
        public ApiDto? Context { get; set; }
    }
}