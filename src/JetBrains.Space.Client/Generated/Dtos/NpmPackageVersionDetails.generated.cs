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
    public sealed class NpmPackageVersionDetails
         : PackageVersionDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "NpmPackageVersionDetails";
        
        public NpmPackageVersionDetails() { }
        
        public NpmPackageVersionDetails(PackageType type, string repository, string name, string version, long created, long downloads, bool pinned, long diskSize, List<NpmPackageDependency> dependencies, List<string> keywords, List<string>? tags = null, long? accessed = null, string? comment = null, CPrincipal? author = null, List<CPrincipal>? authors = null, PackageOrigin? origin = null, Dictionary<string, string>? metadata = null, string? description = null, string? license = null, string? projectUrl = null, string? repositoryUrl = null, string? repositoryRevision = null, string? readme = null)
        {
            Type = type;
            Repository = repository;
            Name = name;
            Version = version;
            Tags = tags;
            Created = created;
            Accessed = accessed;
            Downloads = downloads;
            IsPinned = pinned;
            Comment = comment;
            DiskSize = diskSize;
            Author = author;
            Authors = authors;
            Origin = origin;
            Metadata = metadata;
            Description = description;
            Dependencies = dependencies;
            Keywords = keywords;
            License = license;
            ProjectUrl = projectUrl;
            RepositoryUrl = repositoryUrl;
            RepositoryRevision = repositoryRevision;
            Readme = readme;
        }
        
        private PropertyValue<PackageType> _type = new PropertyValue<PackageType>(nameof(NpmPackageVersionDetails), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public PackageType Type
        {
            get => _type.GetValue();
            set => _type.SetValue(value);
        }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(NpmPackageVersionDetails), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(NpmPackageVersionDetails), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _version = new PropertyValue<string>(nameof(NpmPackageVersionDetails), nameof(Version));
        
        [Required]
        [JsonPropertyName("version")]
        public string Version
        {
            get => _version.GetValue();
            set => _version.SetValue(value);
        }
    
        private PropertyValue<List<string>?> _tags = new PropertyValue<List<string>?>(nameof(NpmPackageVersionDetails), nameof(Tags));
        
        [JsonPropertyName("tags")]
        public List<string>? Tags
        {
            get => _tags.GetValue();
            set => _tags.SetValue(value);
        }
    
        private PropertyValue<long> _created = new PropertyValue<long>(nameof(NpmPackageVersionDetails), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        public long Created
        {
            get => _created.GetValue();
            set => _created.SetValue(value);
        }
    
        private PropertyValue<long?> _accessed = new PropertyValue<long?>(nameof(NpmPackageVersionDetails), nameof(Accessed));
        
        [JsonPropertyName("accessed")]
        public long? Accessed
        {
            get => _accessed.GetValue();
            set => _accessed.SetValue(value);
        }
    
        private PropertyValue<long> _downloads = new PropertyValue<long>(nameof(NpmPackageVersionDetails), nameof(Downloads));
        
        [Required]
        [JsonPropertyName("downloads")]
        public long Downloads
        {
            get => _downloads.GetValue();
            set => _downloads.SetValue(value);
        }
    
        private PropertyValue<bool> _pinned = new PropertyValue<bool>(nameof(NpmPackageVersionDetails), nameof(IsPinned));
        
        [Required]
        [JsonPropertyName("pinned")]
        public bool IsPinned
        {
            get => _pinned.GetValue();
            set => _pinned.SetValue(value);
        }
    
        private PropertyValue<string?> _comment = new PropertyValue<string?>(nameof(NpmPackageVersionDetails), nameof(Comment));
        
        [JsonPropertyName("comment")]
        public string? Comment
        {
            get => _comment.GetValue();
            set => _comment.SetValue(value);
        }
    
        private PropertyValue<long> _diskSize = new PropertyValue<long>(nameof(NpmPackageVersionDetails), nameof(DiskSize));
        
        [Required]
        [JsonPropertyName("diskSize")]
        public long DiskSize
        {
            get => _diskSize.GetValue();
            set => _diskSize.SetValue(value);
        }
    
        private PropertyValue<CPrincipal?> _author = new PropertyValue<CPrincipal?>(nameof(NpmPackageVersionDetails), nameof(Author));
        
        [JsonPropertyName("author")]
        public CPrincipal? Author
        {
            get => _author.GetValue();
            set => _author.SetValue(value);
        }
    
        private PropertyValue<List<CPrincipal>?> _authors = new PropertyValue<List<CPrincipal>?>(nameof(NpmPackageVersionDetails), nameof(Authors));
        
        [JsonPropertyName("authors")]
        public List<CPrincipal>? Authors
        {
            get => _authors.GetValue();
            set => _authors.SetValue(value);
        }
    
        private PropertyValue<PackageOrigin?> _origin = new PropertyValue<PackageOrigin?>(nameof(NpmPackageVersionDetails), nameof(Origin));
        
        [JsonPropertyName("origin")]
        public PackageOrigin? Origin
        {
            get => _origin.GetValue();
            set => _origin.SetValue(value);
        }
    
        private PropertyValue<Dictionary<string, string>?> _metadata = new PropertyValue<Dictionary<string, string>?>(nameof(NpmPackageVersionDetails), nameof(Metadata));
        
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata
        {
            get => _metadata.GetValue();
            set => _metadata.SetValue(value);
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(NpmPackageVersionDetails), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<List<NpmPackageDependency>> _dependencies = new PropertyValue<List<NpmPackageDependency>>(nameof(NpmPackageVersionDetails), nameof(Dependencies), new List<NpmPackageDependency>());
        
        [Required]
        [JsonPropertyName("dependencies")]
        public List<NpmPackageDependency> Dependencies
        {
            get => _dependencies.GetValue();
            set => _dependencies.SetValue(value);
        }
    
        private PropertyValue<List<string>> _keywords = new PropertyValue<List<string>>(nameof(NpmPackageVersionDetails), nameof(Keywords), new List<string>());
        
        [Required]
        [JsonPropertyName("keywords")]
        public List<string> Keywords
        {
            get => _keywords.GetValue();
            set => _keywords.SetValue(value);
        }
    
        private PropertyValue<string?> _license = new PropertyValue<string?>(nameof(NpmPackageVersionDetails), nameof(License));
        
        [JsonPropertyName("license")]
        public string? License
        {
            get => _license.GetValue();
            set => _license.SetValue(value);
        }
    
        private PropertyValue<string?> _projectUrl = new PropertyValue<string?>(nameof(NpmPackageVersionDetails), nameof(ProjectUrl));
        
        [JsonPropertyName("projectUrl")]
        public string? ProjectUrl
        {
            get => _projectUrl.GetValue();
            set => _projectUrl.SetValue(value);
        }
    
        private PropertyValue<string?> _repositoryUrl = new PropertyValue<string?>(nameof(NpmPackageVersionDetails), nameof(RepositoryUrl));
        
        [JsonPropertyName("repositoryUrl")]
        public string? RepositoryUrl
        {
            get => _repositoryUrl.GetValue();
            set => _repositoryUrl.SetValue(value);
        }
    
        private PropertyValue<string?> _repositoryRevision = new PropertyValue<string?>(nameof(NpmPackageVersionDetails), nameof(RepositoryRevision));
        
        [JsonPropertyName("repositoryRevision")]
        public string? RepositoryRevision
        {
            get => _repositoryRevision.GetValue();
            set => _repositoryRevision.SetValue(value);
        }
    
        private PropertyValue<string?> _readme = new PropertyValue<string?>(nameof(NpmPackageVersionDetails), nameof(Readme));
        
        [JsonPropertyName("readme")]
        public string? Readme
        {
            get => _readme.GetValue();
            set => _readme.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _type.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _version.SetAccessPath(path, validateHasBeenSet);
            _tags.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _accessed.SetAccessPath(path, validateHasBeenSet);
            _downloads.SetAccessPath(path, validateHasBeenSet);
            _pinned.SetAccessPath(path, validateHasBeenSet);
            _comment.SetAccessPath(path, validateHasBeenSet);
            _diskSize.SetAccessPath(path, validateHasBeenSet);
            _author.SetAccessPath(path, validateHasBeenSet);
            _authors.SetAccessPath(path, validateHasBeenSet);
            _origin.SetAccessPath(path, validateHasBeenSet);
            _metadata.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _dependencies.SetAccessPath(path, validateHasBeenSet);
            _keywords.SetAccessPath(path, validateHasBeenSet);
            _license.SetAccessPath(path, validateHasBeenSet);
            _projectUrl.SetAccessPath(path, validateHasBeenSet);
            _repositoryUrl.SetAccessPath(path, validateHasBeenSet);
            _repositoryRevision.SetAccessPath(path, validateHasBeenSet);
            _readme.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
