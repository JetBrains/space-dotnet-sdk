using System.Text;
using System.Text.Json;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Types;
using Xunit;

namespace JetBrains.Space.Client.Tests.Json.Serialization;

public class EnumerationConverterTests
{
    [Theory]
    [InlineData(typeof(SampleEnumeration), true)]
    [InlineData(typeof(Enumeration), false)]
    [InlineData(typeof(object), false)]
    public void CanConvertTests(Type requestedType, bool expectedResult)
    {
        // Arrange
        var target = new EnumerationConverter();
            
        // Act
        var result = target.CanConvert(requestedType);
                
        // Assert
        Assert.Equal(expectedResult, result);
    }
        
    [Fact]
    public void ReadKnownValuesTests()
    {
        // Arrange
        var inputs = new Dictionary<string, SampleEnumeration>
        {
            {"\"Value1\"", SampleEnumeration.Value1},
            {"\"valuE1\"", SampleEnumeration.Value1},
            {"\"Value2\"", SampleEnumeration.Value2},
            {"\"value2\"", SampleEnumeration.Value2},
            {"\"Value3\"", SampleEnumeration.Value3},
            {"\"value3\"", SampleEnumeration.Value3}
        };
                
        var target = new EnumerationConverter();
            
        // Act & Assert
        foreach (var (json, expectedResult) in inputs)
        {
            Enumeration? result = null;
                
            var utf8JsonBytes = Encoding.UTF8.GetBytes(json);
            var reader = new Utf8JsonReader(utf8JsonBytes, true, new JsonReaderState());
            while (reader.Read())
            {
                result = target.Read(ref reader, typeof(SampleEnumeration), new JsonSerializerOptions());
            }
                
            Assert.Equal(expectedResult, result);
        }
    }
        
    [Fact]
    public void ReadUnknownValuesTests()
    {
        // Arrange
        var target = new EnumerationConverter();
            
        // Act
        Enumeration? result = null;
                
        var utf8JsonBytes = Encoding.UTF8.GetBytes("\"UNKNOWN_VALUE\"");
        var reader = new Utf8JsonReader(utf8JsonBytes, true, new JsonReaderState());
        while (reader.Read())
        {
            result = target.Read(ref reader, typeof(SampleEnumeration), new JsonSerializerOptions());
        }
            
        // Assert
        Assert.Null(result);
    }
        
    [Fact]
    public void WriteTests()
    {
        // Arrange
        var inputs = new Dictionary<string, SampleEnumeration>
        {
            {"\"Value1\"", SampleEnumeration.Value1},
            {"\"Value2\"", SampleEnumeration.Value2},
            {"\"Value3\"", SampleEnumeration.Value3}
        };
                
        var target = new EnumerationConverter();
            
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

    public sealed class SampleEnumeration : Enumeration
    {
        private SampleEnumeration(string value) : base(value) { }
            
        public static readonly SampleEnumeration Value1 = new("Value1");
        public static readonly SampleEnumeration Value2 = new("Value2");
        public static readonly SampleEnumeration Value3 = new("Value3");
    }
}