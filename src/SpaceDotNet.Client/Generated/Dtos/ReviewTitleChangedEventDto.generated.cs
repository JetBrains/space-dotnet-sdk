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
    public sealed class ReviewTitleChangedEventDto
         : FeedEventDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<string> _oldTitle = new PropertyValue<string>(nameof(ReviewTitleChangedEventDto), nameof(OldTitle));
        
        [Required]
        [JsonPropertyName("oldTitle")]
        public string OldTitle
        {
            get { return _oldTitle.GetValue(); }
            set { _oldTitle.SetValue(value); }
        }
    
        private PropertyValue<string> _newTitle = new PropertyValue<string>(nameof(ReviewTitleChangedEventDto), nameof(NewTitle));
        
        [Required]
        [JsonPropertyName("newTitle")]
        public string NewTitle
        {
            get { return _newTitle.GetValue(); }
            set { _newTitle.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _oldTitle.SetAccessPath(path, validateHasBeenSet);
            _newTitle.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
