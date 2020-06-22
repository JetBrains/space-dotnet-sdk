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
    public sealed class UnfurlDetailsCodeSnippetDto
         : UnfurlDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<CodeSnippetAnchorDto> _anchor = new PropertyValue<CodeSnippetAnchorDto>(nameof(UnfurlDetailsCodeSnippetDto), nameof(Anchor));
        
        [Required]
        [JsonPropertyName("anchor")]
        public CodeSnippetAnchorDto Anchor
        {
            get { return _anchor.GetValue(); }
            set { _anchor.SetValue(value); }
        }
    
        private PropertyValue<List<CodeLineDto>> _lines = new PropertyValue<List<CodeLineDto>>(nameof(UnfurlDetailsCodeSnippetDto), nameof(Lines));
        
        [Required]
        [JsonPropertyName("lines")]
        public List<CodeLineDto> Lines
        {
            get { return _lines.GetValue(); }
            set { _lines.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _anchor.SetAccessPath(path + "->WithAnchor()", validateHasBeenSet);
            _lines.SetAccessPath(path + "->WithLines()", validateHasBeenSet);
        }
    
    }
    
}
