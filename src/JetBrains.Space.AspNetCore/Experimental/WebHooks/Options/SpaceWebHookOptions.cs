using JetBrains.Annotations;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks.Options;

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
    /// Gets or sets the endpoint signing key, as configured on your application's endpoint registration in Space.
    /// </summary>
    public VerifySigningKeyOptions? VerifySigningKey { get; set; }

    /// <summary>
    /// Gets or sets the endpoint HTTP bearer token, as configured on your application's endpoint registration in Space.
    /// </summary>
    public VerifyHttpBearerTokenOptions? VerifyHttpBearerToken { get; set; }

    /// <summary>
    /// Gets or sets the endpoint HTTP basic authentication, as configured on your application's endpoint registration in Space.
    /// </summary>
    public VerifyHttpBasicAuthenticationOptions? VerifyHttpBasicAuthentication { get; set; }

    /// <summary>
    /// Gets or sets the endpoint payload verification token, as configured on your application's endpoint registration in Space.
    /// </summary>
    [Obsolete("Verification token validation is obsolete and will be removed in a future version.")]
    public VerifyVerificationTokenOptions? VerifyVerificationToken { get; set; }

    /// <summary>
    /// Validate payload signature. Requires endpoint signing key to be set.
    /// </summary>
    /// <remarks>It is recommended to enable validation.</remarks>
    [Obsolete($"Option is deprecated and will be removed in a future release. Configure the {nameof(VerifySigningKey)} option instead.")]
    public bool ValidatePayloadSignature { get; set; } = true;

    /// <summary>
    /// Gets or sets the endpoint signing key. This can be found on your application's endpoint registration in Space.
    /// </summary>
    [Obsolete($"Option is deprecated and will be removed in a future release. Configure the {nameof(VerifySigningKey)} option instead.")]
    public string? EndpointSigningKey { get; set; }
        
    /// <summary>
    /// Validate payload verification token. Requires endpoint verification token to be set. Disabled by default.
    /// </summary>
    [Obsolete("Verification token validation is obsolete and will be removed in a future version.")]
    public bool ValidatePayloadVerificationToken { get; set; }

    /// <summary>
    /// Gets or sets the endpoint verification token. This can be found on your application's endpoint registration in Space.
    /// </summary>
    [Obsolete("Verification token validation is obsolete and will be removed in a future version.")]
    public string? EndpointVerificationToken { get; set; }
}