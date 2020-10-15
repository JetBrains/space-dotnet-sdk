namespace SpaceDotNet.AspNetCore.Authentication.Space
{
    /// <summary>
    /// Default values for Space authentication.
    /// </summary>
    public static class SpaceDefaults
    {
        /// <summary>
        /// Default authentication scheme.
        /// </summary>
        public const string AuthenticationScheme = "Space";

        /// <summary>
        /// Default display name.
        /// </summary>
        public const string DisplayName = "Space";

        /// <summary>
        /// Default authorization endpoint path.
        /// </summary>
        public const string AuthorizationEndpointPath = "/oauth/auth";

        /// <summary>
        /// Default token endpoint path.
        /// </summary>
        public const string TokenEndpointPath = "/oauth/token";

        /// <summary>
        /// Default user information endpoint path.
        /// </summary>
        public const string UserInformationEndpointPath = "/api/http/team-directory/profiles/me?$fields=id,username,emails(email),name(firstName,lastName),profilePicture,smallAvatar";
    }
}