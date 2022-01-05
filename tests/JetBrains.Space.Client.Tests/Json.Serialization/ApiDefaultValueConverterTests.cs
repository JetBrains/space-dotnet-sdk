using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using JetBrains.Space.Common.Types;
using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.Model.HttpApi.Converters;
using Xunit;

namespace JetBrains.Space.Client.Tests.Json.Serialization;

public class ApiDefaultValueConverterTests
{
    [Theory]
    [InlineData(typeof(ApiDefaultValue.Const.Primitive), true)]
    [InlineData(typeof(ApiDefaultValue.Const.EnumEntry), true)]
    [InlineData(typeof(ApiDefaultValue.Collection), true)]
    [InlineData(typeof(ApiDefaultValue.Map), true)]
    [InlineData(typeof(ApiDefaultValue.Reference), true)]
    [InlineData(typeof(Enumeration), false)]
    [InlineData(typeof(object), false)]
    public void CanConvertTests(Type requestedType, bool expectedResult)
    {
        // Arrange
        var target = new ApiDefaultValueConverter();
            
        // Act
        var result = target.CanConvert(requestedType);
                
        // Assert
        Assert.Equal(expectedResult, result);
    }
        
    [Fact]
    public void ReadKnownValuesTests()
    {
        // Arrange
        var json = "{\"elements\":[{\"expression\":\"Test\",\"className\":\"HA_DefaultValue.Const.Primitive\"}],\"className\":\"HA_DefaultValue.Collection\"}";
        var target = new ApiDefaultValueConverter();
            
        // Act
        ApiDefaultValue? result = null;
        var utf8JsonBytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(utf8JsonBytes, true, new JsonReaderState());
        while (reader.Read())
        {
            result = target.Read(ref reader, typeof(ApiDefaultValue), new JsonSerializerOptions());
        }
                
        // Assert
        Assert.IsType<ApiDefaultValue.Collection>(result);
            
        var collectionResult = result as ApiDefaultValue.Collection;
        Assert.NotEmpty(collectionResult!.Elements);
            
        var primitiveElement = collectionResult.Elements[0] as ApiDefaultValue.Const.Primitive;
        Assert.Equal("Test", primitiveElement!.Expression);
    }
        
    [Fact]
    public void WriteTests()
    {
        // Arrange
        var input = new ApiDefaultValue.Collection
        {
            Elements = new List<ApiDefaultValue>
            {
                new ApiDefaultValue.Reference { ParameterName = "Test" }
            }
        };
        var target = new ApiDefaultValueConverter();
            
        // Act
        using var memoryStream = new MemoryStream();
        var writer = new Utf8JsonWriter(memoryStream);
        target.Write(writer, input, new JsonSerializerOptions());
        writer.Flush();
        memoryStream.Position = 0;
                
        using var reader = new StreamReader(memoryStream);
        var result = reader.ReadToEnd();
            
        // Assert
        Assert.Equal("{\"elements\":[{\"paramName\":\"Test\",\"className\":\"HA_DefaultValue.Reference\"}],\"className\":\"HA_DefaultValue.Collection\"}", result);
    }
}