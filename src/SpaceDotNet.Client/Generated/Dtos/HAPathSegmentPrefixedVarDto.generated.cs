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
    public sealed class HAPathSegmentPrefixedVarDto
         : HAPathSegmentDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _prefix = new PropertyValue<string>(nameof(HAPathSegmentPrefixedVarDto), nameof(Prefix));
        
        [Required]
        [JsonPropertyName("prefix")]
        public string Prefix
        {
            get { return _prefix.GetValue(); }
            set { _prefix.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(HAPathSegmentPrefixedVarDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _prefix.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
