using JetBrains.Annotations;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks.Options
{
    /// <summary>
    /// When the application receives a request from Space, it must calculate a hash for this request using the Signing key. The calculated hash value must be equal to the hash value from the request.
    /// </summary>
    [UsedImplicitly]
    public class VerifySigningKeyOptions
    {
        /// <summary>
        /// Gets or sets whether the authentication type is enabled.
        /// </summary>
        public bool IsEnabled { get; set; }
        
        /// <summary>
        /// Gets or sets the endpoint signing key. This can be found on your application's endpoint registration in Space.
        /// </summary>
        public string? EndpointSigningKey { get; set; }
    }
}