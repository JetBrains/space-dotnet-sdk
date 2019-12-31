using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using SpaceDotNet.Client;
using SpaceDotNet.Generator.Model.HttpApi.Converters;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public abstract class ApiFieldType
    {
        [JsonProperty("nullable")]
        public bool Nullable { get; set; }
        
        [JsonProperty("optional")]
        public bool Optional { get; set; }

        public class Primitive : ApiFieldType
        {
            [JsonProperty("primitive")]
            public string Type { get; set; }
        }
        
        public class Array : ApiFieldType
        {
            [JsonProperty("elementType")]
            [JsonConverter(typeof(ApiFieldTypeConverter))]
            public ApiFieldType ElementType { get; set; }
        }
        
        public class Object : ApiFieldType
        {
            [JsonProperty("fields")]
            public List<ApiField> Fields { get; set; } = new List<ApiField>();
            
            [JsonProperty("kind")]
            public ObjectKind Kind { get; set; }
            
            [SuppressMessage("ReSharper", "InconsistentNaming")]
            public enum ObjectKind {
                PAIR,
                TRIPLE, 
                MAP_ENTRY, 
                BATCH, 
                MOD, 
                REQUEST_BODY
            }
        }
        
        public class Enum : ApiFieldType
        {
            [JsonProperty("enum")]
            public Reference<ApiEnum>? EnumRef { get; set; }
        }
        
        public class Dto : ApiFieldType
        {
            [JsonProperty("dto")]
            public Reference<ApiDto>? DtoRef { get; set; }
        }
        
        public class Ref : ApiFieldType
        {
            [JsonProperty("dto")]
            public Reference<ApiDto>? DtoRef { get; set; }
        }
    }
}