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
    public sealed class DocumentWebhookEvent
         : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "DocumentWebhookEvent";
        
        public DocumentWebhookEvent() { }
        
        public DocumentWebhookEvent(KMetaMod meta, string document, List<CPrincipal> changeAuthors, DateTime version, DateTime @base)
        {
            Meta = meta;
            Document = document;
            ChangeAuthors = changeAuthors;
            Version = version;
            Base = @base;
        }
        
        private PropertyValue<KMetaMod> _meta = new PropertyValue<KMetaMod>(nameof(DocumentWebhookEvent), nameof(Meta));
        
        [Required]
        [JsonPropertyName("meta")]
        public KMetaMod Meta
        {
            get => _meta.GetValue();
            set => _meta.SetValue(value);
        }
    
        private PropertyValue<string> _document = new PropertyValue<string>(nameof(DocumentWebhookEvent), nameof(Document));
        
        [Required]
        [JsonPropertyName("document")]
        public string Document
        {
            get => _document.GetValue();
            set => _document.SetValue(value);
        }
    
        private PropertyValue<List<CPrincipal>> _changeAuthors = new PropertyValue<List<CPrincipal>>(nameof(DocumentWebhookEvent), nameof(ChangeAuthors), new List<CPrincipal>());
        
        [Required]
        [JsonPropertyName("changeAuthors")]
        public List<CPrincipal> ChangeAuthors
        {
            get => _changeAuthors.GetValue();
            set => _changeAuthors.SetValue(value);
        }
    
        private PropertyValue<DateTime> _version = new PropertyValue<DateTime>(nameof(DocumentWebhookEvent), nameof(Version));
        
        [Required]
        [JsonPropertyName("version")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime Version
        {
            get => _version.GetValue();
            set => _version.SetValue(value);
        }
    
        private PropertyValue<DateTime> _base = new PropertyValue<DateTime>(nameof(DocumentWebhookEvent), nameof(Base));
        
        [Required]
        [JsonPropertyName("base")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime Base
        {
            get => _base.GetValue();
            set => _base.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _meta.SetAccessPath(path, validateHasBeenSet);
            _document.SetAccessPath(path, validateHasBeenSet);
            _changeAuthors.SetAccessPath(path, validateHasBeenSet);
            _version.SetAccessPath(path, validateHasBeenSet);
            _base.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}