namespace SpaceDotNet.AspNetCore.Authentication.Space
{
    /// <summary>
    /// Default values for Space authentication.
    /// </summary>
    public static class SpaceDefaults
    {
        public const string AuthenticationScheme = "Space";

        public const string DisplayName = "Space";

        public const string AuthorizationEndpointPath = "/oauth/auth";
        public const string TokenEndpointPath = "/oauth/token";
        public const string UserInformationEndpointPath = "/api/http/team-directory/profiles/me?$fields=id,username,emails(email),name(firstName,lastName),profilePicture,smallAvatar";
    }
}