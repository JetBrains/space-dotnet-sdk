using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Generator.Model.HttpApi
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [JsonConverter(typeof(EnumerationConverter))]
    public sealed class ApiMethod : Enumeration {
        private ApiMethod(string value) : base(value) { }
                
        public static readonly ApiMethod HTTP_GET = new ApiMethod("HTTP_GET");
        public static readonly ApiMethod HTTP_POST = new ApiMethod("HTTP_POST");
        public static readonly ApiMethod HTTP_PATCH = new ApiMethod("HTTP_PATCH");
        public static readonly ApiMethod HTTP_PUT = new ApiMethod("HTTP_PUT");
        public static readonly ApiMethod HTTP_DELETE = new ApiMethod("HTTP_DELETE");
        
        public static readonly ApiMethod REST_CREATE = new ApiMethod("REST_CREATE");
        public static readonly ApiMethod REST_QUERY = new ApiMethod("REST_QUERY");
        public static readonly ApiMethod REST_GET = new ApiMethod("REST_GET");
        public static readonly ApiMethod REST_UPDATE = new ApiMethod("REST_UPDATE");
        public static readonly ApiMethod REST_DELETE = new ApiMethod("REST_DELETE");
    }
}