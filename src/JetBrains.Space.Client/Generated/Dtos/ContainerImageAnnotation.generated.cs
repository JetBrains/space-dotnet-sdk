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
    public sealed class ContainerImageAnnotation
         : IPropagatePropertyAccessPath
    {
        public ContainerImageAnnotation() { }
        
        public ContainerImageAnnotation(long? created = null, string? buildName = null, string? buildUrl = null, string? revision = null, string? vendor = null, string? documentationUrl = null, string? licenses = null)
        {
            Created = created;
            BuildName = buildName;
            BuildUrl = buildUrl;
            Revision = revision;
            Vendor = vendor;
            DocumentationUrl = documentationUrl;
            Licenses = licenses;
        }
        
        private PropertyValue<long?> _created = new PropertyValue<long?>(nameof(ContainerImageAnnotation), nameof(Created));
        
        [JsonPropertyName("created")]
        public long? Created
        {
            get => _created.GetValue();
            set => _created.SetValue(value);
        }
    
        private PropertyValue<string?> _buildName = new PropertyValue<string?>(nameof(ContainerImageAnnotation), nameof(BuildName));
        
        [JsonPropertyName("buildName")]
        public string? BuildName
        {
            get => _buildName.GetValue();
            set => _buildName.SetValue(value);
        }
    
        private PropertyValue<string?> _buildUrl = new PropertyValue<string?>(nameof(ContainerImageAnnotation), nameof(BuildUrl));
        
        [JsonPropertyName("buildUrl")]
        public string? BuildUrl
        {
            get => _buildUrl.GetValue();
            set => _buildUrl.SetValue(value);
        }
    
        private PropertyValue<string?> _revision = new PropertyValue<string?>(nameof(ContainerImageAnnotation), nameof(Revision));
        
        [JsonPropertyName("revision")]
        public string? Revision
        {
            get => _revision.GetValue();
            set => _revision.SetValue(value);
        }
    
        private PropertyValue<string?> _vendor = new PropertyValue<string?>(nameof(ContainerImageAnnotation), nameof(Vendor));
        
        [JsonPropertyName("vendor")]
        public string? Vendor
        {
            get => _vendor.GetValue();
            set => _vendor.SetValue(value);
        }
    
        private PropertyValue<string?> _documentationUrl = new PropertyValue<string?>(nameof(ContainerImageAnnotation), nameof(DocumentationUrl));
        
        [JsonPropertyName("documentationUrl")]
        public string? DocumentationUrl
        {
            get => _documentationUrl.GetValue();
            set => _documentationUrl.SetValue(value);
        }
    
        private PropertyValue<string?> _licenses = new PropertyValue<string?>(nameof(ContainerImageAnnotation), nameof(Licenses));
        
        [JsonPropertyName("licenses")]
        public string? Licenses
        {
            get => _licenses.GetValue();
            set => _licenses.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _created.SetAccessPath(path, validateHasBeenSet);
            _buildName.SetAccessPath(path, validateHasBeenSet);
            _buildUrl.SetAccessPath(path, validateHasBeenSet);
            _revision.SetAccessPath(path, validateHasBeenSet);
            _vendor.SetAccessPath(path, validateHasBeenSet);
            _documentationUrl.SetAccessPath(path, validateHasBeenSet);
            _licenses.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
