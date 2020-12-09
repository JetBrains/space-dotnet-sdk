using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization;

namespace JetBrains.Space.Generator.Model.HttpApi
{
    [JsonConverter(typeof(EnumStringConverter))]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum ApiMethod
    {
        [EnumMember(Value = "HTTP_GET")] HTTP_GET,
        [EnumMember(Value = "HTTP_POST")] HTTP_POST,
        [EnumMember(Value = "HTTP_PATCH")] HTTP_PATCH,
        [EnumMember(Value = "HTTP_PUT")] HTTP_PUT,
        [EnumMember(Value = "HTTP_DELETE")] HTTP_DELETE,
        
        [EnumMember(Value = "REST_CREATE")] REST_CREATE,
        [EnumMember(Value = "REST_QUERY")] REST_QUERY,
        [EnumMember(Value = "REST_GET")] REST_GET,
        [EnumMember(Value = "REST_UPDATE")] REST_UPDATE,
        [EnumMember(Value = "REST_DELETE")] REST_DELETE
    }
}