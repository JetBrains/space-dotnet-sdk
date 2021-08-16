using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using JetBrains.Space.Common.Json.Serialization;

namespace JetBrains.Space.Common
{
    /// <summary>
    /// A class which represents a connection against a Space organization and uses the Refresh Token flow.
    /// </summary>
    [PublicAPI]
    public class RefreshTokenConnection 
        : BearerTokenConnection
    {
        private readonly string _clientId;
        private readonly string _clientSecret;

        /// <summary>
        /// Creates an instance of the <see cref="RefreshTokenConnection" /> class.
        /// </summary>
        /// <param name="serverUrl">Space organization URL that will be connected against.</param>
        /// <param name="clientId">The client id to use when refreshing tokens.</param>
        /// <param name="clientSecret">The client secret to use when refreshing tokens.</param>
        /// <param name="authenticationTokens">Authentication tokens to use while authenticating.</param>
        /// <param name="httpClient">HTTP client to use for communication.</param>
        public RefreshTokenConnection(Uri serverUrl, string clientId, string clientSecret, AuthenticationTokens authenticationTokens, HttpClient? httpClient = null)
            : base(serverUrl, authenticationTokens, httpClient)
        {
            if (string.IsNullOrEmpty(authenticationTokens.RefreshToken))
            {
                throw new ArgumentException("The authentication tokens do not contain a valid refresh token. Make sure the refresh token is not null or an empty string.", nameof(authenticationTokens));
            }
            
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        /// <summary>
        /// Gets the list of permissions to request. Defaults to "**".
        /// </summary>
        // ReSharper disable once MemberCanBePrivate.Global
        public ICollection<string> Scope { get; } = new HashSet<string> { "**" };

        /// <inheritdoc />
        protected override async Task EnsureAuthenticatedAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Authenticate?
            if (AuthenticationTokens != null && AuthenticationTokens.HasExpired() && !string.IsNullOrEmpty(AuthenticationTokens.RefreshToken))
            {
                // Get new token
                var spaceTokenRequest = new HttpRequestMessage(HttpMethod.Post, ServerUrl + "oauth/token")
                {
                    Headers =
                    {
                        Authorization = AuthenticationHeaderValue.Parse(
                            "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_clientId}:{_clientSecret}")))
                    },
                    Content = new FormUrlEncodedContent(new []
                    {
                        new KeyValuePair<string?, string?>("grant_type", "refresh_token"),
                        new KeyValuePair<string?, string?>("refresh_token", AuthenticationTokens.RefreshToken),
                        new KeyValuePair<string?, string?>("scope", string.Join(" ", Scope))
                    })
                };

                var spaceTokenResponse = await HttpClient.SendAsync(spaceTokenRequest, cancellationToken);
                if (!spaceTokenResponse.IsSuccessStatusCode)
                {
                    var exception = await BuildException(spaceTokenResponse);
                    throw exception;
                }
                
                // Parse new access/refresh token
                using var spaceTokenDocument = await JsonDocument.ParseAsync(await spaceTokenResponse.Content.ReadAsStreamAsync(), cancellationToken: cancellationToken);
                var spaceToken = spaceTokenDocument.RootElement;
                
                AuthenticationTokens = new AuthenticationTokens(
                    accessToken: spaceToken.GetStringValue("access_token"),
                    refreshToken: spaceToken.GetStringValue("refresh_token") ?? AuthenticationTokens.RefreshToken,
                    expires: DateTimeOffset.UtcNow.AddSeconds(spaceToken.GetInt32Value("expires_in"))
                );
            }

            await base.EnsureAuthenticatedAsync(request, cancellationToken);
        }
    }
}