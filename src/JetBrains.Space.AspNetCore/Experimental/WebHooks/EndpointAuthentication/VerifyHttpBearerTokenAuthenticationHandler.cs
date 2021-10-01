using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using JetBrains.Space.AspNetCore.Experimental.WebHooks.Options;
using JetBrains.Space.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks.EndpointAuthentication;

/// <summary>
/// Handle Space endpoint authentication with HTTP bearer token authentication header.
/// </summary>
public class VerifyHttpBearerTokenAuthenticationHandler : ISpaceEndpointAuthenticationHandler
{
    private readonly IOptionsSnapshot<SpaceWebHookOptions> _options;
    private readonly ILogger<VerifyHttpBearerTokenAuthenticationHandler> _logger;

    /// <summary>
    /// Creates a new <see cref="VerifyHttpBearerTokenAuthenticationHandler"/>.
    /// </summary>
    /// <param name="options">The <see cref="SpaceWebHookOptions"/> used by the current <see cref="VerifyHttpBearerTokenAuthenticationHandler"/>.</param>
    /// <param name="logger">An <see cref="ILogger{T}"/> used by the current <see cref="VerifyHttpBearerTokenAuthenticationHandler"/>.</param>
    public VerifyHttpBearerTokenAuthenticationHandler(
        IOptionsSnapshot<SpaceWebHookOptions> options,
        ILogger<VerifyHttpBearerTokenAuthenticationHandler> logger)
    {
        _options = options;
        _logger = logger;
    }
        
    /// <inheritdoc />
    public Task<bool> AuthenticateRequestAsync(
        string? optionsName,
        HttpContext context,
        string requestBody,
        ApplicationPayload? payload)
    {
        // Determine options name to use (in case multiple are registered)
        var options = optionsName != null
            ? _options.Get(optionsName)
            : _options.Value;

        var verificationOptions = options.VerifyHttpBearerToken;
        if (verificationOptions is not { IsEnabled: true })
        {
            return Task.FromResult(true);
        }
        if (string.IsNullOrEmpty(verificationOptions.BearerToken))
        {
                
            _logger.LogError("Endpoint request validation failed. " + nameof(SpaceWebHookOptions.VerifyHttpBearerToken) + " is enabled, but no " + nameof(VerifyHttpBearerTokenOptions.BearerToken) + " is configured");
            return Task.FromResult(false);
        }
            
        // Verify header
#if NET6_0_OR_GREATER
        foreach (var authorizationHeader in context.Request.Headers.Authorization)
#else
            foreach (var authorizationHeader in context.Request.Headers["Authorization"])
#endif
        {
            var authorizationHeaderValue = AuthenticationHeaderValue.Parse(authorizationHeader);
            if (authorizationHeaderValue.Scheme.Equals("Bearer", StringComparison.OrdinalIgnoreCase) &&
                authorizationHeaderValue.Parameter == verificationOptions.BearerToken)
            {
                return Task.FromResult(true);
            }
        }

        _logger.LogError("The HTTP request bearer token does not match the configured bearer token. Make sure the endpoint signing key is configured correctly in your Space organization, and the current application");
        return Task.FromResult(false);
    }
}