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
    public class EmojisAddPostRequest
         : IPropagatePropertyAccessPath
    {
        public EmojisAddPostRequest() { }
        
        public EmojisAddPostRequest(string emoji, string attachmentId)
        {
            Emoji = emoji;
            AttachmentId = attachmentId;
        }
        
        private PropertyValue<string> _emoji = new PropertyValue<string>(nameof(EmojisAddPostRequest), nameof(Emoji));
        
        [Required]
        [JsonPropertyName("emoji")]
        public string Emoji
        {
            get => _emoji.GetValue();
            set => _emoji.SetValue(value);
        }
    
        private PropertyValue<string> _attachmentId = new PropertyValue<string>(nameof(EmojisAddPostRequest), nameof(AttachmentId));
        
        [Required]
        [JsonPropertyName("attachmentId")]
        public string AttachmentId
        {
            get => _attachmentId.GetValue();
            set => _attachmentId.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _emoji.SetAccessPath(path, validateHasBeenSet);
            _attachmentId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
