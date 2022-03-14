using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using JetBrains.Space.Client;
using JetBrains.Space.Common.RetryPolicies;
using JetBrains.Space.Common.Types;
using JetBrains.Space.Common.Utilities;

namespace JetBrains.Space.Common;

/// <summary>
/// A class which represents a connection against a Space organization and uses a bearer token to authenticate.
/// </summary>
[PublicAPI]
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
    /// The <see cref="IResourceRetryPolicy"/> to use when retrying operations.
    /// Defaults to an instance of <see cref="RateLimitedResourceRetryPolicy"/>.
    /// </summary>
    public IResourceRetryPolicy ResourceRetryPolicy { get; set; }

    /// <summary>
    /// Creates an instance of the <see cref="BearerTokenConnection" /> class.
    /// </summary>
    /// <param name="serverUrl">Space organization URL that will be connected against.</param>
    /// <param name="httpClient">HTTP client to use for communication.</param>
    protected BearerTokenConnection(Uri serverUrl, HttpClient? httpClient = null)
        : base(serverUrl)
    {
        HttpClient = httpClient ?? SharedHttpClient.Instance;
        ResourceRetryPolicy = RateLimitedResourceRetryPolicy.Instance;
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
        HttpClient = httpClient ?? SharedHttpClient.Instance;
        ResourceRetryPolicy = RateLimitedResourceRetryPolicy.Instance;
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
        }.WithClientAndSdkHeaders(SdkInfo.Version);
            
        await SendRequestAsync(request, cancellationToken);
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
        }.WithClientAndSdkHeaders(SdkInfo.Version);
            
        var response = await SendRequestAsync(request, cancellationToken);

#if NET6_0_OR_GREATER
            return (await JsonSerializer.DeserializeAsync<TResult>(
                await response.Content.ReadAsStreamAsync(cancellationToken), JsonSerializerOptions, cancellationToken))!;
#else
        return (await JsonSerializer.DeserializeAsync<TResult>(
            await response.Content.ReadAsStreamAsync(), JsonSerializerOptions, cancellationToken))!;
#endif
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
        }.WithClientAndSdkHeaders(SdkInfo.Version);
            
        await SendRequestAsync(request, cancellationToken);
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
        }.WithClientAndSdkHeaders(SdkInfo.Version);
            
        var response = await SendRequestAsync(request, cancellationToken);
            
#if NET6_0_OR_GREATER
            return (await JsonSerializer.DeserializeAsync<TResult>(
                await response.Content.ReadAsStreamAsync(cancellationToken), JsonSerializerOptions, cancellationToken))!;
#else
        return (await JsonSerializer.DeserializeAsync<TResult>(
            await response.Content.ReadAsStreamAsync(), JsonSerializerOptions, cancellationToken))!;
#endif
    }

    /// <inheritdoc />
    protected override async Task<SpaceBlob> RequestBlobResourceInternalAsync(string httpMethod, string urlPath, CancellationToken cancellationToken)
    {
        var request = new HttpRequestMessage(new HttpMethod(httpMethod), ServerUrl + urlPath)
            .WithClientAndSdkHeaders(SdkInfo.Version);
            
        var response = await SendRequestAsync(request, cancellationToken);

        return new SpaceBlob
        {
            Etag = response.Headers.ETag?.ToString(),
            LastModified = response.Content.Headers.LastModified?.ToString(),
            ContentType = response.Content.Headers.ContentType?.ToString(),
            ContentLength = response.Content.Headers.ContentLength,
            ContentDisposition = response.Content.Headers.ContentDisposition?.ToString(),
            ContentEncoding = response.Content.Headers.ContentEncoding.ToString(),
            ContentLanguage = response.Content.Headers.ContentLanguage.ToString(),
#if NET6_0_OR_GREATER
                Stream = await response.Content.ReadAsStreamAsync(cancellationToken)
#else
            Stream = await response.Content.ReadAsStreamAsync()
#endif
        };
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

    /// <summary>
    /// Sends an HTTP request as an asynchronous operation.
    /// </summary>
    /// <param name="request">The <see cref="HttpRequestMessage"/> to send.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <returns>A <see cref="Task"/> that represents the HTTP response.</returns>
    /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
    protected virtual async Task<HttpResponseMessage> SendRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        return await ResourceRetryPolicy.ExecuteAsync(async () =>
        {
            await EnsureAuthenticatedAsync(request, cancellationToken);

            var response = await HttpClient.SendAsync(request, cancellationToken);
            if (!response.IsSuccessStatusCode)
            {
                var exception = await BuildException(response);
                throw exception;
            }

            return response;
        }, cancellationToken);
    }
        
    /// <summary>
    /// Build a <see cref="ResourceException"/> from a <see cref="HttpResponseMessage"/>.
    /// </summary>
    /// <param name="response">The <see cref="HttpResponseMessage"/> to build a <see cref="ResourceException"/> from.</param>
    /// <returns>The <see cref="ResourceException"/>, matching lal characteristics of the <see cref="HttpResponseMessage"/> body.</returns>
    protected static async Task<ResourceException> BuildException(HttpResponseMessage response)
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
            exception = spaceError.Error switch
            {
                ErrorCodes.ValidationError => new ValidationException(spaceError.Description, response.StatusCode, response.ReasonPhrase),
                ErrorCodes.AuthenticationRequired => !string.IsNullOrEmpty(spaceError.Description) && spaceError.Description.Equals("Refresh token associated with the access token is revoked", StringComparison.InvariantCulture)
                    ? new RefreshTokenRevokedException(spaceError.Description, response.StatusCode, response.ReasonPhrase)
                    : new AuthenticationRequiredException(spaceError.Description, response.StatusCode, response.ReasonPhrase),
                ErrorCodes.PermissionDenied => new PermissionDeniedException(spaceError.Description, response.StatusCode, response.ReasonPhrase),
                ErrorCodes.DuplicatedEntity => new DuplicatedEntityException(spaceError.Description, response.StatusCode, response.ReasonPhrase),
                ErrorCodes.RequestError => new ResourceException(spaceError.Description, response.StatusCode, response.ReasonPhrase),
                ErrorCodes.NotFound => new NotFoundException(spaceError.Description, response.StatusCode, response.ReasonPhrase),
                ErrorCodes.RateLimited => new RateLimitedException(spaceError.Description, response.StatusCode, response.ReasonPhrase),
                ErrorCodes.PayloadTooLarge => new PayloadTooLargeException(spaceError.Description, response.StatusCode, response.ReasonPhrase),
                ErrorCodes.InternalServerError => new InternalServerErrorException(spaceError.Description, response.StatusCode, response.ReasonPhrase),
                _ => exception
            };
        }
        else
        {
            exception = response.StatusCode switch
            {
                HttpStatusCode.BadRequest => new ResourceException("Bad Request", response.StatusCode, response.ReasonPhrase),
                HttpStatusCode.Unauthorized => new AuthenticationRequiredException("Unauthorized", response.StatusCode, response.ReasonPhrase),
                HttpStatusCode.Forbidden => new PermissionDeniedException("Forbidden", response.StatusCode, response.ReasonPhrase),
                HttpStatusCode.NotFound => new NotFoundException("Not Found", response.StatusCode, response.ReasonPhrase),
                HttpStatusCode.TooManyRequests => new RateLimitedException("Too Many Requests", response.StatusCode, response.ReasonPhrase),
                HttpStatusCode.RequestEntityTooLarge => new PayloadTooLargeException("Bad Request", response.StatusCode, response.ReasonPhrase),
                HttpStatusCode.RequestHeaderFieldsTooLarge => new PayloadTooLargeException("Bad Request", response.StatusCode, response.ReasonPhrase),
                HttpStatusCode.InternalServerError => new InternalServerErrorException("Internal Server Error", response.StatusCode, response.ReasonPhrase),
                _ => exception
            };
        }

        exception ??= new ResourceException(
            "An error occurred while accessing the resource.",
            response.StatusCode,
            response.ReasonPhrase);
            
        exception.Error = spaceError;
            
        return exception;
    }
}