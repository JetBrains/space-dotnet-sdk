// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class CustomFieldValueUpdate
         : IPropagatePropertyAccessPath
    {
        public CustomFieldValueUpdate() { }
        
        public CustomFieldValueUpdate(CFIdentifier field, CFInputValue newValue)
        {
            Field = field;
            NewValue = newValue;
        }
        
        private PropertyValue<CFIdentifier> _field = new PropertyValue<CFIdentifier>(nameof(CustomFieldValueUpdate), nameof(Field));
        
        [Required]
        [JsonPropertyName("field")]
        public CFIdentifier Field
        {
            get => _field.GetValue();
            set => _field.SetValue(value);
        }
    
        private PropertyValue<CFInputValue> _newValue = new PropertyValue<CFInputValue>(nameof(CustomFieldValueUpdate), nameof(NewValue));
        
        [Required]
        [JsonPropertyName("newValue")]
        public CFInputValue NewValue
        {
            get => _newValue.GetValue();
            set => _newValue.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _field.SetAccessPath(path, validateHasBeenSet);
            _newValue.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
