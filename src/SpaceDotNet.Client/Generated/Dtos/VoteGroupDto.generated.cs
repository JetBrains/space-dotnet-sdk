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
    public sealed class VoteGroupDto
    {
        private PropertyValue<string> _variantName = new PropertyValue<string>(nameof(VoteGroupDto), nameof(VariantName));
        
        [Required]
        [JsonPropertyName("variantName")]
        public string VariantName { get { return _variantName.GetValue(); } set { _variantName.SetValue(value); } }
    
        private PropertyValue<int> _count = new PropertyValue<int>(nameof(VoteGroupDto), nameof(Count));
        
        [Required]
        [JsonPropertyName("count")]
        public int Count { get { return _count.GetValue(); } set { _count.SetValue(value); } }
    
        private PropertyValue<bool> _meVote = new PropertyValue<bool>(nameof(VoteGroupDto), nameof(MeVote));
        
        [Required]
        [JsonPropertyName("meVote")]
        public bool MeVote { get { return _meVote.GetValue(); } set { _meVote.SetValue(value); } }
    
        private PropertyValue<List<TDMemberProfileDto>> _lastUsers = new PropertyValue<List<TDMemberProfileDto>>(nameof(VoteGroupDto), nameof(LastUsers));
        
        [Required]
        [JsonPropertyName("lastUsers")]
        public List<TDMemberProfileDto> LastUsers { get { return _lastUsers.GetValue(); } set { _lastUsers.SetValue(value); } }
    
        private PropertyValue<TDMemberProfileDto?> _owner = new PropertyValue<TDMemberProfileDto?>(nameof(VoteGroupDto), nameof(Owner));
        
        [JsonPropertyName("owner")]
        public TDMemberProfileDto? Owner { get { return _owner.GetValue(); } set { _owner.SetValue(value); } }
    
    }
    
}
