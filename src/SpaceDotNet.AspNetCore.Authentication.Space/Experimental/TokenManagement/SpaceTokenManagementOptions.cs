using System;

namespace SpaceDotNet.AspNetCore.Authentication.Space.Experimental.TokenManagement
{
    /// <remarks>
    /// Inspired by <a href="https://github.com/IdentityServer/IdentityServer4/tree/master/samples/Clients/src/MvcHybridAutomaticRefresh/AutomaticTokenManagement">IdentityServer4</a>
    /// </remarks>
    public class SpaceTokenManagementOptions
    {
        public string? Scheme { get; set; }
        public TimeSpan RefreshBeforeExpiration { get; set; } = TimeSpan.FromMinutes(1);
    }
}