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
    public sealed class ReviewerChangedEventDto
         : FeedEventDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<TDMemberProfileDto> _uid = new PropertyValue<TDMemberProfileDto>(nameof(ReviewerChangedEventDto), nameof(Uid));
        
        [Required]
        [JsonPropertyName("uid")]
        public TDMemberProfileDto Uid
        {
            get { return _uid.GetValue(); }
            set { _uid.SetValue(value); }
        }
    
        private PropertyValue<ReviewerChangedType> _changeType = new PropertyValue<ReviewerChangedType>(nameof(ReviewerChangedEventDto), nameof(ChangeType));
        
        [Required]
        [JsonPropertyName("changeType")]
        public ReviewerChangedType ChangeType
        {
            get { return _changeType.GetValue(); }
            set { _changeType.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _uid.SetAccessPath(path + "->WithUid()", validateHasBeenSet);
            _changeType.SetAccessPath(path + "->WithChangeType()", validateHasBeenSet);
        }
    
    }
    
}
