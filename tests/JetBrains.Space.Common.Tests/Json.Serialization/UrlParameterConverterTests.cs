using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Types;
using Xunit;

namespace JetBrains.Space.Client.Tests.Json.Serialization;

public class UrlParameterConverterTests
{
    [Theory]
    [InlineData(typeof(SomeUrlParameter), true)]
    [InlineData(typeof(object), false)]
    public void CanConvertTests(Type requestedType, bool expectedResult)
    {
        // Arrange
        var target = new UrlParameterConverter();

        // Act
        var result = target.CanConvert(requestedType);
                
        // Assert
        Assert.Equal(expectedResult, result);
    }
        
    [Fact]
    public void ReadReturnsNullForSomeUrlParameter()
    {
        // Arrange
        var target = new UrlParameterConverter().CreateConverter(typeof(SomeUrlParameter), new JsonSerializerOptions()) as JsonConverter<SomeUrlParameter>;
            
        // Act & Assert
        IUrlParameter? result = null;
            
        var utf8JsonBytes = Encoding.UTF8.GetBytes("{ }");
        var reader = new Utf8JsonReader(utf8JsonBytes, true, new JsonReaderState());
        while (reader.Read())
        {
            result = target!.Read(ref reader, typeof(SomeUrlParameter), new JsonSerializerOptions());
        }
            
        Assert.Null(result);
    }
        
    [Fact]
    public void WriteTests()
    {
        // Arrange
        var target = new UrlParameterConverter().CreateConverter(typeof(SomeUrlParameter), new JsonSerializerOptions()) as JsonConverter<SomeUrlParameter>;

            
        // Act & Assert
        using var memoryStream = new MemoryStream();
        var writer = new Utf8JsonWriter(memoryStream);
        target!.Write(writer, new SomeUrlParameter(), new JsonSerializerOptions());
        writer.Flush();
        memoryStream.Position = 0;
            
        using var reader = new StreamReader(memoryStream);
        var result = reader.ReadToEnd();
            
        Assert.Equal($"\"{nameof(SomeUrlParameter)}\"", result);
    }

    public sealed class SomeUrlParameter : IUrlParameter
    {
        public override string ToString() => nameof(SomeUrlParameter);
    }
}