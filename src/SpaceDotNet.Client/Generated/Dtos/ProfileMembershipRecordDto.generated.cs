// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class ProfileMembershipRecordDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ProfileMembershipRecordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<List<TDMembershipDto>> _memberships = new PropertyValue<List<TDMembershipDto>>(nameof(ProfileMembershipRecordDto), nameof(Memberships));
        
        [Required]
        [JsonPropertyName("memberships")]
        public List<TDMembershipDto> Memberships
        {
            get { return _memberships.GetValue(); }
            set { _memberships.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path + "->WithId()", validateHasBeenSet);
            _memberships.SetAccessPath(path + "->WithMemberships()", validateHasBeenSet);
        }
    
    }
    
}
