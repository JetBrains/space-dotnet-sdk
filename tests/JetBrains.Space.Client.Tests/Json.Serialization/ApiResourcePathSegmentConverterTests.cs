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
    public class ApiResourcePathSegmentConverterTests
    {
        [Theory]
        [InlineData(typeof(ApiResourcePathSegment.Const), true)]
        [InlineData(typeof(ApiResourcePathSegment.Var), true)]
        [InlineData(typeof(ApiResourcePathSegment.PrefixedVar), true)]
        [InlineData(typeof(Enumeration), false)]
        [InlineData(typeof(object), false)]
        public void CanConvertTests(Type requestedType, bool expectedResult)
        {
            // Arrange
            var target = new ApiResourcePathSegmentConverter();
            
            // Act
            var result = target.CanConvert(requestedType);
                
            // Assert
            Assert.Equal(expectedResult, result);
        }
        
        [Fact]
        public void ReadKnownValuesTests()
        {
            // Arrange
            var json = "{\"className\":\"HA_PathSegment.PrefixedVar\",\"prefix\":\"foo\",\"name\":\"bar\"}";
            var target = new ApiResourcePathSegmentConverter();
            
            // Act
            ApiResourcePathSegment? result = null;
            var utf8JsonBytes = Encoding.UTF8.GetBytes(json);
            var reader = new Utf8JsonReader(utf8JsonBytes, true, new JsonReaderState());
            while (reader.Read())
            {
                result = target.Read(ref reader, typeof(ApiResourcePathSegment), new JsonSerializerOptions());
            }
                
            // Assert
            Assert.IsType<ApiResourcePathSegment.PrefixedVar>(result);
            
            var prefixedVarResult = result as ApiResourcePathSegment.PrefixedVar;
            Assert.Equal("foo", prefixedVarResult?.Prefix);
            Assert.Equal("bar", prefixedVarResult?.Name);
        }
        
        [Fact]
        public void WriteTests()
        {
            // Arrange
            var input = new ApiResourcePathSegment.PrefixedVar
            {
                Prefix = "foo",
                Name = "bar"
            };
            var target = new ApiResourcePathSegmentConverter();
            
            // Act
            using var memoryStream = new MemoryStream();
            var writer = new Utf8JsonWriter(memoryStream);
            target.Write(writer, input, new JsonSerializerOptions());
            writer.Flush();
            memoryStream.Position = 0;
                
            using var reader = new StreamReader(memoryStream);
            var result = reader.ReadToEnd();
            
            // Assert
            Assert.Equal("{\"prefix\":\"foo\",\"name\":\"bar\",\"className\":\"HA_PathSegment.PrefixedVar\"}", result);
        }
    }
}