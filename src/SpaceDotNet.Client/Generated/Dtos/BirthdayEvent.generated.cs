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
    public sealed class BirthdayEvent
         : IPropagatePropertyAccessPath
    {
        public BirthdayEvent() { }
        
        public BirthdayEvent(TDMemberWithTeam profile, SpaceDate birthday)
        {
            Profile = profile;
            Birthday = birthday;
        }
        
        private PropertyValue<TDMemberWithTeam> _profile = new PropertyValue<TDMemberWithTeam>(nameof(BirthdayEvent), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberWithTeam Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate> _birthday = new PropertyValue<SpaceDate>(nameof(BirthdayEvent), nameof(Birthday));
        
        [Required]
        [JsonPropertyName("birthday")]
        public SpaceDate Birthday
        {
            get { return _birthday.GetValue(); }
            set { _birthday.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profile.SetAccessPath(path, validateHasBeenSet);
            _birthday.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
