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
    public sealed class CodeDiscussionSnippetInlineDiffSnippetDto
         : CodeDiscussionSnippetDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        private PropertyValue<List<InlineDiffLineDto>> _lines = new PropertyValue<List<InlineDiffLineDto>>(nameof(CodeDiscussionSnippetInlineDiffSnippetDto), nameof(Lines));
        
        [Required]
        [JsonPropertyName("lines")]
        public List<InlineDiffLineDto> Lines
        {
            get { return _lines.GetValue(); }
            set { _lines.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _lines.SetAccessPath(path + "->WithLines()", validateHasBeenSet);
        }
    
    }
    
}
