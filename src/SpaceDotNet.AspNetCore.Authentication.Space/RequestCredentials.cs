using SpaceDotNet.Common.Types;

namespace SpaceDotNet.AspNetCore.Authentication.Space
{
    public sealed class RequestCredentials : Enumeration
    {
        private RequestCredentials(string value) : base(value) { }
        
        public static readonly RequestCredentials Default = new RequestCredentials("default");
        public static readonly RequestCredentials Skip = new RequestCredentials("skip");
        public static readonly RequestCredentials Silent = new RequestCredentials("silent");
        public static readonly RequestCredentials Required = new RequestCredentials("required");
    }
}