using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JetBrains.Space.Generator.Model.HttpApi
{
    public class ApiResourcePath
    {
        [JsonPropertyName("segments")]
        public List<ApiResourcePathSegment> Segments { get; set; } = new();
    }
}