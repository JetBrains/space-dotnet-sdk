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
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class CodeReviewDiscussionAddedFeedEventDto
         : FeedEventDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "CodeReviewDiscussionAddedFeedEvent";
        
        public CodeReviewDiscussionAddedFeedEventDto() { }
        
        public CodeReviewDiscussionAddedFeedEventDto(CodeReviewDiscussionRecordDto discussion)
        {
            Discussion = discussion;
        }
        
        private PropertyValue<CodeReviewDiscussionRecordDto> _discussion = new PropertyValue<CodeReviewDiscussionRecordDto>(nameof(CodeReviewDiscussionAddedFeedEventDto), nameof(Discussion));
        
        [Required]
        [JsonPropertyName("discussion")]
        public CodeReviewDiscussionRecordDto Discussion
        {
            get { return _discussion.GetValue(); }
            set { _discussion.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _discussion.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
