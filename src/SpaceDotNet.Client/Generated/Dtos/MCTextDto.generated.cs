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
    public sealed class MCTextDto
         : MCElementDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<string> _content = new PropertyValue<string>(nameof(MCTextDto), nameof(Content));
        
        [Required]
        [JsonPropertyName("content")]
        public string Content
        {
            get { return _content.GetValue(); }
            set { _content.SetValue(value); }
        }
    
        private PropertyValue<bool> _markdown = new PropertyValue<bool>(nameof(MCTextDto), nameof(Markdown));
        
        [Required]
        [JsonPropertyName("markdown")]
        public bool Markdown
        {
            get { return _markdown.GetValue(); }
            set { _markdown.SetValue(value); }
        }
    
        private PropertyValue<MCElementDto?> _accessory = new PropertyValue<MCElementDto?>(nameof(MCTextDto), nameof(Accessory));
        
        [JsonPropertyName("accessory")]
        public MCElementDto? Accessory
        {
            get { return _accessory.GetValue(); }
            set { _accessory.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _content.SetAccessPath(path, validateHasBeenSet);
            _markdown.SetAccessPath(path, validateHasBeenSet);
            _accessory.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
