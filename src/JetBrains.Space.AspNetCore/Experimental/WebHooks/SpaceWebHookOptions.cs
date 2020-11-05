using System;
using JetBrains.Annotations;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks
{
    /// <summary>
    /// Configuration options for Space WebHooks integration.
    /// </summary>
    [PublicAPI]
    public class SpaceWebHookOptions
    {
        /// <summary>
        /// Gets or sets the Space organization URL.
        /// </summary>
        public Uri? ServerUrl { get; set; }
        
        /// <summary>
        /// Gets or sets the provider-assigned client id.
        /// </summary>
        public string? ClientId { get; set; }

        /// <summary>
        /// Gets or sets the provider-assigned client secret.
        /// </summary>
        public string? ClientSecret { get; set; }
        
        /// <summary>
        /// Gets or sets the endpoint signing key. This can be found on your application's endpoint registration in Space.
        /// </summary>
        public string EndpointSigningKey { get; set; } = default!;

        /// <summary>
        /// Gets or sets the endpoint verification token. This can be found on your application's endpoint registration in Space.
        /// </summary>
        public string EndpointVerificationToken { get; set; } = default!;

        /// <summary>
        /// Validate payload signature. Requires endpoint signing key to be set. Enabled by default.
        /// </summary>
        /// <remarks>It is recommended to enable validation.</remarks>
        public bool ValidatePayloadSignature { get; set; } = true;
        
        /// <summary>
        /// Validate payload verification token. Requires endpoint verification token to be set. Enabled by default.
        /// </summary>
        /// <remarks>It is recommended to enable validation.</remarks>
        public bool ValidatePayloadVerificationToken { get; set; } = true;
    }
}