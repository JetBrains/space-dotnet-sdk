using System;

namespace SpaceDotNet.AspNetCore.Authentication.Space.Experimental.TokenManagement
{
    /// <summary>
    /// Configuration options for use with Space token management.
    /// </summary>
    /// <remarks>
    /// Inspired by <a href="https://github.com/IdentityServer/IdentityServer4/tree/master/samples/Clients/src/MvcHybridAutomaticRefresh/AutomaticTokenManagement">IdentityServer4</a>.
    /// </remarks>
    public class SpaceTokenManagementOptions
    {
        /// <summary>
        /// Name of the authentication scheme.
        /// </summary>
        public string? Scheme { get; set; }
        
        /// <summary>
        /// Get/set how long before token expiration a refresh should be attempted.
        /// </summary>
        public TimeSpan RefreshBeforeExpiration { get; set; } = TimeSpan.FromMinutes(1);
    }
}