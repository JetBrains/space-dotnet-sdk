using System;
using System.Text.Json;
using SpaceDotNet.Common.Json.Serialization;
using Xunit;

namespace SpaceDotNet.Client.Tests.Json.Serialization
{
    public class SpaceDateConverterTests
    {
        private JsonSerializerOptions CreateSerializerOptions()
        {
            var options = new JsonSerializerOptions
            {
                MaxDepth = 32,
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            options.Converters.Add(new SpaceDateConverter());
            
            return options;
        }

        [Fact]
        public void CanDeserializeDateTime()
        {
            var inputJsonString = "{\"iso\":\"2020-10-21\",\"timestamp\":1603297800000}";

            var result = (DateTime)JsonSerializer.Deserialize(inputJsonString, typeof(DateTime), CreateSerializerOptions());

            Assert.Equal("2020-10-21", result.ToString("yyyy-MM-dd"));
        }

        [Fact]
        public void CanDeserializeNullableDateTime()
        {
            var inputJsonString = "{\"iso\":\"2020-10-21\",\"timestamp\":1603297800000}";

            var result = (DateTime?)JsonSerializer.Deserialize(inputJsonString, typeof(DateTime?), CreateSerializerOptions());

            Assert.NotNull(result);
            Assert.Equal("2020-10-21", result.Value.ToString("yyyy-MM-dd"));
        }
    }
}