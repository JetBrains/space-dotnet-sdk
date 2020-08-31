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
    public sealed class FullRightWithoutType
         : IPropagatePropertyAccessPath
    {
        public FullRightWithoutType() { }
        
        public FullRightWithoutType(string code, string title, bool grantedForUsers, string? description = null, FeatureFlag? featureFlag = null)
        {
            Code = code;
            Title = title;
            Description = description;
            IsGrantedForUsers = grantedForUsers;
            FeatureFlag = featureFlag;
        }
        
        private PropertyValue<string> _code = new PropertyValue<string>(nameof(FullRightWithoutType), nameof(Code));
        
        [Required]
        [JsonPropertyName("code")]
        public string Code
        {
            get { return _code.GetValue(); }
            set { _code.SetValue(value); }
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(FullRightWithoutType), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(FullRightWithoutType), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<bool> _grantedForUsers = new PropertyValue<bool>(nameof(FullRightWithoutType), nameof(IsGrantedForUsers));
        
        [Required]
        [JsonPropertyName("grantedForUsers")]
        public bool IsGrantedForUsers
        {
            get { return _grantedForUsers.GetValue(); }
            set { _grantedForUsers.SetValue(value); }
        }
    
        private PropertyValue<FeatureFlag?> _featureFlag = new PropertyValue<FeatureFlag?>(nameof(FullRightWithoutType), nameof(FeatureFlag));
        
        [JsonPropertyName("featureFlag")]
        public FeatureFlag? FeatureFlag
        {
            get { return _featureFlag.GetValue(); }
            set { _featureFlag.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _code.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _grantedForUsers.SetAccessPath(path, validateHasBeenSet);
            _featureFlag.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
