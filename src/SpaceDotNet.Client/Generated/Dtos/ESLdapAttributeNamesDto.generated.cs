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
    public sealed class ESLdapAttributeNamesDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string?> _fullNameAttributeName = new PropertyValue<string?>(nameof(ESLdapAttributeNamesDto), nameof(FullNameAttributeName));
        
        [JsonPropertyName("fullNameAttributeName")]
        public string? FullNameAttributeName
        {
            get { return _fullNameAttributeName.GetValue(); }
            set { _fullNameAttributeName.SetValue(value); }
        }
    
        private PropertyValue<string?> _usernameAttributeName = new PropertyValue<string?>(nameof(ESLdapAttributeNamesDto), nameof(UsernameAttributeName));
        
        [JsonPropertyName("usernameAttributeName")]
        public string? UsernameAttributeName
        {
            get { return _usernameAttributeName.GetValue(); }
            set { _usernameAttributeName.SetValue(value); }
        }
    
        private PropertyValue<string?> _emailAttributeName = new PropertyValue<string?>(nameof(ESLdapAttributeNamesDto), nameof(EmailAttributeName));
        
        [JsonPropertyName("emailAttributeName")]
        public string? EmailAttributeName
        {
            get { return _emailAttributeName.GetValue(); }
            set { _emailAttributeName.SetValue(value); }
        }
    
        private PropertyValue<string?> _groupsAttributeName = new PropertyValue<string?>(nameof(ESLdapAttributeNamesDto), nameof(GroupsAttributeName));
        
        [JsonPropertyName("groupsAttributeName")]
        public string? GroupsAttributeName
        {
            get { return _groupsAttributeName.GetValue(); }
            set { _groupsAttributeName.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _fullNameAttributeName.SetAccessPath(path + "->WithFullNameAttributeName()", validateHasBeenSet);
            _usernameAttributeName.SetAccessPath(path + "->WithUsernameAttributeName()", validateHasBeenSet);
            _emailAttributeName.SetAccessPath(path + "->WithEmailAttributeName()", validateHasBeenSet);
            _groupsAttributeName.SetAccessPath(path + "->WithGroupsAttributeName()", validateHasBeenSet);
        }
    
    }
    
}
