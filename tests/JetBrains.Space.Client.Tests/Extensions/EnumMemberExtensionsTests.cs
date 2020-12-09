using System.Runtime.Serialization;
using JetBrains.Space.Common.Types;
using Xunit;

namespace JetBrains.Space.Client.Tests.Extensions
{
    public class EnumMemberExtensionsTests
    {
        [Theory]
        [InlineData(TestEnum.Plain, "Plain")]
        [InlineData(TestEnum.WithEnumMember, "with-enum-member")]
        [InlineData(null, "null")]
        public void ToEnumStringReturnsExpectedResult(TestEnum? target, string expected)
        {
            // Act
            var result = target.ToEnumString();

            // Assert
            Assert.Equal(expected, result);
        }
        
        public enum TestEnum
        {
            [EnumMember(Value = "with-enum-member")]
            WithEnumMember, 
            
            Plain
        }
    }
}