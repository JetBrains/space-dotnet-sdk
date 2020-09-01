using JetBrains.Annotations;

namespace SpaceDotNet.AspNetCore.WebHooks
{
    /// <summary>
    /// Configuration options for Space WebHooks integration.
    /// </summary>
    [PublicAPI]
    public class SpaceWebHookOptions
    {
        /// <summary>
        /// Endpoint signing key. This can be found on your application's endpoint registration in Space.
        /// </summary>
        public string EndpointSigningKey { get; set; } = default!;

        /// <summary>
        /// Endpoint verification token. This can be found on your application's endpoint registration in Space.
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