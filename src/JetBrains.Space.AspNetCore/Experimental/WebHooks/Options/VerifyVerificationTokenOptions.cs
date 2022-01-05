using System;
using JetBrains.Annotations;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks.Options;

/// <summary>
/// When the application receives a request from Space, it must compare a verification token in the request to the Verification token.
/// </summary>
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
[Obsolete("Verification token validation is obsolete and will be removed in a future version.")]
public class VerifyVerificationTokenOptions
{
    /// <summary>
    /// Gets or sets whether the authentication type is enabled.
    /// </summary>
    public bool IsEnabled { get; set; }
        
    /// <summary>
    /// Gets or sets the endpoint verification token. This can be found on your application's endpoint registration in Space.
    /// </summary>
    [Obsolete("Verification token validation is obsolete and will be removed in a future version.")]
    public string? EndpointVerificationToken { get; set; }
}