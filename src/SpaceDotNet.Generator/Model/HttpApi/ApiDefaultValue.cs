using System.Collections.Generic;
using System.Text.Json.Serialization;
using SpaceDotNet.Generator.Model.HttpApi.Converters;

namespace SpaceDotNet.Generator.Model.HttpApi
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
            public List<ApiDefaultValue> Elements { get; set; } = new List<ApiDefaultValue>();
        }
        
        public class Reference : ApiDefaultValue
        {
            [JsonPropertyName("paramName")]
            public string ParameterName { get; set; } = default!;
        }
    }
}