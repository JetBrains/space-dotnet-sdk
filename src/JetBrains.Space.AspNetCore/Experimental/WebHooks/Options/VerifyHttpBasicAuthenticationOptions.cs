using JetBrains.Annotations;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks.Options;

/// <summary>
/// Space sends the Base64-encoded username and password in the Authorization header.
/// </summary>
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public class VerifyHttpBasicAuthenticationOptions
{
    /// <summary>
    /// Gets or sets whether the authentication type is enabled.
    /// </summary>
    public bool IsEnabled { get; set; }
        
    /// <summary>
    /// Gets or sets the HTTP basic authentication username. This can be found on your application's endpoint registration in Space.
    /// </summary>
    public string? Username { get; set; }
        
    /// <summary>
    /// Gets or sets the HTTP basic authentication password. This can be found on your application's endpoint registration in Space.
    /// </summary>
    public string? Password { get; set; }
}