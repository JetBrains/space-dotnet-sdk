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
    public sealed class MeInfoDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<TDMemberProfileDto> _profile = new PropertyValue<TDMemberProfileDto>(nameof(MeInfoDto), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberProfileDto Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        private PropertyValue<string?> _profilePic = new PropertyValue<string?>(nameof(MeInfoDto), nameof(ProfilePic));
        
        [JsonPropertyName("profilePic")]
        public string? ProfilePic
        {
            get { return _profilePic.GetValue(); }
            set { _profilePic.SetValue(value); }
        }
    
        private PropertyValue<TDLanguageDto> _preferredLanguage = new PropertyValue<TDLanguageDto>(nameof(MeInfoDto), nameof(PreferredLanguage));
        
        [Required]
        [JsonPropertyName("preferredLanguage")]
        public TDLanguageDto PreferredLanguage
        {
            get { return _preferredLanguage.GetValue(); }
            set { _preferredLanguage.SetValue(value); }
        }
    
        private PropertyValue<TDLanguageDto> _englishLanguage = new PropertyValue<TDLanguageDto>(nameof(MeInfoDto), nameof(EnglishLanguage));
        
        [Required]
        [JsonPropertyName("englishLanguage")]
        public TDLanguageDto EnglishLanguage
        {
            get { return _englishLanguage.GetValue(); }
            set { _englishLanguage.SetValue(value); }
        }
    
        private PropertyValue<List<NavBarMenuItemDto>?> _navBarMenuItems = new PropertyValue<List<NavBarMenuItemDto>?>(nameof(MeInfoDto), nameof(NavBarMenuItems));
        
        [JsonPropertyName("navBarMenuItems")]
        public List<NavBarMenuItemDto>? NavBarMenuItems
        {
            get { return _navBarMenuItems.GetValue(); }
            set { _navBarMenuItems.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _navBarProjects = new PropertyValue<List<string>>(nameof(MeInfoDto), nameof(NavBarProjects));
        
        [Required]
        [JsonPropertyName("navBarProjects")]
        public List<string> NavBarProjects
        {
            get { return _navBarProjects.GetValue(); }
            set { _navBarProjects.SetValue(value); }
        }
    
        private PropertyValue<int> _firstDayOfWeek = new PropertyValue<int>(nameof(MeInfoDto), nameof(FirstDayOfWeek));
        
        [Required]
        [JsonPropertyName("firstDayOfWeek")]
        public int FirstDayOfWeek
        {
            get { return _firstDayOfWeek.GetValue(); }
            set { _firstDayOfWeek.SetValue(value); }
        }
    
        private PropertyValue<string?> _themeName = new PropertyValue<string?>(nameof(MeInfoDto), nameof(ThemeName));
        
        [JsonPropertyName("themeName")]
        public string? ThemeName
        {
            get { return _themeName.GetValue(); }
            set { _themeName.SetValue(value); }
        }
    
        private PropertyValue<DraftDocumentType?> _draftType = new PropertyValue<DraftDocumentType?>(nameof(MeInfoDto), nameof(DraftType));
        
        [JsonPropertyName("draftType")]
        public DraftDocumentType? DraftType
        {
            get { return _draftType.GetValue(); }
            set { _draftType.SetValue(value); }
        }
    
        private PropertyValue<bool?> _todoFilters = new PropertyValue<bool?>(nameof(MeInfoDto), nameof(TodoFilters));
        
        [JsonPropertyName("todoFilters")]
        public bool? TodoFilters
        {
            get { return _todoFilters.GetValue(); }
            set { _todoFilters.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profile.SetAccessPath(path, validateHasBeenSet);
            _profilePic.SetAccessPath(path, validateHasBeenSet);
            _preferredLanguage.SetAccessPath(path, validateHasBeenSet);
            _englishLanguage.SetAccessPath(path, validateHasBeenSet);
            _navBarMenuItems.SetAccessPath(path, validateHasBeenSet);
            _navBarProjects.SetAccessPath(path, validateHasBeenSet);
            _firstDayOfWeek.SetAccessPath(path, validateHasBeenSet);
            _themeName.SetAccessPath(path, validateHasBeenSet);
            _draftType.SetAccessPath(path, validateHasBeenSet);
            _todoFilters.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
