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
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class ProfileLinkPreviewDto
         : AttachmentDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "ProfileLinkPreview";
        
        public ProfileLinkPreviewDto() { }
        
        public ProfileLinkPreviewDto(TDMemberProfileDto profile)
        {
            Profile = profile;
        }
        
        private PropertyValue<TDMemberProfileDto> _profile = new PropertyValue<TDMemberProfileDto>(nameof(ProfileLinkPreviewDto), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberProfileDto Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profile.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
