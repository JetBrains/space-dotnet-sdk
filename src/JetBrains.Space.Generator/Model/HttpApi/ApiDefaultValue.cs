using System.Collections.Generic;
using System.Text.Json.Serialization;
using JetBrains.Space.Generator.Model.HttpApi.Converters;

namespace JetBrains.Space.Generator.Model.HttpApi
{
    [JsonConverter(typeof(ApiDefaultValueConverter))]
    public abstract class ApiDefaultValue
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        public abstract class Const : ApiDefaultValue
        {
            public class Primitive : ApiDefaultValue
            {
                [JsonPropertyName("expression")]
                public string Expression { get; set; } = default!;
            }
            
            public class EnumEntry : ApiDefaultValue
            {
                [JsonPropertyName("entryName")]
                public string EntryName { get; set; } = default!;
            }
        }
        
        public class Collection : ApiDefaultValue
        {
            [JsonPropertyName("elements")]
            public List<ApiDefaultValue> Elements { get; set; } = new();
        }
        
        public class Map : ApiDefaultValue
        {
            [JsonPropertyName("elements")]
            public Dictionary<string, ApiDefaultValue> Elements { get; set; } = new();
        }
        
        public class Reference : ApiDefaultValue
        {
            [JsonPropertyName("paramName")]
            public string ParameterName { get; set; } = default!;
        }
    }
}