using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SpaceDotNet.Common.Json.Serialization;

namespace SpaceDotNet.Common
{
    /// <summary>
    /// A class which represents a connection against a Space organization and uses the Refresh Token flow.
    /// </summary>
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
        /// <exception cref="ArgumentException">
        /// The <paramref name="serverUrl" /> was null, empty or did not represent a valid, absolute <see cref="T:System.Uri" />.
        /// </exception>
        public RefreshTokenConnection(string serverUrl, string clientId, string clientSecret, AuthenticationTokens authenticationTokens, HttpClient? httpClient = null)
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
        /// A space separated list of rights required to access specific resources in Space. Defaults to "**".
        /// </summary>
        // ReSharper disable once MemberCanBePrivate.Global
        public string Scope { get; set; } = "**";

        protected override async Task EnsureAuthenticatedAsync(HttpRequestMessage request)
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
                        new KeyValuePair<string, string>("grant_type", "refresh_token"),
                        new KeyValuePair<string, string>("refresh_token", AuthenticationTokens.RefreshToken),
                        new KeyValuePair<string, string>("scope", Scope)
                    })
                };

                var spaceTokenResponse = await HttpClient.SendAsync(spaceTokenRequest);
                using var spaceTokenDocument = await JsonDocument.ParseAsync(await spaceTokenResponse.Content.ReadAsStreamAsync());
                var spaceToken = spaceTokenDocument.RootElement;
                
                AuthenticationTokens = new AuthenticationTokens(
                    accessToken: spaceToken.GetStringValue("access_token"),
                    refreshToken: spaceToken.GetStringValue("refresh_token") ?? AuthenticationTokens.RefreshToken,
                    expires: DateTimeOffset.UtcNow.AddSeconds(spaceToken.GetInt32Value("expires_in"))
                );
            }

            await base.EnsureAuthenticatedAsync(request);
        }
    }
}