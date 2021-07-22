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
    public class ProjectsSecretsForIdPatchRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsSecretsForIdPatchRequest() { }
        
        public ProjectsSecretsForIdPatchRequest(string valueBase64, string? publicKeyId = null)
        {
            ValueBase64 = valueBase64;
            PublicKeyId = publicKeyId;
        }
        
        private PropertyValue<string> _valueBase64 = new PropertyValue<string>(nameof(ProjectsSecretsForIdPatchRequest), nameof(ValueBase64));
        
        [Required]
        [JsonPropertyName("valueBase64")]
        public string ValueBase64
        {
            get => _valueBase64.GetValue();
            set => _valueBase64.SetValue(value);
        }
    
        private PropertyValue<string?> _publicKeyId = new PropertyValue<string?>(nameof(ProjectsSecretsForIdPatchRequest), nameof(PublicKeyId));
        
        [JsonPropertyName("publicKeyId")]
        public string? PublicKeyId
        {
            get => _publicKeyId.GetValue();
            set => _publicKeyId.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _valueBase64.SetAccessPath(path, validateHasBeenSet);
            _publicKeyId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
