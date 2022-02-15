using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace JetBrains.Space.Common.Applications;

/// <summary>
/// Utility class to generate URLs.
/// </summary>
[PublicAPI]
public static class ApplicationUrlGenerator
{
    /// <summary>
    /// Creates a URL for installing an app to a particular Space organization.
    /// </summary>
    /// <param name="serverUrl">Space organization URL where the application will be installed, for example: <value>https://my-org.jetbrains.space</value>.</param>
    /// <param name="applicationName">Default application name. Can be changed by users in each Space organization.</param>
    /// <param name="applicationEndpoint">HTTPS url that Space will use to send messages to the application.</param>
    /// <param name="state">A string that will be passed to the application in <see cref="JetBrains.Space.Client.InitPayload"/> when user installs the application. Allows to track the installation process across different systems while user is redirected in the browser.</param>
    /// <param name="authFlows">Authentication flow(s) that the application will use to access the Space API.</param>
    /// <param name="authForMessagesFromSpace">Authentication for messages sent by Space to the application. Recommended value is <see cref="AuthForMessagesFromSpace.PublicKeySignature"/>.</param>
    /// <returns>A URL for installing an app to a particular Space organization.</returns>
    public static Uri GenerateInstallUrl(
        Uri serverUrl, 
        string applicationName, 
        Uri applicationEndpoint, 
        string? state = null,
        IEnumerable<SpaceAuthFlow>? authFlows = null,
        AuthForMessagesFromSpace authForMessagesFromSpace = AuthForMessagesFromSpace.PublicKeySignature)
    {
        authFlows ??= new [] { SpaceAuthFlow.ClientCredentials() };

        var builder = new UriBuilder(serverUrl);
        builder.Path = builder.Path.TrimStart('/') + "/extensions/installedApplications/new";
        builder.Query += $"name={Uri.EscapeDataString(applicationName)}";
        builder.Query += $"&pair=true";
        builder.Query += $"&endpoint={Uri.EscapeDataString(applicationEndpoint.AbsoluteUri)}";
        
        foreach (var authFlow in authFlows)
        {
            builder.Query += $"&{authFlow}";
        }

        if (!string.IsNullOrEmpty(state))
        {
            builder.Query += $"&state={Uri.EscapeDataString(state)}";
        }
        
        switch (authForMessagesFromSpace)
        {
            case AuthForMessagesFromSpace.PublicKeySignature:
                builder.Query += $"&has-public-key-signature=true";
                break;
            case AuthForMessagesFromSpace.SigningKey:
                builder.Query += $"&has-signing-key=true";
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(authForMessagesFromSpace), authForMessagesFromSpace, "Unknown authentication option");
        }

        return builder.Uri;
    }
}