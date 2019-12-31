using System.Collections.Generic;
using Newtonsoft.Json;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public class ApiResourcePath
    {
        [JsonProperty("segments")]
        public List<ApiResourcePathSegment> Segments { get; set; } = new List<ApiResourcePathSegment>();
    }
}