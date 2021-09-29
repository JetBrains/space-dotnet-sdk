using System.Collections.Generic;
using System.Security.Cryptography;
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
    /// Handle Space endpoint authentication with signing key.
    /// </summary>
    [PublicAPI]
    public class VerifySigningKeyAuthenticationHandler : ISpaceEndpointAuthenticationHandler
    {
        private const string HeaderSpaceSignature = "X-Space-Signature";
        private const string HeaderSpaceTimestamp = "X-Space-Timestamp";

        private readonly IOptionsSnapshot<SpaceWebHookOptions> _options;
        private readonly ILogger<VerifySigningKeyAuthenticationHandler> _logger;

        /// <summary>
        /// Creates a new <see cref="VerifySigningKeyAuthenticationHandler"/>.
        /// </summary>
        /// <param name="options">The <see cref="SpaceWebHookOptions"/> used by the current <see cref="VerifySigningKeyAuthenticationHandler"/>.</param>
        /// <param name="logger">An <see cref="ILogger{T}"/> used by the current <see cref="VerifySigningKeyAuthenticationHandler"/>.</param>
        public VerifySigningKeyAuthenticationHandler(
            IOptionsSnapshot<SpaceWebHookOptions> options,
            ILogger<VerifySigningKeyAuthenticationHandler> logger)
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

            var verificationOptions = options.VerifySigningKey;
            if (verificationOptions is not { IsEnabled: true })
            {
                return Task.FromResult(true);
            }
            if (string.IsNullOrEmpty(verificationOptions.EndpointSigningKey))
            {
                _logger.LogError("Endpoint request validation failed. " + nameof(SpaceWebHookOptions.VerifySigningKey) + " is enabled, but no " + nameof(VerifySigningKeyOptions.EndpointSigningKey) + " is configured");
                return Task.FromResult(false);
            }
            
            // Verify signature
            var secret = Encoding.ASCII.GetBytes(verificationOptions.EndpointSigningKey);
                
            var signatureBytes = Encoding.UTF8.GetBytes(context.Request.Headers[HeaderSpaceTimestamp] + ":" + requestBody);
            using var hmSha1 = new HMACSHA256(secret);
            var signatureHash = hmSha1.ComputeHash(signatureBytes);
            var signatureString = ToHexString(signatureHash);
            
            if (!signatureString.Equals(context.Request.Headers[HeaderSpaceSignature]))
            {
                _logger.LogError("The webhook signature does not match the webhook payload. Make sure the endpoint signing key is configured correctly in your Space organization, and the current application");
                return Task.FromResult(false);
            }

            return Task.FromResult(true);
        }

        private static string ToHexString(IReadOnlyCollection<byte> bytes)
        {
            var builder = new StringBuilder(bytes.Count * 2);
            foreach (var b in bytes)
            {
                builder.AppendFormat("{0:x2}", b);
            }
            return builder.ToString();
        }
    }
}