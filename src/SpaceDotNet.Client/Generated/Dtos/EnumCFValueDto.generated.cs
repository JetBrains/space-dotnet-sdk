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
    public sealed class EnumCFValueDto
         : CFValueDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        private PropertyValue<EnumValueDataDto?> _value = new PropertyValue<EnumValueDataDto?>(nameof(EnumCFValueDto), nameof(Value));
        
        [JsonPropertyName("value")]
        public EnumValueDataDto? Value
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
