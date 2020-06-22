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
    public sealed class DTOFullRightWithoutTypeDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _code = new PropertyValue<string>(nameof(DTOFullRightWithoutTypeDto), nameof(Code));
        
        [Required]
        [JsonPropertyName("code")]
        public string Code
        {
            get { return _code.GetValue(); }
            set { _code.SetValue(value); }
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(DTOFullRightWithoutTypeDto), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(DTOFullRightWithoutTypeDto), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<bool> _grantedForUsers = new PropertyValue<bool>(nameof(DTOFullRightWithoutTypeDto), nameof(GrantedForUsers));
        
        [Required]
        [JsonPropertyName("grantedForUsers")]
        public bool GrantedForUsers
        {
            get { return _grantedForUsers.GetValue(); }
            set { _grantedForUsers.SetValue(value); }
        }
    
        private PropertyValue<FeatureFlagDto?> _featureFlag = new PropertyValue<FeatureFlagDto?>(nameof(DTOFullRightWithoutTypeDto), nameof(FeatureFlag));
        
        [JsonPropertyName("featureFlag")]
        public FeatureFlagDto? FeatureFlag
        {
            get { return _featureFlag.GetValue(); }
            set { _featureFlag.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _code.SetAccessPath(path + "->WithCode()", validateHasBeenSet);
            _title.SetAccessPath(path + "->WithTitle()", validateHasBeenSet);
            _description.SetAccessPath(path + "->WithDescription()", validateHasBeenSet);
            _grantedForUsers.SetAccessPath(path + "->WithGrantedForUsers()", validateHasBeenSet);
            _featureFlag.SetAccessPath(path + "->WithFeatureFlag()", validateHasBeenSet);
        }
    
    }
    
}
