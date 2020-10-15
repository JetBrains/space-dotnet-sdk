using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
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
        /// <summary>
        /// The <see cref="HttpClient"/> to communicate with a Space organization.
        /// </summary>
        protected readonly HttpClient HttpClient;
        
        /// <summary>
        /// The <see cref="AuthenticationTokens"/> required to communicate with a Space organization.
        /// </summary>
        public AuthenticationTokens? AuthenticationTokens { get; protected set; }

        /// <summary>
        /// Creates an instance of the <see cref="BearerTokenConnection" /> class.
        /// </summary>
        /// <param name="serverUrl">Space organization URL that will be connected against.</param>
        /// <param name="httpClient">HTTP client to use for communication.</param>
        protected BearerTokenConnection(Uri serverUrl, HttpClient? httpClient = null)
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
        public BearerTokenConnection(Uri serverUrl, AuthenticationTokens authenticationTokens, HttpClient? httpClient = null)
            : base(serverUrl)
        {
            AuthenticationTokens = authenticationTokens;
            HttpClient = httpClient ?? new HttpClient();
        }

        /// <inheritdoc />
        protected override async Task RequestResourceInternalAsync(string httpMethod, string urlPath, CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage(new HttpMethod(httpMethod), ServerUrl + urlPath)
            {
                Headers =
                {
                    Accept = { MediaTypeWithQualityHeaderValue.Parse("application/json") }
                }
            };
            
            await EnsureAuthenticatedAsync(request, cancellationToken);

            var response = await HttpClient.SendAsync(request, cancellationToken);
            if (!response.IsSuccessStatusCode)
            {
                var exception = await BuildException(response);
                throw exception;
            }
        }

        /// <inheritdoc />
        protected override async Task<TResult> RequestResourceInternalAsync<TResult>(string httpMethod, string urlPath, CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage(new HttpMethod(httpMethod), ServerUrl + urlPath)
            {
                Headers =
                {
                    Accept = { MediaTypeWithQualityHeaderValue.Parse("application/json") }
                }
            };
            
            await EnsureAuthenticatedAsync(request, cancellationToken);

            var response = await HttpClient.SendAsync(request, cancellationToken);
            if (!response.IsSuccessStatusCode)
            {
                var exception = await BuildException(response);
                throw exception;
            }
            
            return await JsonSerializer.DeserializeAsync<TResult>(await response.Content.ReadAsStreamAsync(), JsonSerializerOptions, cancellationToken);
        }

        /// <inheritdoc />
        protected override async Task RequestResourceInternalAsync<TPayload>(string httpMethod, string urlPath, TPayload payload, CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage(new HttpMethod(httpMethod), ServerUrl + urlPath)
            {
                Headers =
                {
                    Accept = { MediaTypeWithQualityHeaderValue.Parse("application/json") }
                },
                Content = new StringContent(JsonSerializer.Serialize(payload, JsonSerializerOptions), Encoding.UTF8, "application/json")
            };
            
            await EnsureAuthenticatedAsync(request, cancellationToken);

            var response = await HttpClient.SendAsync(request, cancellationToken);
            if (!response.IsSuccessStatusCode)
            {
                var exception = await BuildException(response);
                throw exception;
            }
        }
        
        /// <inheritdoc />
        protected override async Task<TResult> RequestResourceInternalAsync<TPayload, TResult>(string httpMethod, string urlPath, TPayload payload, CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage(new HttpMethod(httpMethod), ServerUrl + urlPath)
            {
                Headers =
                {
                    Accept = { MediaTypeWithQualityHeaderValue.Parse("application/json") }
                },
                Content = new StringContent(JsonSerializer.Serialize(payload, JsonSerializerOptions), Encoding.UTF8, "application/json")
            };
            
            await EnsureAuthenticatedAsync(request, cancellationToken);

            var response = await HttpClient.SendAsync(request, cancellationToken);
            if (!response.IsSuccessStatusCode)
            {
                var exception = await BuildException(response);
                throw exception;
            }
            
            return await JsonSerializer.DeserializeAsync<TResult>(await response.Content.ReadAsStreamAsync(), JsonSerializerOptions, cancellationToken);
        }
        
        /// <summary>
        /// Ensure the request is authenticated, if needed.
        /// Can be used in derived classes to update authorization headers to communicate with the Space organization.
        /// </summary>
        /// <param name="request">The <see cref="HttpRequestMessage"/> to authenticate.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> that can be used to cancel the operation.</param>
        /// <returns>A <see cref="Task"/> that represents the current operation.</returns>
        protected virtual Task EnsureAuthenticatedAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (AuthenticationTokens != null && !AuthenticationTokens.HasExpired())
            {
                request.Headers.Authorization = AuthenticationHeaderValue.Parse("Bearer " + AuthenticationTokens.AccessToken);
            }

            return Task.CompletedTask;
        }
        
        private static async Task<ResourceException> BuildException(HttpResponseMessage response)
        {
            // 1. Determine Space error
            SpaceError? spaceError = null;
            try
            {
                spaceError = await JsonSerializer.DeserializeAsync<SpaceError>(await response.Content.ReadAsStreamAsync(), JsonSerializerOptions);
            }
            catch (JsonException)
            {
                // Intentional.
            }
            
            // 2. Build Exception
            ResourceException? exception = null;
            if (spaceError != null)
            {
                switch (spaceError.Error)
                {
                    case ErrorCodes.ValidationError: 
                        exception = new ValidationException(spaceError.Description, response.StatusCode, response.ReasonPhrase);
                        break;
                    case ErrorCodes.AuthenticationRequired: 
                        exception = new AuthenticationRequiredException(spaceError.Description, response.StatusCode, response.ReasonPhrase);
                        break;
                    case ErrorCodes.PermissionDenied: 
                        exception = new PermissionDeniedException(spaceError.Description, response.StatusCode, response.ReasonPhrase);
                        break;
                    case ErrorCodes.DuplicatedEntity: 
                        exception = new DuplicatedEntityException(spaceError.Description, response.StatusCode, response.ReasonPhrase);
                        break;
                    case ErrorCodes.RequestError: 
                        exception = new ResourceException(spaceError.Description, response.StatusCode, response.ReasonPhrase);
                        break;
                    case ErrorCodes.NotFound: 
                        exception = new NotFoundException(spaceError.Description, response.StatusCode, response.ReasonPhrase);
                        break;
                    case ErrorCodes.RateLimited: 
                        exception = new RateLimitedException(spaceError.Description, response.StatusCode, response.ReasonPhrase);
                        break;
                    case ErrorCodes.PayloadTooLarge: 
                        exception = new PayloadTooLargeException(spaceError.Description, response.StatusCode, response.ReasonPhrase);
                        break;
                    case ErrorCodes.InternalServerError: 
                        exception = new InternalServerErrorException(spaceError.Description, response.StatusCode, response.ReasonPhrase);
                        break;
                }
            }
            else
            {
                switch (response.StatusCode)
                {
                    case HttpStatusCode.BadRequest:
                        exception = new ResourceException("Bad Request", response.StatusCode, response.ReasonPhrase);
                        break;
                    case HttpStatusCode.Unauthorized:
                        exception = new AuthenticationRequiredException("Unauthorized", response.StatusCode, response.ReasonPhrase);
                        break;
                    case HttpStatusCode.Forbidden:
                        exception = new PermissionDeniedException("Forbidden", response.StatusCode, response.ReasonPhrase);
                        break;
                    case HttpStatusCode.NotFound:
                        exception = new NotFoundException("Not Found", response.StatusCode, response.ReasonPhrase);
                        break;
                    case HttpStatusCode.TooManyRequests:
                        exception = new RateLimitedException("Too Many Requests", response.StatusCode, response.ReasonPhrase);
                        break;
                    case HttpStatusCode.RequestEntityTooLarge:
                    case HttpStatusCode.RequestHeaderFieldsTooLarge:
                        exception = new PayloadTooLargeException("Bad Request", response.StatusCode, response.ReasonPhrase);
                        break;
                    case HttpStatusCode.InternalServerError:
                        exception = new InternalServerErrorException("Internal Server Error", response.StatusCode, response.ReasonPhrase);
                        break;
                }
            }

            if (exception == null)
            {
                exception = new ResourceException("An error occurred while accessing the resource.", response.StatusCode, response.ReasonPhrase);
            }
            
            exception.Error = spaceError;
            
            return exception;
        }
    }
}