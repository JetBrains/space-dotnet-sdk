using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpaceDotNet.Client
{
    /// <summary>
    /// A class that represents a connection against a Space organization and provides an authenticated
    /// <see cref="T:System.Net.Http.HttpClient" /> that uses a bearer token retrieved using the Client Credentials flow.
    /// </summary>
    public class ClientCredentialsConnection 
        : Connection
    {
        private readonly HttpClient _httpClient;
        private OAuthToken? _authToken;
        
        private readonly string _clientId;
        private readonly string _clientSecret;

        /// <summary>
        /// Creates an instance of the <see cref="ClientCredentialsConnection" /> class.
        /// </summary>
        /// <param name="serverUrl">Space organization URL that will be connected against.</param>
        /// <param name="clientId">The client id to use while authenticating.</param>
        /// <param name="clientSecret">The client secret to use while authenticating.</param>
        /// <param name="httpClient">HTTP client to use for communication.</param>
        /// <exception cref="ArgumentException">
        /// The <paramref name="serverUrl" /> was null, empty or did not represent a valid, absolute <see cref="T:System.Uri" />.
        /// </exception>
        public ClientCredentialsConnection(string serverUrl, string clientId, string clientSecret, HttpClient? httpClient = null)
            : base(serverUrl)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _httpClient = httpClient ?? new HttpClient();
        }

        /// <inheritdoc />
        public override async Task RequestResourceAsync(string httpMethod, string urlPath)
        {
            await EnsureAuthenticatedAsync();
            
            var request = new HttpRequestMessage(HttpMethod.Get, ServerUri + urlPath)
            {
                Headers =
                {
                    Authorization = AuthenticationHeaderValue.Parse("Bearer " + _authToken.AccessToken),
                    Accept = { MediaTypeWithQualityHeaderValue.Parse("application/json") }
                }
            };

            var response = await _httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                var exception = new ResourceException("An error occurred while retrieving the resource.", response.StatusCode, response.ReasonPhrase);
                
                try
                {
                    exception.Error = JsonConvert.DeserializeObject<SpaceError>(await response.Content.ReadAsStringAsync());
                }
                catch (JsonException )
                {
                    // Intentional.
                }
                
                throw exception;
            }
        }

        /// <inheritdoc />
        public override async Task<TResult> RequestResourceAsync<TResult>(string httpMethod, string urlPath)
        {
            await EnsureAuthenticatedAsync();
            
            var request = new HttpRequestMessage(HttpMethod.Get, ServerUri + urlPath)
            {
                Headers =
                {
                    Authorization = AuthenticationHeaderValue.Parse("Bearer " + _authToken.AccessToken),
                    Accept = { MediaTypeWithQualityHeaderValue.Parse("application/json") }
                }
            };

            var response = await _httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                var exception = new ResourceException("An error occurred while retrieving the resource.", response.StatusCode, response.ReasonPhrase);
                
                try
                {
                    exception.Error = JsonConvert.DeserializeObject<SpaceError>(await response.Content.ReadAsStringAsync());
                }
                catch (JsonException )
                {
                    // Intentional.
                }
                
                throw exception;
            }
            
            return JsonConvert.DeserializeObject<TResult>(await response.Content.ReadAsStringAsync());
        }

        /// <inheritdoc />
        public override async Task RequestResourceAsync<TPayload>(string httpMethod, string urlPath, TPayload payload)
        {
            await EnsureAuthenticatedAsync();
            
            var request = new HttpRequestMessage(HttpMethod.Get, ServerUri + urlPath)
            {
                Headers =
                {
                    Authorization = AuthenticationHeaderValue.Parse("Bearer " + _authToken.AccessToken),
                    Accept = { MediaTypeWithQualityHeaderValue.Parse("application/json") }
                },
                Content = new StringContent(JsonConvert.SerializeObject(payload, Formatting.None), Encoding.UTF8, "application/json")
            };

            var response = await _httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                var exception = new ResourceException("An error occurred while retrieving the resource.", response.StatusCode, response.ReasonPhrase);
                
                try
                {
                    exception.Error = JsonConvert.DeserializeObject<SpaceError>(await response.Content.ReadAsStringAsync());
                }
                catch (JsonException )
                {
                    // Intentional.
                }
                
                throw exception;
            }
        }
        
        /// <inheritdoc />
        public override async Task<TResult> RequestResourceAsync<TPayload, TResult>(string httpMethod, string urlPath, TPayload payload)
        {
            await EnsureAuthenticatedAsync();
            
            var request = new HttpRequestMessage(HttpMethod.Get, ServerUri + urlPath)
            {
                Headers =
                {
                    Authorization = AuthenticationHeaderValue.Parse("Bearer " + _authToken.AccessToken),
                    Accept = { MediaTypeWithQualityHeaderValue.Parse("application/json") }
                },
                Content = new StringContent(JsonConvert.SerializeObject(payload, Formatting.None), Encoding.UTF8, "application/json")
            };

            var response = await _httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                var exception = new ResourceException("An error occurred while retrieving the resource.", response.StatusCode, response.ReasonPhrase);
                
                try
                {
                    exception.Error = JsonConvert.DeserializeObject<SpaceError>(await response.Content.ReadAsStringAsync());
                }
                catch (JsonException )
                {
                    // Intentional.
                }
                
                throw exception;
            }
            
            return JsonConvert.DeserializeObject<TResult>(await response.Content.ReadAsStringAsync());
        }

        protected async Task EnsureAuthenticatedAsync()
        {
            // Authenticate?
            if (_authToken == null || _authToken.HasExpired())
            {
                // Get new token
                var spaceTokenRequest = new HttpRequestMessage(HttpMethod.Post, ServerUri + "oauth/token")
                {
                    Headers =
                    {
                        Authorization = AuthenticationHeaderValue.Parse(
                            "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_clientId}:{_clientSecret}")))
                    },
                    Content = new FormUrlEncodedContent(new []
                    {
                        new KeyValuePair<string, string>("grant_type", "client_credentials"),
                        new KeyValuePair<string, string>("scope", "**")
                    })
                };

                var spaceTokenResponse = await _httpClient.SendAsync(spaceTokenRequest);
                var spaceToken = JObject.Parse(await spaceTokenResponse.Content.ReadAsStringAsync());

                _authToken = new OAuthToken
                {
                    AccessToken = spaceToken.Value<string>("access_token"),
                    RefreshToken = spaceToken.Value<string>("refresh_token"),
                    Expires = DateTimeOffset.UtcNow.AddSeconds(spaceToken.Value<int>("expires_in"))
                };
            }
        }
    }
}