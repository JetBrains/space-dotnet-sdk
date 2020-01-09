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
    /// A class that represents a connection against a Space organization and provides an authenticated
    /// <see cref="T:System.Net.Http.HttpClient" /> that uses a bearer token.
    /// </summary>
    public class BearerTokenConnection 
        : Connection
    {
        protected readonly HttpClient HttpClient;
        protected string BearerToken;

        /// <summary>
        /// Creates an instance of the <see cref="BearerTokenConnection" /> class.
        /// </summary>
        /// <param name="serverUrl">Space organization URL that will be connected against.</param>
        /// <param name="bearerToken">Bearer token to communicate with the server.</param>
        /// <param name="httpClient">HTTP client to use for communication.</param>
        /// <exception cref="ArgumentException">
        /// The <paramref name="serverUrl" /> was null, empty or did not represent a valid, absolute <see cref="T:System.Uri" />.
        /// </exception>
        public BearerTokenConnection(string serverUrl, string bearerToken, HttpClient? httpClient = null)
            : base(serverUrl)
        {
            BearerToken = bearerToken;
            HttpClient = httpClient ?? new HttpClient();
        }

        /// <inheritdoc />
        public override async Task RequestResourceAsync(string httpMethod, string urlPath)
        {
            await EnsureAuthenticatedAsync();
            
            var request = new HttpRequestMessage(HttpMethod.Get, ServerUri + urlPath)
            {
                Headers =
                {
                    Authorization = AuthenticationHeaderValue.Parse("Bearer " + BearerToken),
                    Accept = { MediaTypeWithQualityHeaderValue.Parse("application/json") }
                }
            };

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

        /// <inheritdoc />
        public override async Task<TResult> RequestResourceAsync<TResult>(string httpMethod, string urlPath)
        {
            await EnsureAuthenticatedAsync();
            
            var request = new HttpRequestMessage(HttpMethod.Get, ServerUri + urlPath)
            {
                Headers =
                {
                    Authorization = AuthenticationHeaderValue.Parse("Bearer " + BearerToken),
                    Accept = { MediaTypeWithQualityHeaderValue.Parse("application/json") }
                }
            };

            var response = await HttpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                var exception = new ResourceException("An error occurred while retrieving the resource.", response.StatusCode, response.ReasonPhrase);
                
                try
                {
                    exception.Error = await JsonSerializer.DeserializeAsync<SpaceError>(await response.Content.ReadAsStreamAsync());
                }
                catch (JsonException )
                {
                    // Intentional.
                }
                
                throw exception;
            }
            
            return await JsonSerializer.DeserializeAsync<TResult>(await response.Content.ReadAsStreamAsync());
        }

        /// <inheritdoc />
        public override async Task RequestResourceAsync<TPayload>(string httpMethod, string urlPath, TPayload payload)
        {
            await EnsureAuthenticatedAsync();
            
            var request = new HttpRequestMessage(HttpMethod.Get, ServerUri + urlPath)
            {
                Headers =
                {
                    Authorization = AuthenticationHeaderValue.Parse("Bearer " + BearerToken),
                    Accept = { MediaTypeWithQualityHeaderValue.Parse("application/json") }
                },
                Content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json")
            };

            var response = await HttpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                var exception = new ResourceException("An error occurred while retrieving the resource.", response.StatusCode, response.ReasonPhrase);
                
                try
                {
                    exception.Error = await JsonSerializer.DeserializeAsync<SpaceError>(await response.Content.ReadAsStreamAsync());
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
                    Authorization = AuthenticationHeaderValue.Parse("Bearer " + BearerToken),
                    Accept = { MediaTypeWithQualityHeaderValue.Parse("application/json") }
                },
                Content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json")
            };

            var response = await HttpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                var exception = new ResourceException("An error occurred while retrieving the resource.", response.StatusCode, response.ReasonPhrase);
                
                try
                {
                    exception.Error = await JsonSerializer.DeserializeAsync<SpaceError>(await response.Content.ReadAsStreamAsync());
                }
                catch (JsonException )
                {
                    // Intentional.
                }
                
                throw exception;
            }
            
            return await JsonSerializer.DeserializeAsync<TResult>(await response.Content.ReadAsStreamAsync());
        }
        
        protected virtual Task EnsureAuthenticatedAsync()
        {
            return Task.CompletedTask;
        }
    }
}