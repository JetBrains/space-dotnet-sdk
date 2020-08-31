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
    public class TeamDirectoryInvitationLinksPostRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryInvitationLinksPostRequest() { }
        
        public TeamDirectoryInvitationLinksPostRequest(string name, SpaceTime expiresAt, int inviteeLimit)
        {
            Name = name;
            ExpiresAt = expiresAt;
            InviteeLimit = inviteeLimit;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(TeamDirectoryInvitationLinksPostRequest), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _expiresAt = new PropertyValue<SpaceTime>(nameof(TeamDirectoryInvitationLinksPostRequest), nameof(ExpiresAt));
        
        [Required]
        [JsonPropertyName("expiresAt")]
        public SpaceTime ExpiresAt
        {
            get { return _expiresAt.GetValue(); }
            set { _expiresAt.SetValue(value); }
        }
    
        private PropertyValue<int> _inviteeLimit = new PropertyValue<int>(nameof(TeamDirectoryInvitationLinksPostRequest), nameof(InviteeLimit));
        
        [Required]
        [JsonPropertyName("inviteeLimit")]
        public int InviteeLimit
        {
            get { return _inviteeLimit.GetValue(); }
            set { _inviteeLimit.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _expiresAt.SetAccessPath(path, validateHasBeenSet);
            _inviteeLimit.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
