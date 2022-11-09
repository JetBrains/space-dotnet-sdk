using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization;
using Xunit;

namespace JetBrains.Space.Client.Tests.Json.Serialization;

public class EnumStringConverterTests
{
    [Theory]
    [InlineData(typeof(TestEnum), true)]
    [InlineData(typeof(TestEnum?), true)]
    [InlineData(typeof(object), false)]
    public void CanConvertTests(Type requestedType, bool expectedResult)
    {
        // Arrange
        var target = new EnumStringConverter();
            
        // Act
        var result = target.CanConvert(requestedType);
                
        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void ReadKnownValuesTests()
    {
        // Arrange
        var inputs = new Dictionary<string, TestEnum>
        {
            {"\"with-enum-member\"", TestEnum.WithEnumMember},
            {"\"WITH-ENUM-MEMBER\"", TestEnum.WithEnumMember},
            {"\"With-Enum-Member\"", TestEnum.WithEnumMember},
            {"\"plain\"", TestEnum.Plain},
            {"\"PLAIN\"", TestEnum.Plain},
            {"\"Plain\"", TestEnum.Plain}
        };

        var factory = new EnumStringConverter();
            
        // Act & Assert
        foreach (var (json, expectedResult) in inputs)
        {
            var target = (JsonConverter<TestEnum>)factory.CreateConverter(typeof(TestEnum), new JsonSerializerOptions());
                
            TestEnum? result = null;
                
            var utf8JsonBytes = Encoding.UTF8.GetBytes(json);
            var reader = new Utf8JsonReader(utf8JsonBytes, true, new JsonReaderState());
            while (reader.Read())
            {
                result = target.Read(ref reader, typeof(TestEnum), new JsonSerializerOptions());
            }
                
            Assert.Equal(expectedResult, result);
        }
    }
        
    [Fact]
    public void ReadUnknownValuesTests()
    {
        // Arrange
        var factory = new EnumStringConverter();
        var target = (JsonConverter<TestEnum>)factory.CreateConverter(typeof(TestEnum), new JsonSerializerOptions());
            
        // Act & Assert
        Assert.Throws<JsonException>(() =>
        {
            var utf8JsonBytes = Encoding.UTF8.GetBytes("\"UNKNOWN_VALUE\"");
            var reader = new Utf8JsonReader(utf8JsonBytes, true, new JsonReaderState());
            while (reader.Read())
            {
                target.Read(ref reader, typeof(TestEnum), new JsonSerializerOptions());
            }
        });
    }
        
    [Fact]
    public void WriteTests()
    {
        // Arrange
        var inputs = new Dictionary<string, TestEnum>
        {
            {"\"with-enum-member\"", TestEnum.WithEnumMember},
            {"\"Plain\"", TestEnum.Plain}
        };

        var factory = new EnumStringConverter();
        var target = (JsonConverter<TestEnum>)factory.CreateConverter(typeof(TestEnum), new JsonSerializerOptions());
            
        // Act & Assert
        foreach (var (expectedResult, input) in inputs)
        {
            using var memoryStream = new MemoryStream();
            var writer = new Utf8JsonWriter(memoryStream);
            target.Write(writer, input, new JsonSerializerOptions());
            writer.Flush();
            memoryStream.Position = 0;
                
            using var reader = new StreamReader(memoryStream);
            var result = reader.ReadToEnd();
                
            Assert.Equal(expectedResult, result);
        }
    }
        
    public enum TestEnum
    {
        [EnumMember(Value = "with-enum-member")]
        WithEnumMember, 
            
        Plain
    }
}