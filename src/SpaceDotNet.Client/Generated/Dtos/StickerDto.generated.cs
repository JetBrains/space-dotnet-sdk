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
    public sealed class StickerDto
         : IPropagatePropertyAccessPath
    {
        public StickerDto() { }
        
        public StickerDto(string id, bool archived, string? symbol = null, string? attachmentId = null, int? width = null, int? height = null, List<StickerVariantDto>? variants = null, bool? animated = null)
        {
            Id = id;
            Symbol = symbol;
            AttachmentId = attachmentId;
            Width = width;
            Height = height;
            Variants = variants;
            Animated = animated;
            Archived = archived;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(StickerDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string?> _symbol = new PropertyValue<string?>(nameof(StickerDto), nameof(Symbol));
        
        [JsonPropertyName("symbol")]
        public string? Symbol
        {
            get { return _symbol.GetValue(); }
            set { _symbol.SetValue(value); }
        }
    
        private PropertyValue<string?> _attachmentId = new PropertyValue<string?>(nameof(StickerDto), nameof(AttachmentId));
        
        [JsonPropertyName("attachmentId")]
        public string? AttachmentId
        {
            get { return _attachmentId.GetValue(); }
            set { _attachmentId.SetValue(value); }
        }
    
        private PropertyValue<int?> _width = new PropertyValue<int?>(nameof(StickerDto), nameof(Width));
        
        [JsonPropertyName("width")]
        public int? Width
        {
            get { return _width.GetValue(); }
            set { _width.SetValue(value); }
        }
    
        private PropertyValue<int?> _height = new PropertyValue<int?>(nameof(StickerDto), nameof(Height));
        
        [JsonPropertyName("height")]
        public int? Height
        {
            get { return _height.GetValue(); }
            set { _height.SetValue(value); }
        }
    
        private PropertyValue<List<StickerVariantDto>?> _variants = new PropertyValue<List<StickerVariantDto>?>(nameof(StickerDto), nameof(Variants));
        
        [JsonPropertyName("variants")]
        public List<StickerVariantDto>? Variants
        {
            get { return _variants.GetValue(); }
            set { _variants.SetValue(value); }
        }
    
        private PropertyValue<bool?> _animated = new PropertyValue<bool?>(nameof(StickerDto), nameof(Animated));
        
        [JsonPropertyName("animated")]
        public bool? Animated
        {
            get { return _animated.GetValue(); }
            set { _animated.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(StickerDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _symbol.SetAccessPath(path, validateHasBeenSet);
            _attachmentId.SetAccessPath(path, validateHasBeenSet);
            _width.SetAccessPath(path, validateHasBeenSet);
            _height.SetAccessPath(path, validateHasBeenSet);
            _variants.SetAccessPath(path, validateHasBeenSet);
            _animated.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
