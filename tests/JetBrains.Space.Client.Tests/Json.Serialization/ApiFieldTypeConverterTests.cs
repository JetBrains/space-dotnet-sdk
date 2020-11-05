using System;
using System.IO;
using System.Text;
using System.Text.Json;
using JetBrains.Space.Common.Types;
using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.Model.HttpApi.Converters;
using Xunit;

namespace JetBrains.Space.Client.Tests.Json.Serialization
{
    public class ApiFieldTypeConverterTests
    {
        [Theory]
        [InlineData(typeof(ApiFieldType.Array), true)]
        [InlineData(typeof(ApiFieldType.Dto), true)]
        [InlineData(typeof(ApiFieldType.Enum), true)]
        [InlineData(typeof(ApiFieldType.UrlParam), true)]
        [InlineData(typeof(ApiFieldType.Object), true)]
        [InlineData(typeof(ApiFieldType.Primitive), true)]
        [InlineData(typeof(ApiFieldType.Ref), true)]
        [InlineData(typeof(Enumeration), false)]
        [InlineData(typeof(object), false)]
        public void CanConvertTests(Type requestedType, bool expectedResult)
        {
            // Arrange
            var target = new ApiFieldTypeConverter();
            
            // Act
            var result = target.CanConvert(requestedType);
                
            // Assert
            Assert.Equal(expectedResult, result);
        }
        
        [Fact]
        public void ReadKnownValuesTests()
        {
            // Arrange
            var json = "{\"className\":\"HA_Type.Primitive\",\"primitive\":\"String\",\"nullable\":true}";
            var target = new ApiFieldTypeConverter();
            
            // Act
            ApiFieldType? result = null;
            var utf8JsonBytes = Encoding.UTF8.GetBytes(json);
            var reader = new Utf8JsonReader(utf8JsonBytes, true, new JsonReaderState());
            while (reader.Read())
            {
                result = target.Read(ref reader, typeof(ApiFieldType), new JsonSerializerOptions());
            }
                
            // Assert
            Assert.IsType<ApiFieldType.Primitive>(result);
            
            var primitiveResult = result as ApiFieldType.Primitive;
            Assert.Equal("String", primitiveResult?.Type);
            Assert.True(primitiveResult?.Nullable);
        }
        
        [Fact]
        public void WriteTests()
        {
            // Arrange
            var input = new ApiFieldType.Primitive
            {
                Type = "String",
                Nullable = true
            };
            var target = new ApiFieldTypeConverter();
            
            // Act
            using var memoryStream = new MemoryStream();
            var writer = new Utf8JsonWriter(memoryStream);
            target.Write(writer, input, new JsonSerializerOptions());
            writer.Flush();
            memoryStream.Position = 0;
                
            using var reader = new StreamReader(memoryStream);
            var result = reader.ReadToEnd();
            
            // Assert
            Assert.Equal("{\"primitive\":\"String\",\"className\":\"HA_Type.Primitive\",\"nullable\":true}", result);
        }
    }
}