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
    public sealed class ExtendedTypeDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _key = new PropertyValue<string>(nameof(ExtendedTypeDto), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public string Key
        {
            get { return _key.GetValue(); }
            set { _key.SetValue(value); }
        }
    
        private PropertyValue<string> _displayName = new PropertyValue<string>(nameof(ExtendedTypeDto), nameof(DisplayName));
        
        [Required]
        [JsonPropertyName("displayName")]
        public string DisplayName
        {
            get { return _displayName.GetValue(); }
            set { _displayName.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _key.SetAccessPath(path + "->WithKey()", validateHasBeenSet);
            _displayName.SetAccessPath(path + "->WithDisplayName()", validateHasBeenSet);
        }
    
    }
    
}
