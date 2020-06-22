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
    public sealed class CustomFieldValueDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<CustomFieldDto> _field = new PropertyValue<CustomFieldDto>(nameof(CustomFieldValueDto), nameof(Field));
        
        [Required]
        [JsonPropertyName("field")]
        public CustomFieldDto Field
        {
            get { return _field.GetValue(); }
            set { _field.SetValue(value); }
        }
    
        private PropertyValue<CFValueDto> _value = new PropertyValue<CFValueDto>(nameof(CustomFieldValueDto), nameof(Value));
        
        [Required]
        [JsonPropertyName("value")]
        public CFValueDto Value
        {
            get { return _value.GetValue(); }
            set { _value.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _field.SetAccessPath(path + "->WithField()", validateHasBeenSet);
            _value.SetAccessPath(path + "->WithValue()", validateHasBeenSet);
        }
    
    }
    
}
