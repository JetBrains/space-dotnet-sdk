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
    public sealed class HADeprecation
         : IPropagatePropertyAccessPath
    {
        public HADeprecation() { }
        
        public HADeprecation(string message, string since, bool forRemoval)
        {
            Message = message;
            Since = since;
            IsForRemoval = forRemoval;
        }
        
        private PropertyValue<string> _message = new PropertyValue<string>(nameof(HADeprecation), nameof(Message));
        
        [Required]
        [JsonPropertyName("message")]
        public string Message
        {
            get => _message.GetValue();
            set => _message.SetValue(value);
        }
    
        private PropertyValue<string> _since = new PropertyValue<string>(nameof(HADeprecation), nameof(Since));
        
        [Required]
        [JsonPropertyName("since")]
        public string Since
        {
            get => _since.GetValue();
            set => _since.SetValue(value);
        }
    
        private PropertyValue<bool> _forRemoval = new PropertyValue<bool>(nameof(HADeprecation), nameof(IsForRemoval));
        
        [Required]
        [JsonPropertyName("forRemoval")]
        public bool IsForRemoval
        {
            get => _forRemoval.GetValue();
            set => _forRemoval.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _message.SetAccessPath(path, validateHasBeenSet);
            _since.SetAccessPath(path, validateHasBeenSet);
            _forRemoval.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
