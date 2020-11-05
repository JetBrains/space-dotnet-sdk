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
    /// A class which represents a connection against a Space organization and uses the Client Credentials flow.
    /// </summary>
    [PublicAPI]
    public class ClientCredentialsConnection 
        : BearerTokenConnection
    {
        private readonly string _clientId;
        private readonly string _clientSecret;

        /// <summary>
        /// Creates an instance of the <see cref="ClientCredentialsConnection" /> class.
        /// </summary>
        /// <param name="serverUrl">Space organization URL that will be connected against.</param>
        /// <param name="clientId">The client id to use while authenticating.</param>
        /// <param name="clientSecret">The client secret to use while authenticating.</param>
        /// <param name="httpClient">HTTP client to use for communication.</param>
        public ClientCredentialsConnection(Uri serverUrl, string clientId, string clientSecret, HttpClient? httpClient = null)
            : base(serverUrl, httpClient)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        /// <summary>
        /// A space separated list of rights required to access specific resources in Space. Defaults to "**".
        /// </summary>
        // ReSharper disable once MemberCanBePrivate.Global
        public string Scope { get; set; } = "**";

        /// <inheritdoc />
        protected override async Task EnsureAuthenticatedAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Authenticate?
            if (AuthenticationTokens == null || AuthenticationTokens.HasExpired())
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
                        new KeyValuePair<string, string>("grant_type", "client_credentials"),
                        new KeyValuePair<string, string>("scope", Scope)
                    })
                };

                var spaceTokenResponse = await HttpClient.SendAsync(spaceTokenRequest, cancellationToken);
                if (!spaceTokenResponse.IsSuccessStatusCode)
                {
                    throw new ResourceException($"Unable to connect to Space organization. Attempted endpoint was: {ServerUrl + "oauth/token"}",
                        spaceTokenResponse.StatusCode, spaceTokenResponse.ReasonPhrase);
                }
                
                using var spaceTokenDocument = await JsonDocument.ParseAsync(await spaceTokenResponse.Content.ReadAsStreamAsync(), cancellationToken: cancellationToken);
                var spaceToken = spaceTokenDocument.RootElement;
                
                AuthenticationTokens = new AuthenticationTokens(
                    accessToken: spaceToken.GetStringValue("access_token"),
                    refreshToken: spaceToken.GetStringValue("refresh_token") ?? AuthenticationTokens?.RefreshToken,
                    expires: DateTimeOffset.UtcNow.AddSeconds(spaceToken.GetInt32Value("expires_in"))
                );
            }

            await base.EnsureAuthenticatedAsync(request, cancellationToken);
        }
    }
}