using JetBrains.Annotations;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks.Options;

/// <summary>
/// Space sends the provided bearer token in the Authorization header.
/// </summary>
[UsedImplicitly]
public class VerifyHttpBearerTokenOptions
{
    /// <summary>
    /// Gets or sets whether the authentication type is enabled.
    /// </summary>
    public bool IsEnabled { get; set; }
        
    /// <summary>
    /// Gets or sets the HTTP bearer token. This can be found on your application's endpoint registration in Space.
    /// </summary>
    public string? BearerToken { get; set; }
}