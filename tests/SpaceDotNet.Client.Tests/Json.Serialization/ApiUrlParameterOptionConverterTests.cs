using System;
using System.IO;
using System.Text;
using System.Text.Json;
using SpaceDotNet.Common.Types;
using SpaceDotNet.Generator.Model.HttpApi;
using SpaceDotNet.Generator.Model.HttpApi.Converters;
using Xunit;

namespace SpaceDotNet.Client.Tests.Json.Serialization
{
    public class ApiUrlParameterOptionConverterTests
    {
        [Theory]
        [InlineData(typeof(ApiUrlParameterOption.Var), true)]
        [InlineData(typeof(ApiUrlParameterOption.Const), true)]
        [InlineData(typeof(Enumeration), false)]
        [InlineData(typeof(object), false)]
        public void CanConvertTests(Type requestedType, bool expectedResult)
        {
            // Arrange
            var target = new ApiUrlParameterOptionConverter();
            
            // Act
            var result = target.CanConvert(requestedType);
                
            // Assert
            Assert.Equal(expectedResult, result);
        }
        
        [Fact]
        public void ReadKnownValuesTests()
        {
            // Arrange
            var json = "{\"className\":\"HA_UrlParameterOption.Const\",\"value\":\"Test\",\"optionName\":\"OptionTest\"}";
            var target = new ApiUrlParameterOptionConverter();
            
            // Act
            ApiUrlParameterOption? result = null;
            var utf8JsonBytes = Encoding.UTF8.GetBytes(json);
            var reader = new Utf8JsonReader(utf8JsonBytes, true, new JsonReaderState());
            while (reader.Read())
            {
                result = target.Read(ref reader, typeof(ApiUrlParameterOption), new JsonSerializerOptions());
            }
                
            // Assert
            Assert.IsType<ApiUrlParameterOption.Const>(result);
            
            var constResult = result as ApiUrlParameterOption.Const;
            Assert.Equal("Test", constResult?.Value);
            Assert.Equal("OptionTest", constResult?.OptionName);
        }
        
        [Fact]
        public void WriteTests()
        {
            // Arrange
            var input = new ApiUrlParameterOption.Const
            {
                Value = "Test",
                OptionName = "OptionTest"
            };
            var target = new ApiUrlParameterOptionConverter();
            
            // Act
            using var memoryStream = new MemoryStream();
            var writer = new Utf8JsonWriter(memoryStream);
            target.Write(writer, input, new JsonSerializerOptions());
            writer.Flush();
            memoryStream.Position = 0;
                
            using var reader = new StreamReader(memoryStream);
            var result = reader.ReadToEnd();
            
            // Assert
            Assert.Equal("{\"value\":\"Test\",\"className\":\"HA_UrlParameterOption.Const\",\"optionName\":\"OptionTest\",\"deprecation\":null}", result);
        }
    }
}