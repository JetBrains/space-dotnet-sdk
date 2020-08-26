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
    public sealed class AllReactionsToItemRecordDto
         : IPropagatePropertyAccessPath
    {
        public AllReactionsToItemRecordDto() { }
        
        public AllReactionsToItemRecordDto(string id, List<CertainReactionToItemRecordDto> reactions, List<EmojiReactionRecordDto>? emojiReactions = null)
        {
            Id = id;
            Reactions = reactions;
            EmojiReactions = emojiReactions;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(AllReactionsToItemRecordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<List<CertainReactionToItemRecordDto>> _reactions = new PropertyValue<List<CertainReactionToItemRecordDto>>(nameof(AllReactionsToItemRecordDto), nameof(Reactions));
        
        [Required]
        [JsonPropertyName("reactions")]
        public List<CertainReactionToItemRecordDto> Reactions
        {
            get { return _reactions.GetValue(); }
            set { _reactions.SetValue(value); }
        }
    
        private PropertyValue<List<EmojiReactionRecordDto>?> _emojiReactions = new PropertyValue<List<EmojiReactionRecordDto>?>(nameof(AllReactionsToItemRecordDto), nameof(EmojiReactions));
        
        [JsonPropertyName("emojiReactions")]
        public List<EmojiReactionRecordDto>? EmojiReactions
        {
            get { return _emojiReactions.GetValue(); }
            set { _emojiReactions.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _reactions.SetAccessPath(path, validateHasBeenSet);
            _emojiReactions.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
