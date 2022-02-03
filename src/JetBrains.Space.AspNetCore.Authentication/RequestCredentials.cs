using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace JetBrains.Space.AspNetCore.Authentication;

/// <summary>
/// Determines whether the user should be asked to log in.
/// </summary>
[PublicAPI]
public enum RequestCredentials
{
    /// <summary>
    /// Use when the client application does not allow anonymous access.
    ///
    /// <list type="bullet">
    /// <item><description>If the user is already logged in to Space, the user is granted access to the client application.</description></item>
    /// <item><description>If the user is not logged in to Space, the user is redirected to the login page.</description></item>
    /// </list>
    /// </summary>
    [EnumMember(Value = "default")]
    Default,
        
    /// <summary>
    /// Logs the user out of Space and redirects them to the login page.
    /// Use as a response to a logout request in the client application.
    /// </summary>
    [EnumMember(Value = "required")]
    Required
}