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
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class UploadsPostRequest
         : IPropagatePropertyAccessPath
    {
        public UploadsPostRequest() { }
        
        public UploadsPostRequest(string storagePrefix, string? mediaType = null)
        {
            StoragePrefix = storagePrefix;
            MediaType = mediaType;
        }
        
        private PropertyValue<string> _storagePrefix = new PropertyValue<string>(nameof(UploadsPostRequest), nameof(StoragePrefix));
        
        [Required]
        [JsonPropertyName("storagePrefix")]
        public string StoragePrefix
        {
            get { return _storagePrefix.GetValue(); }
            set { _storagePrefix.SetValue(value); }
        }
    
        private PropertyValue<string?> _mediaType = new PropertyValue<string?>(nameof(UploadsPostRequest), nameof(MediaType));
        
        [JsonPropertyName("mediaType")]
        public string? MediaType
        {
            get { return _mediaType.GetValue(); }
            set { _mediaType.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _storagePrefix.SetAccessPath(path, validateHasBeenSet);
            _mediaType.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
