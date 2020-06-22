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
    public sealed class ESApplicationPasswordDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ESApplicationPasswordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto> _profile = new PropertyValue<TDMemberProfileDto>(nameof(ESApplicationPasswordDto), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberProfileDto Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(ESApplicationPasswordDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string> _scope = new PropertyValue<string>(nameof(ESApplicationPasswordDto), nameof(Scope));
        
        [Required]
        [JsonPropertyName("scope")]
        public string Scope
        {
            get { return _scope.GetValue(); }
            set { _scope.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _created = new PropertyValue<SpaceTime>(nameof(ESApplicationPasswordDto), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        public SpaceTime Created
        {
            get { return _created.GetValue(); }
            set { _created.SetValue(value); }
        }
    
        private PropertyValue<AccessRecordDto?> _lastAccess = new PropertyValue<AccessRecordDto?>(nameof(ESApplicationPasswordDto), nameof(LastAccess));
        
        [JsonPropertyName("lastAccess")]
        public AccessRecordDto? LastAccess
        {
            get { return _lastAccess.GetValue(); }
            set { _lastAccess.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path + "->WithId()", validateHasBeenSet);
            _profile.SetAccessPath(path + "->WithProfile()", validateHasBeenSet);
            _name.SetAccessPath(path + "->WithName()", validateHasBeenSet);
            _scope.SetAccessPath(path + "->WithScope()", validateHasBeenSet);
            _created.SetAccessPath(path + "->WithCreated()", validateHasBeenSet);
            _lastAccess.SetAccessPath(path + "->WithLastAccess()", validateHasBeenSet);
        }
    
    }
    
}
