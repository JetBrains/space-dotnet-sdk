using JetBrains.Annotations;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.AspNetCore.Authentication.Space
{
    /// <summary>
    /// Determines whether the user should be asked to log in.
    /// </summary>
    [PublicAPI]
    public sealed class RequestCredentials : Enumeration
    {
        private RequestCredentials(string value) : base(value) { }
        
        /// <summary>
        /// Use when the client application does not allow anonymous access.
        ///
        /// <list type="bullet">
        /// <item><description>If the user is already logged in to Space, the user is granted access to the client application.</description></item>
        /// <item><description>If the user is not logged in to Space, the user is redirected to the login page.</description></item>
        /// </list>
        /// </summary>
        public static readonly RequestCredentials Default = new RequestCredentials("default");
        
        /// <summary>
        /// Use when the client application allows anonymous access.
        ///
        /// <list type="bullet">
        /// <item><description>If the user is already logged in to Space, the user is granted access to the client application.</description></item>
        /// <item><description>If the user is not logged in to Space and the guest account is not banned, the user is granted access to the client application as a guest.</description></item>
        /// <item><description>If the user is not logged in to Space and the guest account is banned, the user is redirected to the login page.</description></item>
        /// </list>
        /// </summary>
        public static readonly RequestCredentials Skip = new RequestCredentials("skip");
        
        /// <summary>
        /// Same as <see cref="Skip"/>, but redirects the user to the client application in all cases.
        /// If the guest account is banned, the user is redirected to the client application with an authentication error.
        /// </summary>
        public static readonly RequestCredentials Silent = new RequestCredentials("silent");
        
        /// <summary>
        /// Logs the user out of Space and redirects them to the login page.
        /// Use as a response to a logout request in the client application.
        /// </summary>
        public static readonly RequestCredentials Required = new RequestCredentials("required");
    }
}