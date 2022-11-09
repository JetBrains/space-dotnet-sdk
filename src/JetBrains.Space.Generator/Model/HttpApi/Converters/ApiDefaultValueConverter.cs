using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using JetBrains.Space.Common.Json.Serialization;

#nullable disable

namespace JetBrains.Space.Generator.Model.HttpApi.Converters;

public class ApiDefaultValueConverter : JsonConverter<ApiDefaultValue>
{
    private static readonly Dictionary<string, Type> TypeMap = new(StringComparer.OrdinalIgnoreCase)
    {
        { "HA_DefaultValue.Const.Primitive", typeof(ApiDefaultValue.Const.Primitive) },
        { "HA_DefaultValue.Const.EnumEntry", typeof(ApiDefaultValue.Const.EnumEntry) },
        { "HA_DefaultValue.Collection", typeof(ApiDefaultValue.Collection) },
        { "HA_DefaultValue.Map", typeof(ApiDefaultValue.Map) },
        { "HA_DefaultValue.Reference", typeof(ApiDefaultValue.Reference) }
    };
        
    public override bool CanConvert(Type objectType) => typeof(ApiDefaultValue).IsAssignableFrom(objectType);

    [CanBeNull]
    public override ApiDefaultValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null) return null;

        var readerAtStart = reader;
            
        using var jsonDocument = JsonDocument.ParseValue(ref reader);
        var jsonObject = jsonDocument.RootElement;

        var className = jsonObject.GetStringValue("className");
        if (!string.IsNullOrEmpty(className) && TypeMap.TryGetValue(className, out var targetType))
        {
            return JsonSerializer.Deserialize(ref readerAtStart, targetType, options) as ApiDefaultValue;
        }
            
        throw new JsonException("No className field was found that maps to a ApiDefaultValue subtype.");
    }

    public override void Write(Utf8JsonWriter writer, ApiDefaultValue value, JsonSerializerOptions options)
    {
        if (string.IsNullOrEmpty(value.ClassName))
        {
            value.ClassName = TypeMap.First(it => it.Value == value.GetType()).Key;
        }
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}