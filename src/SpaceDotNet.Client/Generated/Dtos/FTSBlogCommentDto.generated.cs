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
    public sealed class FTSBlogCommentDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<TDMemberProfileDto> _author = new PropertyValue<TDMemberProfileDto>(nameof(FTSBlogCommentDto), nameof(Author));
        
        [Required]
        [JsonPropertyName("author")]
        public TDMemberProfileDto Author
        {
            get { return _author.GetValue(); }
            set { _author.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _date = new PropertyValue<SpaceTime>(nameof(FTSBlogCommentDto), nameof(Date));
        
        [Required]
        [JsonPropertyName("date")]
        public SpaceTime Date
        {
            get { return _date.GetValue(); }
            set { _date.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _snippets = new PropertyValue<List<string>>(nameof(FTSBlogCommentDto), nameof(Snippets));
        
        [Required]
        [JsonPropertyName("snippets")]
        public List<string> Snippets
        {
            get { return _snippets.GetValue(); }
            set { _snippets.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _author.SetAccessPath(path + "->WithAuthor()", validateHasBeenSet);
            _date.SetAccessPath(path + "->WithDate()", validateHasBeenSet);
            _snippets.SetAccessPath(path + "->WithSnippets()", validateHasBeenSet);
        }
    
    }
    
}
