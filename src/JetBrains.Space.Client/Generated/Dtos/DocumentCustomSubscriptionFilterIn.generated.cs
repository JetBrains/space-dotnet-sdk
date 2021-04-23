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

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
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
    public sealed class DocumentCustomSubscriptionFilterIn
         : SubscriptionFilterIn, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "DocumentCustomSubscriptionFilterIn";
        
        public DocumentCustomSubscriptionFilterIn() { }
        
        public DocumentCustomSubscriptionFilterIn(List<string> documents)
        {
            Documents = documents;
        }
        
        private PropertyValue<List<string>> _documents = new PropertyValue<List<string>>(nameof(DocumentCustomSubscriptionFilterIn), nameof(Documents), new List<string>());
        
        [Required]
        [JsonPropertyName("documents")]
        public List<string> Documents
        {
            get => _documents.GetValue();
            set => _documents.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _documents.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
