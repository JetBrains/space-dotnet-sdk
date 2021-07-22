// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class M2ChannelContentCodeReviewDiscussion
         : M2ChannelContactInfo, M2ChannelContentInfo, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2ChannelContentCodeReviewDiscussion";
        
        public M2ChannelContentCodeReviewDiscussion() { }
        
        public M2ChannelContentCodeReviewDiscussion(string codeReviewDiscussion, ChannelSpecificDefaults notificationDefaults)
        {
            CodeReviewDiscussion = codeReviewDiscussion;
            NotificationDefaults = notificationDefaults;
        }
        
        private PropertyValue<string> _codeReviewDiscussion = new PropertyValue<string>(nameof(M2ChannelContentCodeReviewDiscussion), nameof(CodeReviewDiscussion));
        
        [Required]
        [JsonPropertyName("codeReviewDiscussion")]
        public string CodeReviewDiscussion
        {
            get => _codeReviewDiscussion.GetValue();
            set => _codeReviewDiscussion.SetValue(value);
        }
    
        private PropertyValue<ChannelSpecificDefaults> _notificationDefaults = new PropertyValue<ChannelSpecificDefaults>(nameof(M2ChannelContentCodeReviewDiscussion), nameof(NotificationDefaults));
        
        [Required]
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaults NotificationDefaults
        {
            get => _notificationDefaults.GetValue();
            set => _notificationDefaults.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _codeReviewDiscussion.SetAccessPath(path, validateHasBeenSet);
            _notificationDefaults.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
