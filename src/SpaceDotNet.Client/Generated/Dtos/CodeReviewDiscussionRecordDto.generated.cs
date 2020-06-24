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
    public sealed class CodeReviewDiscussionRecordDto
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(CodeReviewDiscussionRecordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<CodeReviewRecordDto> _review = new PropertyValue<CodeReviewRecordDto>(nameof(CodeReviewDiscussionRecordDto), nameof(Review));
        
        [Required]
        [JsonPropertyName("review")]
        public CodeReviewRecordDto Review
        {
            get { return _review.GetValue(); }
            set { _review.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _created = new PropertyValue<SpaceTime>(nameof(CodeReviewDiscussionRecordDto), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        public SpaceTime Created
        {
            get { return _created.GetValue(); }
            set { _created.SetValue(value); }
        }
    
        private PropertyValue<M2ChannelRecordDto> _channel = new PropertyValue<M2ChannelRecordDto>(nameof(CodeReviewDiscussionRecordDto), nameof(Channel));
        
        [Required]
        [JsonPropertyName("channel")]
        public M2ChannelRecordDto Channel
        {
            get { return _channel.GetValue(); }
            set { _channel.SetValue(value); }
        }
    
        private PropertyValue<bool> _resolved = new PropertyValue<bool>(nameof(CodeReviewDiscussionRecordDto), nameof(Resolved));
        
        [Required]
        [JsonPropertyName("resolved")]
        public bool Resolved
        {
            get { return _resolved.GetValue(); }
            set { _resolved.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _review.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _channel.SetAccessPath(path, validateHasBeenSet);
            _resolved.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
