using System;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using JetBrains.Space.AspNetCore.Experimental.WebHooks.Options;
using JetBrains.Space.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks.EndpointAuthentication
{
    /// <summary>
    /// Handle Space endpoint authentication with HTTP basic authentication header.
    /// </summary>
    [PublicAPI]
    public class VerifyHttpBasicAuthenticationHandler : ISpaceEndpointAuthenticationHandler
    {
        private readonly IOptionsSnapshot<SpaceWebHookOptions> _options;
        private readonly ILogger<VerifyHttpBasicAuthenticationHandler> _logger;

        /// <summary>
        /// Creates a new <see cref="VerifyHttpBasicAuthenticationHandler"/>.
        /// </summary>
        /// <param name="options">The <see cref="SpaceWebHookOptions"/> used by the current <see cref="VerifyHttpBasicAuthenticationHandler"/>.</param>
        /// <param name="logger">An <see cref="ILogger{T}"/> used by the current <see cref="VerifyHttpBasicAuthenticationHandler"/>.</param>
        public VerifyHttpBasicAuthenticationHandler(
            IOptionsSnapshot<SpaceWebHookOptions> options,
            ILogger<VerifyHttpBasicAuthenticationHandler> logger)
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

            var verificationOptions = options.VerifyHttpBasicAuthentication;
            if (verificationOptions is not { IsEnabled: true })
            {
                return Task.FromResult(true);
            }
            if (string.IsNullOrEmpty(verificationOptions.Username) || string.IsNullOrEmpty(verificationOptions.Password))
            {
                
                _logger.LogError("Endpoint request validation failed. " + nameof(SpaceWebHookOptions.VerifyHttpBasicAuthentication) + " is enabled, but no " + nameof(VerifyHttpBasicAuthenticationOptions.Username) + " or " + nameof(VerifyHttpBasicAuthenticationOptions.Password) + " are configured");
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
                if (authorizationHeaderValue.Scheme.Equals("Basic", StringComparison.OrdinalIgnoreCase) &&
                    authorizationHeaderValue.Parameter != null)
                {
                    var credentialBytes = Convert.FromBase64String(authorizationHeaderValue.Parameter);
                    var credentials = Encoding.UTF8.GetString(credentialBytes).Split(new[] { ':' }, 2);
                    if (credentials.Length == 2 &&
                        credentials[0] == verificationOptions.Username &&
                        credentials[1] == verificationOptions.Password)
                    {
                        return Task.FromResult(true);
                    }
                }
            }

            _logger.LogError("The HTTP request authentication header does not match the configured bearer token. Make sure the endpoint signing key is configured correctly in your Space organization, and the current application");
            return Task.FromResult(false);
        }
    }
}