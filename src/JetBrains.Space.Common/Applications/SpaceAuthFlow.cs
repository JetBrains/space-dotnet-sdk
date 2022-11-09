using System.Text;
using JetBrains.Annotations;

namespace JetBrains.Space.Common.Applications;

/// <summary>
/// Authentication flow that the application will use to access the Space API.
/// </summary>
[PublicAPI]
public abstract class SpaceAuthFlow
{
    /// <summary>
    /// Client credentials flow.
    /// </summary>
    /// <returns>A <see cref="SpaceAuthFlow"/> instance that represents the client credentials flow.</returns>
    public static SpaceAuthFlow ClientCredentials()
        => new ClientCredentialsAuthFlow();

    /// <summary>
    /// Authorization code flow.
    /// </summary>
    /// <param name="redirectUris">Redirect URI(s) for the application.</param>
    /// <param name="pkceRequired">Is PKCE required? Use <value>true</value> to enable; <value>false</value> otherwise.</param>
    /// <returns>A <see cref="SpaceAuthFlow"/> instance that represents the authorization code flow.</returns>
    public static SpaceAuthFlow AuthorizationCode(IEnumerable<Uri> redirectUris, bool pkceRequired)
        => new AuthorizationCodeAuthFlow(redirectUris, pkceRequired);

    private class ClientCredentialsAuthFlow : SpaceAuthFlow
    {
        public override string ToString()
        {
            return "client-credentials-flow-enabled=true";
        }
    }
    
    private class AuthorizationCodeAuthFlow : SpaceAuthFlow
    {
        private readonly IEnumerable<Uri> _redirectUris;
        private readonly bool _pkceRequired;

        public AuthorizationCodeAuthFlow(IEnumerable<Uri> redirectUris, bool pkceRequired)
        {
            _redirectUris = redirectUris;
            _pkceRequired = pkceRequired;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append("code-flow-enabled=true");
            builder.Append("&code-flow-redirect-uris=" + string.Join("%0A", _redirectUris.Select(it => Uri.EscapeDataString(it.ToString()))));
           
            if (_pkceRequired)
            {
                builder.Append("&pkce-required=true");
            }

            return builder.ToString();
        }
    }
}