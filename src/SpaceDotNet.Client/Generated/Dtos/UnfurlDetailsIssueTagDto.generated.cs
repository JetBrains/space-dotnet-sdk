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
    public sealed class UnfurlDetailsIssueTagDto
         : UnfurlDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "UnfurlDetailsIssueTag";
        
        public UnfurlDetailsIssueTagDto() { }
        
        public UnfurlDetailsIssueTagDto(PlanningTagDto tag, bool strikeThrough)
        {
            Tag = tag;
            StrikeThrough = strikeThrough;
        }
        
        private PropertyValue<PlanningTagDto> _tag = new PropertyValue<PlanningTagDto>(nameof(UnfurlDetailsIssueTagDto), nameof(Tag));
        
        [Required]
        [JsonPropertyName("tag")]
        public PlanningTagDto Tag
        {
            get { return _tag.GetValue(); }
            set { _tag.SetValue(value); }
        }
    
        private PropertyValue<bool> _strikeThrough = new PropertyValue<bool>(nameof(UnfurlDetailsIssueTagDto), nameof(StrikeThrough));
        
        [Required]
        [JsonPropertyName("strikeThrough")]
        public bool StrikeThrough
        {
            get { return _strikeThrough.GetValue(); }
            set { _strikeThrough.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _tag.SetAccessPath(path, validateHasBeenSet);
            _strikeThrough.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
