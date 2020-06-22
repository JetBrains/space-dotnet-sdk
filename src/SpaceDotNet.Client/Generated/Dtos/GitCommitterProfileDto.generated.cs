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
    public sealed class GitCommitterProfileDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _author = new PropertyValue<string>(nameof(GitCommitterProfileDto), nameof(Author));
        
        [Required]
        [JsonPropertyName("author")]
        public string Author
        {
            get { return _author.GetValue(); }
            set { _author.SetValue(value); }
        }
    
        private PropertyValue<string> _email = new PropertyValue<string>(nameof(GitCommitterProfileDto), nameof(Email));
        
        [Required]
        [JsonPropertyName("email")]
        public string Email
        {
            get { return _email.GetValue(); }
            set { _email.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto?> _profile = new PropertyValue<TDMemberProfileDto?>(nameof(GitCommitterProfileDto), nameof(Profile));
        
        [JsonPropertyName("profile")]
        public TDMemberProfileDto? Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _author.SetAccessPath(path + "->WithAuthor()", validateHasBeenSet);
            _email.SetAccessPath(path + "->WithEmail()", validateHasBeenSet);
            _profile.SetAccessPath(path + "->WithProfile()", validateHasBeenSet);
        }
    
    }
    
}
