// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class TrustedCertificatesForIdPatchRequest
         : IPropagatePropertyAccessPath
    {
        public TrustedCertificatesForIdPatchRequest() { }
        
        public TrustedCertificatesForIdPatchRequest(string? alias = null, string? data = null, bool? archived = false)
        {
            Alias = alias;
            Data = data;
            IsArchived = archived;
        }
        
        private PropertyValue<string?> _alias = new PropertyValue<string?>(nameof(TrustedCertificatesForIdPatchRequest), nameof(Alias));
        
        [JsonPropertyName("alias")]
        public string? Alias
        {
            get { return _alias.GetValue(); }
            set { _alias.SetValue(value); }
        }
    
        private PropertyValue<string?> _data = new PropertyValue<string?>(nameof(TrustedCertificatesForIdPatchRequest), nameof(Data));
        
        [JsonPropertyName("data")]
        public string? Data
        {
            get { return _data.GetValue(); }
            set { _data.SetValue(value); }
        }
    
        private PropertyValue<bool?> _archived = new PropertyValue<bool?>(nameof(TrustedCertificatesForIdPatchRequest), nameof(IsArchived));
        
        [JsonPropertyName("archived")]
        public bool? IsArchived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _alias.SetAccessPath(path, validateHasBeenSet);
            _data.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
