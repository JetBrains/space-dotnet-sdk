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
    public class CustomFieldsForTypeKeyFieldsReorderPostRequest
         : IPropagatePropertyAccessPath
    {
        public CustomFieldsForTypeKeyFieldsReorderPostRequest() { }
        
        public CustomFieldsForTypeKeyFieldsReorderPostRequest(List<string> customFieldOrder, ExtendedTypeScope scope)
        {
            CustomFieldOrder = customFieldOrder;
            Scope = scope;
        }
        
        private PropertyValue<List<string>> _customFieldOrder = new PropertyValue<List<string>>(nameof(CustomFieldsForTypeKeyFieldsReorderPostRequest), nameof(CustomFieldOrder), new List<string>());
        
        [Required]
        [JsonPropertyName("customFieldOrder")]
        public List<string> CustomFieldOrder
        {
            get => _customFieldOrder.GetValue();
            set => _customFieldOrder.SetValue(value);
        }
    
        private PropertyValue<ExtendedTypeScope> _scope = new PropertyValue<ExtendedTypeScope>(nameof(CustomFieldsForTypeKeyFieldsReorderPostRequest), nameof(Scope));
        
        [Required]
        [JsonPropertyName("scope")]
        public ExtendedTypeScope Scope
        {
            get => _scope.GetValue();
            set => _scope.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _customFieldOrder.SetAccessPath(path, validateHasBeenSet);
            _scope.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
