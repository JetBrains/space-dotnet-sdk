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
    public sealed class M2TextItemContent
         : M2ItemContentDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2TextItemContent";
        
        public M2TextItemContent() { }
        
        public M2TextItemContent(bool? markdown = null)
        {
            IsMarkdown = markdown;
        }
        
        private PropertyValue<bool?> _markdown = new PropertyValue<bool?>(nameof(M2TextItemContent), nameof(IsMarkdown));
        
        [JsonPropertyName("markdown")]
        public bool? IsMarkdown
        {
            get => _markdown.GetValue();
            set => _markdown.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _markdown.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
