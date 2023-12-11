#nullable disable
using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using JetBrains.Space.Common.Json.Serialization;

namespace JetBrains.Space.Generator.Model.HttpApi.Converters;

public class ApiRequestPayloadConverter : JsonConverter<IApiRequestPayload>
{
    private static readonly Dictionary<string, Type> TypeMap = new(StringComparer.OrdinalIgnoreCase)
    {
        { "HA_Type.Object", typeof(ApiFieldType.Object) },
        { "HA_RawRequestPayload", typeof(ApiRawRequestPayload) }
    };

    public override bool CanConvert(Type objectType) => typeof(IApiRequestPayload).IsAssignableFrom(objectType);

    [CanBeNull]
    public override IApiRequestPayload Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null) return null;

        var readerAtStart = reader;

        using var jsonDocument = JsonDocument.ParseValue(ref reader);
        var jsonObject = jsonDocument.RootElement;

        var className = jsonObject.GetStringValue("className");
        if (!string.IsNullOrEmpty(className) && TypeMap.TryGetValue(className, out var targetType))
        {
            return JsonSerializer.Deserialize(ref readerAtStart, targetType, options) as IApiRequestPayload;
        }

        return JsonSerializer.Deserialize<ApiFieldType.Object>(ref readerAtStart);
    }

    public override void Write(Utf8JsonWriter writer, IApiRequestPayload value, JsonSerializerOptions options)
    {
        value.ClassName = TypeMap.First(it => it.Value == value.GetType()).Key;
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}