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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class PlainParameterRecord
         : IPropagatePropertyAccessPath
    {
        public PlainParameterRecord() { }
        
        public PlainParameterRecord(string id, bool archived, string bundleId, string key, string value)
        {
            Id = id;
            IsArchived = archived;
            BundleId = bundleId;
            Key = key;
            Value = value;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(PlainParameterRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(PlainParameterRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<string> _bundleId = new PropertyValue<string>(nameof(PlainParameterRecord), nameof(BundleId));
        
        [Required]
        [JsonPropertyName("bundleId")]
        public string BundleId
        {
            get => _bundleId.GetValue();
            set => _bundleId.SetValue(value);
        }
    
        private PropertyValue<string> _key = new PropertyValue<string>(nameof(PlainParameterRecord), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public string Key
        {
            get => _key.GetValue();
            set => _key.SetValue(value);
        }
    
        private PropertyValue<string> _value = new PropertyValue<string>(nameof(PlainParameterRecord), nameof(Value));
        
        [Required]
        [JsonPropertyName("value")]
        public string Value
        {
            get => _value.GetValue();
            set => _value.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _bundleId.SetAccessPath(path, validateHasBeenSet);
            _key.SetAccessPath(path, validateHasBeenSet);
            _value.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}