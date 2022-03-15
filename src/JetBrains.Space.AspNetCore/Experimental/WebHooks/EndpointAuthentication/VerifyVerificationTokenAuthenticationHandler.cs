using System;
using System.Threading.Tasks;
using JetBrains.Annotations;
using JetBrains.Space.AspNetCore.Experimental.WebHooks.Options;
using JetBrains.Space.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks.EndpointAuthentication;

/// <summary>
/// Handle Space endpoint authentication with verification token.
/// </summary>
[PublicAPI]
[Obsolete("Verification token validation will be removed in a future version.")]
public class VerifyVerificationTokenAuthenticationHandler : ISpaceEndpointAuthenticationHandler
{
    private readonly ILogger<VerifyVerificationTokenAuthenticationHandler> _logger;
        
    /// <summary>
    /// Creates a new <see cref="VerifyVerificationTokenAuthenticationHandler"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger{T}"/> used by the current <see cref="VerifyVerificationTokenAuthenticationHandler"/>.</param>
    public VerifyVerificationTokenAuthenticationHandler(ILogger<VerifyVerificationTokenAuthenticationHandler> logger)
    {
        _logger = logger;
    }
        
    /// <inheritdoc />
    public Task<bool> AuthenticateRequestAsync(
        SpaceWebHookOptions options,
        HttpContext context,
        string requestBody,
        ApplicationPayload? payload)
    {
        var verificationOptions = options.VerifyVerificationToken;
        if (verificationOptions is not { IsEnabled: true })
        {
            return Task.FromResult(true);
        }
        if (string.IsNullOrEmpty(verificationOptions.EndpointVerificationToken))
        {
            _logger.LogError("Endpoint request validation failed. " + nameof(SpaceWebHookOptions.VerifyVerificationToken) + " is enabled, but no " + nameof(VerifyVerificationTokenOptions.EndpointVerificationToken) + " is configured");
            return Task.FromResult(false);
        }
            
        // Verify payload
        var payloadVerificationTokenValue = GetPayloadVerificationTokenValue(payload);
        if (payloadVerificationTokenValue != verificationOptions.EndpointVerificationToken)
        {
            _logger.LogError("The webhook verification token does not match your configured verification token. Make sure the endpoint verification token is configured correctly in your Space organization, and the current application");
            return Task.FromResult(false);
        }

        return Task.FromResult(true);
    }
        
    private static string? GetPayloadVerificationTokenValue(ApplicationPayload? payload) =>
        payload?.GetType()
            .GetProperty(nameof(MessagePayload.VerificationToken))?.GetValue(payload) as string;
}