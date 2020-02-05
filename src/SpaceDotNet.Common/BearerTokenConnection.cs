using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Common
{
    /// <summary>
    /// A class which represents a connection against a Space organization and uses a bearer token to authenticate.
    /// </summary>
    public class BearerTokenConnection 
        : Connection
    {
        protected readonly HttpClient HttpClient;
        public AuthenticationTokens? AuthenticationTokens { get; protected set; }

        /// <summary>
        /// Creates an instance of the <see cref="BearerTokenConnection" /> class.
        /// </summary>
        /// <param name="serverUrl">Space organization URL that will be connected against.</param>
        /// <param name="httpClient">HTTP client to use for communication.</param>
        /// <exception cref="ArgumentException">
        /// The <paramref name="serverUrl" /> was null, empty or did not represent a valid, absolute <see cref="T:System.Uri" />.
        /// </exception>
        protected BearerTokenConnection(string serverUrl, HttpClient? httpClient = null)
            : base(serverUrl)
        {
            HttpClient = httpClient ?? new HttpClient();
        }

        /// <summary>
        /// Creates an instance of the <see cref="BearerTokenConnection" /> class.
        /// </summary>
        /// <param name="serverUrl">Space organization URL that will be connected against.</param>
        /// <param name="authenticationTokens">Authentication tokens to use.</param>
        /// <param name="httpClient">HTTP client to use for communication.</param>
        /// <exception cref="ArgumentException">
        /// The <paramref name="serverUrl" /> was null, empty or did not represent a valid, absolute <see cref="T:System.Uri" />.
        /// </exception>
        public BearerTokenConnection(string serverUrl, AuthenticationTokens authenticationTokens, HttpClient? httpClient = null)
            : base(serverUrl)
        {
            AuthenticationTokens = authenticationTokens;
            HttpClient = httpClient ?? new HttpClient();
        }

        protected override async Task RequestResourceInternalAsync(string httpMethod, string urlPath)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, ServerUrl + urlPath)
            {
                Headers =
                {
                    Accept = { MediaTypeWithQualityHeaderValue.Parse("application/json") }
                }
            };
            
            await EnsureAuthenticatedAsync(request);

            var response = await HttpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                var exception = new ResourceException("An error occurred while retrieving the resource.", response.StatusCode, response.ReasonPhrase);
                
                try
                {
                    exception.Error = await JsonSerializer.DeserializeAsync<SpaceError>(await response.Content.ReadAsStreamAsync());
                }
                catch (JsonException)
                {
                    // Intentional.
                }
                
                throw exception;
            }
        }

        protected override async Task<TResult> RequestResourceInternalAsync<TResult>(string httpMethod, string urlPath)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, ServerUrl + urlPath)
            {
                Headers =
                {
                    Accept = { MediaTypeWithQualityHeaderValue.Parse("application/json") }
                }
            };
            
            await EnsureAuthenticatedAsync(request);

            var response = await HttpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                var exception = new ResourceException("An error occurred while retrieving the resource.", response.StatusCode, response.ReasonPhrase);
                
                try
                {
                    exception.Error = await JsonSerializer.DeserializeAsync<SpaceError>(await response.Content.ReadAsStreamAsync());
                }
                catch (JsonException)
                {
                    // Intentional.
                }
                
                throw exception;
            }
            
            return await JsonSerializer.DeserializeAsync<TResult>(await response.Content.ReadAsStreamAsync());
        }

        protected override async Task RequestResourceInternalAsync<TPayload>(string httpMethod, string urlPath, TPayload payload)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, ServerUrl + urlPath)
            {
                Headers =
                {
                    Accept = { MediaTypeWithQualityHeaderValue.Parse("application/json") }
                },
                Content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json")
            };
            
            await EnsureAuthenticatedAsync(request);

            var response = await HttpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                var exception = new ResourceException("An error occurred while retrieving the resource.", response.StatusCode, response.ReasonPhrase);
                
                try
                {
                    exception.Error = await JsonSerializer.DeserializeAsync<SpaceError>(await response.Content.ReadAsStreamAsync());
                }
                catch (JsonException)
                {
                    // Intentional.
                }
                
                throw exception;
            }
        }
        
        protected override async Task<TResult> RequestResourceInternalAsync<TPayload, TResult>(string httpMethod, string urlPath, TPayload payload)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, ServerUrl + urlPath)
            {
                Headers =
                {
                    Accept = { MediaTypeWithQualityHeaderValue.Parse("application/json") }
                },
                Content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json")
            };
            
            await EnsureAuthenticatedAsync(request);

            var response = await HttpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                var exception = new ResourceException("An error occurred while retrieving the resource.", response.StatusCode, response.ReasonPhrase);
                
                try
                {
                    exception.Error = await JsonSerializer.DeserializeAsync<SpaceError>(await response.Content.ReadAsStreamAsync());
                }
                catch (JsonException)
                {
                    // Intentional.
                }
                
                throw exception;
            }
            
            return await JsonSerializer.DeserializeAsync<TResult>(await response.Content.ReadAsStreamAsync());
        }
        
        protected virtual Task EnsureAuthenticatedAsync(HttpRequestMessage request)
        {
            if (AuthenticationTokens != null && !AuthenticationTokens.HasExpired())
            {
                request.Headers.Authorization = AuthenticationHeaderValue.Parse("Bearer " + AuthenticationTokens.AccessToken);
            }

            return Task.CompletedTask;
        }
    }
}