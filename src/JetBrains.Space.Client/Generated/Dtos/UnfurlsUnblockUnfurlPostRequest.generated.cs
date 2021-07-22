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
    public class UnfurlsUnblockUnfurlPostRequest
         : IPropagatePropertyAccessPath
    {
        public UnfurlsUnblockUnfurlPostRequest() { }
        
        public UnfurlsUnblockUnfurlPostRequest(string link, bool wholeHost)
        {
            Link = link;
            IsWholeHost = wholeHost;
        }
        
        private PropertyValue<string> _link = new PropertyValue<string>(nameof(UnfurlsUnblockUnfurlPostRequest), nameof(Link));
        
        [Required]
        [JsonPropertyName("link")]
        public string Link
        {
            get => _link.GetValue();
            set => _link.SetValue(value);
        }
    
        private PropertyValue<bool> _wholeHost = new PropertyValue<bool>(nameof(UnfurlsUnblockUnfurlPostRequest), nameof(IsWholeHost));
        
        [Required]
        [JsonPropertyName("wholeHost")]
        public bool IsWholeHost
        {
            get => _wholeHost.GetValue();
            set => _wholeHost.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _link.SetAccessPath(path, validateHasBeenSet);
            _wholeHost.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
