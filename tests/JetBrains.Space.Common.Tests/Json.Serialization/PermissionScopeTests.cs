using System.Text.Json;
using JetBrains.Space.Common;
using Xunit;

namespace JetBrains.Space.Client.Tests.Json.Serialization;

public class PermissionScopeTests
{
    [Fact]
    public void CanSerializePermissionScope()
    {
        var subject = new PermissionScope("this is a test");

        var result = JsonSerializer.Serialize(subject, Defaults.CreateSerializerOptions());

        Assert.NotNull(result);
        Assert.Equal("\"this is a test\"", result);
    }

    [Fact]
    public void CanDeserializePermissionScope()
    {
        var result = JsonSerializer.Deserialize<PermissionScope>("\"this is a test\"", Defaults.CreateSerializerOptions());

        Assert.NotNull(result);
        Assert.IsType<PermissionScope>(result);
        Assert.Equal("this is a test", result.ToString());
    }
}