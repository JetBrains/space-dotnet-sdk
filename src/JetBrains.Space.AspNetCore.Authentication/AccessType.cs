using System.Runtime.Serialization;

namespace JetBrains.Space.AspNetCore.Authentication
{
    /// <summary>
    /// Indicates whether the application requires access to Space when the user is not online.
    /// If the application requires refreshing access tokens when the user is not online, use the offline value.
    /// </summary>
    public enum AccessType
    {
        /// <summary>
        /// Authentication token can be used online.
        /// </summary>
        [EnumMember(Value = "online")]
        Online,
        
        /// <summary>
        /// Authentication token can be used offline.
        /// In this case, Space issues a refresh token for the application the first time it exchanges an authorization code for a user.
        /// </summary>
        [EnumMember(Value = "offline")]
        Offline
    }
}