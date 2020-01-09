using SpaceDotNet.Common.Types;

namespace SpaceDotNet.AspNetCore.Authentication.Space
{
    public sealed class AccessType : Enumeration
    {
        private AccessType(string value) : base(value) { }
        
        public static readonly AccessType Online = new AccessType("online");
        public static readonly AccessType Offline = new AccessType("offline");
    }
}