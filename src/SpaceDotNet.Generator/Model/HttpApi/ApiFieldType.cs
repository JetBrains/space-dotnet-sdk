using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;
using SpaceDotNet.Generator.Model.HttpApi.Converters;

namespace SpaceDotNet.Generator.Model.HttpApi
{
    public abstract class ApiFieldType
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        [JsonPropertyName("nullable")]
        public bool Nullable { get; set; }
        
        [JsonPropertyName("optional")]
        public bool Optional { get; set; }

        public class Primitive : ApiFieldType
        {
            [JsonPropertyName("primitive")]
            public string Type { get; set; } = default!;
        }
        
        public class Array : ApiFieldType
        {
            [JsonPropertyName("elementType")]
            [JsonConverter(typeof(ApiFieldTypeConverter))]
            public ApiFieldType ElementType { get; set; } = default!;
        }
        
        public class Object : ApiFieldType
        {
            [JsonPropertyName("fields")]
            public List<ApiField> Fields { get; set; } = new List<ApiField>();
            
            [JsonPropertyName("kind")]
            public ObjectKind Kind { get; set; } = default!;
            
            [SuppressMessage("ReSharper", "InconsistentNaming")]
            [JsonConverter(typeof(EnumerationConverter))]
            public sealed class ObjectKind : Enumeration {
                private ObjectKind(string value) : base(value) { }
                
                public static readonly ObjectKind PAIR = new ObjectKind("PAIR");
                public static readonly ObjectKind TRIPLE = new ObjectKind("TRIPLE");
                public static readonly ObjectKind MAP_ENTRY = new ObjectKind("MAP_ENTRY");
                public static readonly ObjectKind BATCH = new ObjectKind("BATCH");
                public static readonly ObjectKind MOD = new ObjectKind("MOD");
                public static readonly ObjectKind REQUEST_BODY = new ObjectKind("REQUEST_BODY");
            }
        }
        
        public class Enum : ApiFieldType
        {
            [JsonPropertyName("enum")]
            public Reference<ApiEnum>? EnumRef { get; set; }
        }
        
        public class Dto : ApiFieldType
        {
            [JsonPropertyName("dto")]
            public ApiDto? DtoRef { get; set; }
        }
        
        public class Ref : ApiFieldType
        {
            [JsonPropertyName("dto")]
            public ApiDto? DtoRef { get; set; }
        }
    }
}