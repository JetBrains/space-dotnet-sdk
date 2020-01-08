using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiResourcePath
    {
        [JsonPropertyName("segments")]
        public List<ApiResourcePathSegment> Segments { get; set; } = new List<ApiResourcePathSegment>();
    }
}