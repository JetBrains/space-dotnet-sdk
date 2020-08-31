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
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class MessageIcon
         : MessageAccessoryElement, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MessageIcon";
        
        public MessageIcon() { }
        
        public MessageIcon(ApiIcon icon, MessageStyle style)
        {
            Icon = icon;
            Style = style;
        }
        
        private PropertyValue<ApiIcon> _icon = new PropertyValue<ApiIcon>(nameof(MessageIcon), nameof(Icon));
        
        [Required]
        [JsonPropertyName("icon")]
        public ApiIcon Icon
        {
            get { return _icon.GetValue(); }
            set { _icon.SetValue(value); }
        }
    
        private PropertyValue<MessageStyle> _style = new PropertyValue<MessageStyle>(nameof(MessageIcon), nameof(Style));
        
        [Required]
        [JsonPropertyName("style")]
        public MessageStyle Style
        {
            get { return _style.GetValue(); }
            set { _style.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _icon.SetAccessPath(path, validateHasBeenSet);
            _style.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
