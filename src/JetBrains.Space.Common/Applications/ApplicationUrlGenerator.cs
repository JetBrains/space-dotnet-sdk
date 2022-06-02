using System;
using System.Linq;
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
    /// <param name="authCodeFlow">Enables the authentication code for the application.</param>
    /// <param name="authForMessagesFromSpace">Authentication for messages sent by Space to the application. Recommended value is <see cref="AuthForMessagesFromSpace.PublicKeySignature"/>.
    /// The <see cref="AuthForMessagesFromSpace.PublicKeySignature"/> is the default one and is not appended to URL parameters.</param>
    /// <returns>A URL for installing an app to a particular Space organization.</returns>
    public static Uri GenerateInstallUrl(
        Uri serverUrl, 
        string applicationName, 
        Uri applicationEndpoint, 
        string? state = null,
        SpaceAuthorizationCodeFlow? authCodeFlow = null,
        AuthForMessagesFromSpace authForMessagesFromSpace = AuthForMessagesFromSpace.PublicKeySignature)
    {
        var builder = new UriBuilder(serverUrl);
        builder.Path = builder.Path.TrimStart('/') + "/extensions/installedApplications/new";
        builder.Query += $"name={Uri.EscapeDataString(applicationName)}";
        builder.Query += $"&pair=true";
        builder.Query += $"&endpoint={Uri.EscapeDataString(applicationEndpoint.AbsoluteUri)}";
        
        if (authCodeFlow != null)
        {
            builder.Query += "&code-flow-enabled=true";
            builder.Query += "&code-flow-redirect-uris=" + string.Join("%0A", authCodeFlow.RedirectUris.Select(it => Uri.EscapeDataString(it.ToString())));
       
            if (authCodeFlow.PkceRequired)
            {
                builder.Query += "&pkce-required=true";
            }
        }

        if (!string.IsNullOrEmpty(state))
        {
            builder.Query += $"&state={Uri.EscapeDataString(state)}";
        }
        
        if (authForMessagesFromSpace == AuthForMessagesFromSpace.SigningKey)
        {
            builder.Query += "&has-signing-key=true";
        }

        return builder.Uri;
    }
}