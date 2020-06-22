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
    public sealed class NonWorkingDaysEventDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<TDMemberProfileDto> _profile = new PropertyValue<TDMemberProfileDto>(nameof(NonWorkingDaysEventDto), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberProfileDto Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        private PropertyValue<List<NonWorkingDaysDto>> _days = new PropertyValue<List<NonWorkingDaysDto>>(nameof(NonWorkingDaysEventDto), nameof(Days));
        
        [Required]
        [JsonPropertyName("days")]
        public List<NonWorkingDaysDto> Days
        {
            get { return _days.GetValue(); }
            set { _days.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profile.SetAccessPath(path + "->WithProfile()", validateHasBeenSet);
            _days.SetAccessPath(path + "->WithDays()", validateHasBeenSet);
        }
    
    }
    
}
