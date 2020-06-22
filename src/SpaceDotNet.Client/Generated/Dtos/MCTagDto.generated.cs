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
    public sealed class MCTagDto
         : MCElementDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(MCTagDto), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get { return _text.GetValue(); }
            set { _text.SetValue(value); }
        }
    
        private PropertyValue<string> _style = new PropertyValue<string>(nameof(MCTagDto), nameof(Style));
        
        [Required]
        [JsonPropertyName("style")]
        public string Style
        {
            get { return _style.GetValue(); }
            set { _style.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _text.SetAccessPath(path + "->WithText()", validateHasBeenSet);
            _style.SetAccessPath(path + "->WithStyle()", validateHasBeenSet);
        }
    
    }
    
}
