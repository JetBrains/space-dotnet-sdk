using System.Text;
using System.Text.Json;
using JetBrains.Space.Common.Types;
using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.Model.HttpApi.Converters;
using Xunit;

namespace JetBrains.Space.Client.Tests.Json.Serialization;

public class ApiRequestPayloadConverterTests
{
    [Theory]
    [InlineData(typeof(ApiFieldType.Object), true)]
    [InlineData(typeof(ApiRawRequestPayload), true)]
    [InlineData(typeof(ApiFieldType.Primitive), false)]
    [InlineData(typeof(Enumeration), false)]
    [InlineData(typeof(object), false)]
    public void CanConvertTests(Type requestedType, bool expectedResult)
    {
        // Arrange
        var target = new ApiRequestPayloadConverter();

        // Act
        var result = target.CanConvert(requestedType);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void ReadKnownValuesTests()
    {
        // Arrange
        var json = "{\"className\":\"HA_RawRequestPayload\",\"allowedMimeTypes\":[]}";
        var target = new ApiRequestPayloadConverter();

        // Act
        IApiRequestPayload? result = null;
        var utf8JsonBytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(utf8JsonBytes, true, new JsonReaderState());
        while (reader.Read())
        {
            result = target.Read(ref reader, typeof(IApiRequestPayload), new JsonSerializerOptions());
        }

        // Assert
        Assert.IsType<ApiRawRequestPayload>(result);

        var rawRequestPayload = result as ApiRawRequestPayload;
        Assert.NotNull(rawRequestPayload);
        Assert.Empty(rawRequestPayload.AllowedMimeTypes);
    }

    [Fact]
    public void WriteTests()
    {
        // Arrange
        var input = new ApiFieldType.Object
        {
            Nullable = false,
            Tags = new List<string> { "TEST" },
            Fields = new(0),
            Kind = ApiFieldType.Object.ObjectKind.REQUEST_BODY
        };
        var target = new ApiRequestPayloadConverter();

        // Act
        using var memoryStream = new MemoryStream();
        var writer = new Utf8JsonWriter(memoryStream);
        target.Write(writer, input, new JsonSerializerOptions());
        writer.Flush();
        memoryStream.Position = 0;

        using var reader = new StreamReader(memoryStream);
        var result = reader.ReadToEnd();

        // Assert
        Assert.Equal("{\"fields\":[],\"kind\":\"REQUEST_BODY\",\"className\":\"HA_Type.Object\",\"nullable\":false,\"tags\":[\"TEST\"]}", result);
    }
}