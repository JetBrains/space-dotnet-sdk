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
    public sealed class TDMergedEventDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<List<Pair<TDMembershipDto, int>>> _events = new PropertyValue<List<Pair<TDMembershipDto, int>>>(nameof(TDMergedEventDto), nameof(Events));
        
        [Required]
        [JsonPropertyName("events")]
        public List<Pair<TDMembershipDto, int>> Events
        {
            get { return _events.GetValue(); }
            set { _events.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto> _profile = new PropertyValue<TDMemberProfileDto>(nameof(TDMergedEventDto), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberProfileDto Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _events.SetAccessPath(path + "->WithEvents()", validateHasBeenSet);
            _profile.SetAccessPath(path + "->WithProfile()", validateHasBeenSet);
        }
    
    }
    
}
