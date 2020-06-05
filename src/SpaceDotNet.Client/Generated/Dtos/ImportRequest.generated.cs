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
    public class ImportRequest
    {
        private PropertyValue<string> _calendar = new PropertyValue<string>(nameof(ImportRequest), nameof(Calendar));
        
        [Required]
        [JsonPropertyName("calendar")]
        public string Calendar { get { return _calendar.GetValue(); } set { _calendar.SetValue(value); } }
    
        private PropertyValue<string> _attachmentId = new PropertyValue<string>(nameof(ImportRequest), nameof(AttachmentId));
        
        [Required]
        [JsonPropertyName("attachmentId")]
        public string AttachmentId { get { return _attachmentId.GetValue(); } set { _attachmentId.SetValue(value); } }
    
    }
    
}
