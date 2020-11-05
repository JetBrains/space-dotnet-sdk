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
    public sealed class VideoAttachment
         : MediaAttachment, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "VideoAttachment";
        
        public VideoAttachment() { }
        
        public VideoAttachment(string id, long sizeBytes, string? name = null, int? width = null, int? height = null, string? previewBytes = null)
        {
            Id = id;
            Name = name;
            Width = width;
            Height = height;
            SizeBytes = sizeBytes;
            PreviewBytes = previewBytes;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(VideoAttachment), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(VideoAttachment), nameof(Name));
        
        [JsonPropertyName("name")]
        public string? Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<int?> _width = new PropertyValue<int?>(nameof(VideoAttachment), nameof(Width));
        
        [JsonPropertyName("width")]
        public int? Width
        {
            get => _width.GetValue();
            set => _width.SetValue(value);
        }
    
        private PropertyValue<int?> _height = new PropertyValue<int?>(nameof(VideoAttachment), nameof(Height));
        
        [JsonPropertyName("height")]
        public int? Height
        {
            get => _height.GetValue();
            set => _height.SetValue(value);
        }
    
        private PropertyValue<long> _sizeBytes = new PropertyValue<long>(nameof(VideoAttachment), nameof(SizeBytes));
        
        [Required]
        [JsonPropertyName("sizeBytes")]
        public long SizeBytes
        {
            get => _sizeBytes.GetValue();
            set => _sizeBytes.SetValue(value);
        }
    
        private PropertyValue<string?> _previewBytes = new PropertyValue<string?>(nameof(VideoAttachment), nameof(PreviewBytes));
        
        [JsonPropertyName("previewBytes")]
        public string? PreviewBytes
        {
            get => _previewBytes.GetValue();
            set => _previewBytes.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _width.SetAccessPath(path, validateHasBeenSet);
            _height.SetAccessPath(path, validateHasBeenSet);
            _sizeBytes.SetAccessPath(path, validateHasBeenSet);
            _previewBytes.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}