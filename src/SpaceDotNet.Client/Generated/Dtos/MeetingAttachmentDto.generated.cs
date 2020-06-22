// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class MeetingAttachmentDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string?> _fileUrl = new PropertyValue<string?>(nameof(MeetingAttachmentDto), nameof(FileUrl));
        
        [JsonPropertyName("fileUrl")]
        public string? FileUrl
        {
            get { return _fileUrl.GetValue(); }
            set { _fileUrl.SetValue(value); }
        }
    
        private PropertyValue<string?> _title = new PropertyValue<string?>(nameof(MeetingAttachmentDto), nameof(Title));
        
        [JsonPropertyName("title")]
        public string? Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<string?> _mimeType = new PropertyValue<string?>(nameof(MeetingAttachmentDto), nameof(MimeType));
        
        [JsonPropertyName("mimeType")]
        public string? MimeType
        {
            get { return _mimeType.GetValue(); }
            set { _mimeType.SetValue(value); }
        }
    
        private PropertyValue<string?> _fileId = new PropertyValue<string?>(nameof(MeetingAttachmentDto), nameof(FileId));
        
        [JsonPropertyName("fileId")]
        public string? FileId
        {
            get { return _fileId.GetValue(); }
            set { _fileId.SetValue(value); }
        }
    
        private PropertyValue<string?> _source = new PropertyValue<string?>(nameof(MeetingAttachmentDto), nameof(Source));
        
        [JsonPropertyName("source")]
        public string? Source
        {
            get { return _source.GetValue(); }
            set { _source.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _fileUrl.SetAccessPath(path + "->WithFileUrl()", validateHasBeenSet);
            _title.SetAccessPath(path + "->WithTitle()", validateHasBeenSet);
            _mimeType.SetAccessPath(path + "->WithMimeType()", validateHasBeenSet);
            _fileId.SetAccessPath(path + "->WithFileId()", validateHasBeenSet);
            _source.SetAccessPath(path + "->WithSource()", validateHasBeenSet);
        }
    
    }
    
}
