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
    public sealed class HAPathSegmentConstDto
         : HAPathSegmentDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _value = new PropertyValue<string>(nameof(HAPathSegmentConstDto), nameof(Value));
        
        [Required]
        [JsonPropertyName("value")]
        public string Value
        {
            get { return _value.GetValue(); }
            set { _value.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _value.SetAccessPath(path + "->WithValue()", validateHasBeenSet);
        }
    
    }
    
}
