// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    [JsonConverter(typeof(UrlParameterConverter))]
    public abstract class ProfileIdentifier : IUrlParameter
    {
        public static ProfileIdentifier Me
            => new ProfileIdentifierMe();
        
        public static ProfileIdentifier Id(string id)
            => new ProfileIdentifierId(id);
        
        public static ProfileIdentifier Username(string username)
            => new ProfileIdentifierUsername(username);
        
        private class ProfileIdentifierMe : ProfileIdentifier
        {
            public override string ToString()
            {
                return "me";
            }
        }
        
        private class ProfileIdentifierId : ProfileIdentifier
        {
            public readonly string _id;
            
            public ProfileIdentifierId(string id)
            {
                _id = id;
            }
            
            public override string ToString()
            {
                return $"id:{_id}";
            }
        }
        
        private class ProfileIdentifierUsername : ProfileIdentifier
        {
            public readonly string _username;
            
            public ProfileIdentifierUsername(string username)
            {
                _username = username;
            }
            
            public override string ToString()
            {
                return $"username:{_username}";
            }
        }
        
    }
    
}
