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
    public sealed class ChatMessageBlock
         : ChatMessage, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "ChatMessage.Block";
        
        public ChatMessageBlock() { }
        
        public ChatMessageBlock(List<MessageSectionElement> sections, MessageStyle? style = null, MessageOutline? outline = null, string? messageData = null)
        {
            Style = style;
            Outline = outline;
            Sections = sections;
            MessageData = messageData;
        }
        
        private PropertyValue<MessageStyle?> _style = new PropertyValue<MessageStyle?>(nameof(ChatMessageBlock), nameof(Style));
        
        [JsonPropertyName("style")]
        public MessageStyle? Style
        {
            get => _style.GetValue();
            set => _style.SetValue(value);
        }
    
        private PropertyValue<MessageOutline?> _outline = new PropertyValue<MessageOutline?>(nameof(ChatMessageBlock), nameof(Outline));
        
        [JsonPropertyName("outline")]
        public MessageOutline? Outline
        {
            get => _outline.GetValue();
            set => _outline.SetValue(value);
        }
    
        private PropertyValue<List<MessageSectionElement>> _sections = new PropertyValue<List<MessageSectionElement>>(nameof(ChatMessageBlock), nameof(Sections), new List<MessageSectionElement>());
        
        [Required]
        [JsonPropertyName("sections")]
        public List<MessageSectionElement> Sections
        {
            get => _sections.GetValue();
            set => _sections.SetValue(value);
        }
    
        private PropertyValue<string?> _messageData = new PropertyValue<string?>(nameof(ChatMessageBlock), nameof(MessageData));
        
        [JsonPropertyName("messageData")]
        public string? MessageData
        {
            get => _messageData.GetValue();
            set => _messageData.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _style.SetAccessPath(path, validateHasBeenSet);
            _outline.SetAccessPath(path, validateHasBeenSet);
            _sections.SetAccessPath(path, validateHasBeenSet);
            _messageData.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
