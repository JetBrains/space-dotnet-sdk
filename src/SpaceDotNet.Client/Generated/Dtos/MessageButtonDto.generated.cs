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
    public sealed class MessageButtonDto
         : MessageControlElementDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(MessageButtonDto), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get { return _text.GetValue(); }
            set { _text.SetValue(value); }
        }
    
        private PropertyValue<MessageButtonStyle> _style = new PropertyValue<MessageButtonStyle>(nameof(MessageButtonDto), nameof(Style));
        
        [Required]
        [JsonPropertyName("style")]
        public MessageButtonStyle Style
        {
            get { return _style.GetValue(); }
            set { _style.SetValue(value); }
        }
    
        private PropertyValue<MessageActionDto> _action = new PropertyValue<MessageActionDto>(nameof(MessageButtonDto), nameof(Action));
        
        [Required]
        [JsonPropertyName("action")]
        public MessageActionDto Action
        {
            get { return _action.GetValue(); }
            set { _action.SetValue(value); }
        }
    
        private PropertyValue<bool?> _disabled = new PropertyValue<bool?>(nameof(MessageButtonDto), nameof(Disabled));
        
        [JsonPropertyName("disabled")]
        public bool? Disabled
        {
            get { return _disabled.GetValue(); }
            set { _disabled.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _text.SetAccessPath(path, validateHasBeenSet);
            _style.SetAccessPath(path, validateHasBeenSet);
            _action.SetAccessPath(path, validateHasBeenSet);
            _disabled.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
