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
    public sealed class ESHiddenAuthModuleSettings
         : ESAuthModuleSettings, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "ES_HiddenAuthModuleSettings";
        
        public ESHiddenAuthModuleSettings() { }
        
        public ESHiddenAuthModuleSettings(bool? passwordModule = null, bool? federatedModule = null)
        {
            IsPasswordModule = passwordModule;
            IsFederatedModule = federatedModule;
        }
        
        private PropertyValue<bool?> _passwordModule = new PropertyValue<bool?>(nameof(ESHiddenAuthModuleSettings), nameof(IsPasswordModule));
        
        [JsonPropertyName("passwordModule")]
        public bool? IsPasswordModule
        {
            get => _passwordModule.GetValue();
            set => _passwordModule.SetValue(value);
        }
    
        private PropertyValue<bool?> _federatedModule = new PropertyValue<bool?>(nameof(ESHiddenAuthModuleSettings), nameof(IsFederatedModule));
        
        [JsonPropertyName("federatedModule")]
        public bool? IsFederatedModule
        {
            get => _federatedModule.GetValue();
            set => _federatedModule.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _passwordModule.SetAccessPath(path, validateHasBeenSet);
            _federatedModule.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
