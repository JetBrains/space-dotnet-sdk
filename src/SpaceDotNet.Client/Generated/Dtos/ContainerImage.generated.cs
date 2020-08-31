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
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class ContainerImage
         : IPropagatePropertyAccessPath
    {
        public ContainerImage() { }
        
        public ContainerImage(List<ContainerImageLayer> history, List<ContainerManifest> children, string? name = null, string? description = null, List<string>? tags = null, string? projectUrl = null, string? sourceUrl = null, string? version = null, ContainerImagePlatform? platform = null, ContainerImageConfig? config = null, ContainerImageAnnotation? annotation = null)
        {
            Name = name;
            Description = description;
            Tags = tags;
            ProjectUrl = projectUrl;
            SourceUrl = sourceUrl;
            Version = version;
            Platform = platform;
            History = history;
            Children = children;
            Config = config;
            Annotation = annotation;
        }
        
        private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(ContainerImage), nameof(Name));
        
        [JsonPropertyName("name")]
        public string? Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ContainerImage), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _tags = new PropertyValue<List<string>?>(nameof(ContainerImage), nameof(Tags));
        
        [JsonPropertyName("tags")]
        public List<string>? Tags
        {
            get { return _tags.GetValue(); }
            set { _tags.SetValue(value); }
        }
    
        private PropertyValue<string?> _projectUrl = new PropertyValue<string?>(nameof(ContainerImage), nameof(ProjectUrl));
        
        [JsonPropertyName("projectUrl")]
        public string? ProjectUrl
        {
            get { return _projectUrl.GetValue(); }
            set { _projectUrl.SetValue(value); }
        }
    
        private PropertyValue<string?> _sourceUrl = new PropertyValue<string?>(nameof(ContainerImage), nameof(SourceUrl));
        
        [JsonPropertyName("sourceUrl")]
        public string? SourceUrl
        {
            get { return _sourceUrl.GetValue(); }
            set { _sourceUrl.SetValue(value); }
        }
    
        private PropertyValue<string?> _version = new PropertyValue<string?>(nameof(ContainerImage), nameof(Version));
        
        [JsonPropertyName("version")]
        public string? Version
        {
            get { return _version.GetValue(); }
            set { _version.SetValue(value); }
        }
    
        private PropertyValue<ContainerImagePlatform?> _platform = new PropertyValue<ContainerImagePlatform?>(nameof(ContainerImage), nameof(Platform));
        
        [JsonPropertyName("platform")]
        public ContainerImagePlatform? Platform
        {
            get { return _platform.GetValue(); }
            set { _platform.SetValue(value); }
        }
    
        private PropertyValue<List<ContainerImageLayer>> _history = new PropertyValue<List<ContainerImageLayer>>(nameof(ContainerImage), nameof(History));
        
        [Required]
        [JsonPropertyName("history")]
        public List<ContainerImageLayer> History
        {
            get { return _history.GetValue(); }
            set { _history.SetValue(value); }
        }
    
        private PropertyValue<List<ContainerManifest>> _children = new PropertyValue<List<ContainerManifest>>(nameof(ContainerImage), nameof(Children));
        
        [Required]
        [JsonPropertyName("children")]
        public List<ContainerManifest> Children
        {
            get { return _children.GetValue(); }
            set { _children.SetValue(value); }
        }
    
        private PropertyValue<ContainerImageConfig?> _config = new PropertyValue<ContainerImageConfig?>(nameof(ContainerImage), nameof(Config));
        
        [JsonPropertyName("config")]
        public ContainerImageConfig? Config
        {
            get { return _config.GetValue(); }
            set { _config.SetValue(value); }
        }
    
        private PropertyValue<ContainerImageAnnotation?> _annotation = new PropertyValue<ContainerImageAnnotation?>(nameof(ContainerImage), nameof(Annotation));
        
        [JsonPropertyName("annotation")]
        public ContainerImageAnnotation? Annotation
        {
            get { return _annotation.GetValue(); }
            set { _annotation.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _tags.SetAccessPath(path, validateHasBeenSet);
            _projectUrl.SetAccessPath(path, validateHasBeenSet);
            _sourceUrl.SetAccessPath(path, validateHasBeenSet);
            _version.SetAccessPath(path, validateHasBeenSet);
            _platform.SetAccessPath(path, validateHasBeenSet);
            _history.SetAccessPath(path, validateHasBeenSet);
            _children.SetAccessPath(path, validateHasBeenSet);
            _config.SetAccessPath(path, validateHasBeenSet);
            _annotation.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
