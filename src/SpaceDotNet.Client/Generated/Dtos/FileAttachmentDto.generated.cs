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
    public sealed class FileAttachmentDto
         : AttachmentDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "FileAttachment";
        
        public FileAttachmentDto() { }
        
        public FileAttachmentDto(string id, long sizeBytes, string filename)
        {
            Id = id;
            SizeBytes = sizeBytes;
            Filename = filename;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(FileAttachmentDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<long> _sizeBytes = new PropertyValue<long>(nameof(FileAttachmentDto), nameof(SizeBytes));
        
        [Required]
        [JsonPropertyName("sizeBytes")]
        public long SizeBytes
        {
            get { return _sizeBytes.GetValue(); }
            set { _sizeBytes.SetValue(value); }
        }
    
        private PropertyValue<string> _filename = new PropertyValue<string>(nameof(FileAttachmentDto), nameof(Filename));
        
        [Required]
        [JsonPropertyName("filename")]
        public string Filename
        {
            get { return _filename.GetValue(); }
            set { _filename.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _sizeBytes.SetAccessPath(path, validateHasBeenSet);
            _filename.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
