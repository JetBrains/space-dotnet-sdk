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
    public sealed class MCSectionDto
         : MCElementDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<MCTextDto?> _header = new PropertyValue<MCTextDto?>(nameof(MCSectionDto), nameof(Header));
        
        [JsonPropertyName("header")]
        public MCTextDto? Header
        {
            get { return _header.GetValue(); }
            set { _header.SetValue(value); }
        }
    
        private PropertyValue<List<MCElementDto>> _elements = new PropertyValue<List<MCElementDto>>(nameof(MCSectionDto), nameof(Elements));
        
        [Required]
        [JsonPropertyName("elements")]
        public List<MCElementDto> Elements
        {
            get { return _elements.GetValue(); }
            set { _elements.SetValue(value); }
        }
    
        private PropertyValue<MCTextDto?> _footer = new PropertyValue<MCTextDto?>(nameof(MCSectionDto), nameof(Footer));
        
        [JsonPropertyName("footer")]
        public MCTextDto? Footer
        {
            get { return _footer.GetValue(); }
            set { _footer.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _header.SetAccessPath(path + "->WithHeader()", validateHasBeenSet);
            _elements.SetAccessPath(path + "->WithElements()", validateHasBeenSet);
            _footer.SetAccessPath(path + "->WithFooter()", validateHasBeenSet);
        }
    
    }
    
}
