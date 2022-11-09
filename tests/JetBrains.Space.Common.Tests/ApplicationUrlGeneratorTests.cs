using JetBrains.Space.Common.Applications;
using Xunit;

namespace JetBrains.Space.Client.Tests;

public class ApplicationUrlGeneratorTests
{
    [Fact]
    public void GenerateInstallUrlTest()
    {
        // Arrange & Act
        var result = ApplicationUrlGenerator.GenerateInstallUrl(
            serverUrl: new Uri("https://my-org.jetbrains.space/"),
            applicationName: "My app",
            applicationEndpoint: new Uri("https://my-server.domain.com/api")
        );
        
        // Assert
        Assert.Equal(
            "https://my-org.jetbrains.space/extensions/installedApplications/new?" +
            "name=My%20app" +
            "&pair=true" +
            "&endpoint=https%3A%2F%2Fmy-server.domain.com%2Fapi" +
            "&client-credentials-flow-enabled=true" +
            "&has-public-key-signature=true",
            result.AbsoluteUri);
    }
    
    [Fact]
    public void GenerateInstallUrlWithAuthFlowsTest()
    {
        // Arrange & Act
        var result = ApplicationUrlGenerator.GenerateInstallUrl(
            serverUrl: new Uri("https://my-org.jetbrains.space/"),
            applicationName: "My app",
            applicationEndpoint: new Uri("https://my-server.domain.com/api"),
            state: "4e617c52-3906-4ad6-ac35-5be3fe66608b",
            authFlows: new []
            {
                SpaceAuthFlow.ClientCredentials(),
                SpaceAuthFlow.AuthorizationCode(
                    redirectUris: new []
                    {
                        new Uri("https://server1.domain.com/redirect-auth1"),
                        new Uri("https://server2.domain.com/redirect-auth2")
                    },
                    pkceRequired: true)
            },
            authForMessagesFromSpace: AuthForMessagesFromSpace.SigningKey
        );
        
        // Assert
        Assert.Equal(
            "https://my-org.jetbrains.space/extensions/installedApplications/new?" +
            "name=My%20app" +
            "&pair=true" +
            "&endpoint=https%3A%2F%2Fmy-server.domain.com%2Fapi" +
            "&client-credentials-flow-enabled=true" +
            "&code-flow-enabled=true" +
            "&code-flow-redirect-uris=https%3A%2F%2Fserver1.domain.com%2Fredirect-auth1%0Ahttps%3A%2F%2Fserver2.domain.com%2Fredirect-auth2" +
            "&pkce-required=true" +
            "&state=4e617c52-3906-4ad6-ac35-5be3fe66608b" +
            "&has-signing-key=true",
            result.AbsoluteUri);
    }
    
    [Fact]
    public void GenerateInstallGenericUrlTest()
    {
        // Arrange & Act
        var result = ApplicationUrlGenerator.GenerateInstallGenericUrl(
            applicationName: "My app",
            applicationEndpoint: new Uri("https://my-server.domain.com/api")
        );
        
        // Assert
        Assert.Equal(
            "https://jetbrains.com/space/app/install-app?" +
            "name=My%20app" +
            "&pair=true" +
            "&endpoint=https%3A%2F%2Fmy-server.domain.com%2Fapi" +
            "&client-credentials-flow-enabled=true" +
            "&has-public-key-signature=true",
            result.AbsoluteUri);
    }
    
    [Fact]
    public void GenerateInstallFromMarketplaceUrlTest()
    {
        // Arrange & Act
        var result = ApplicationUrlGenerator.GenerateInstallFromMarketplaceUrl(
            marketplaceApplicationId: "1234",
            applicationName: "My app"
        );
        
        // Assert
        Assert.Equal(
            "https://jetbrains.com/space/app/install-app?" +
            "marketplace-app=1234" +
            "&name=My%20app",
            result.AbsoluteUri);
    }
}