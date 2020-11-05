using JetBrains.Space.Common.Types;

namespace JetBrains.Space.AspNetCore.Authentication.Space
{
    /// <summary>
    /// Indicates whether the application requires access to Space when the user is not online.
    /// If the application requires refreshing access tokens when the user is not online, use the offline value.
    /// </summary>
    public sealed class AccessType : Enumeration
    {
        private AccessType(string value) : base(value) { }
        
        /// <summary>
        /// Authentication token can be used online.
        /// </summary>
        public static readonly AccessType Online = new AccessType("online");
        
        /// <summary>
        /// Authentication token can be used offline.
        /// In this case, Space issues a refresh token for the application the first time it exchanges an authorization code for a user.
        /// </summary>
        public static readonly AccessType Offline = new AccessType("offline");
    }
}