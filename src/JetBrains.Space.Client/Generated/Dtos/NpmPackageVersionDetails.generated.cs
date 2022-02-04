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

namespace JetBrains.Space.Client;

public sealed class NpmPackageVersionDetails
     : PackageVersionDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "NpmPackageVersionDetails";
    
    public NpmPackageVersionDetails() { }
    
    public NpmPackageVersionDetails(PackageType type, string repository, string name, string version, long created, long downloads, bool pinned, long diskSize, List<NpmPackageDependency> dependencies, List<string> keywords, List<string>? tags = null, long? accessed = null, string? comment = null, CPrincipal? author = null, List<CPrincipal>? authors = null, PackageOrigin? origin = null, Dictionary<string, string>? metadata = null, string? description = null, string? license = null, string? projectUrl = null, string? repositoryUrl = null, string? repositoryRevision = null, string? readme = null, string? unityVersion = null)
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
        UnityVersion = unityVersion;
    }
    
    private PropertyValue<PackageType> _type = new PropertyValue<PackageType>(nameof(NpmPackageVersionDetails), nameof(Type), "type");
    
    [Required]
    [JsonPropertyName("type")]
    public PackageType Type
    {
        get => _type.GetValue(InlineErrors);
        set => _type.SetValue(value);
    }

    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(NpmPackageVersionDetails), nameof(Repository), "repository");
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue(InlineErrors);
        set => _repository.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(NpmPackageVersionDetails), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string> _version = new PropertyValue<string>(nameof(NpmPackageVersionDetails), nameof(Version), "version");
    
    [Required]
    [JsonPropertyName("version")]
    public string Version
    {
        get => _version.GetValue(InlineErrors);
        set => _version.SetValue(value);
    }

    private PropertyValue<List<string>?> _tags = new PropertyValue<List<string>?>(nameof(NpmPackageVersionDetails), nameof(Tags), "tags");
    
    [JsonPropertyName("tags")]
    public List<string>? Tags
    {
        get => _tags.GetValue(InlineErrors);
        set => _tags.SetValue(value);
    }

    private PropertyValue<long> _created = new PropertyValue<long>(nameof(NpmPackageVersionDetails), nameof(Created), "created");
    
    [Required]
    [JsonPropertyName("created")]
    public long Created
    {
        get => _created.GetValue(InlineErrors);
        set => _created.SetValue(value);
    }

    private PropertyValue<long?> _accessed = new PropertyValue<long?>(nameof(NpmPackageVersionDetails), nameof(Accessed), "accessed");
    
    [JsonPropertyName("accessed")]
    public long? Accessed
    {
        get => _accessed.GetValue(InlineErrors);
        set => _accessed.SetValue(value);
    }

    private PropertyValue<long> _downloads = new PropertyValue<long>(nameof(NpmPackageVersionDetails), nameof(Downloads), "downloads");
    
    [Required]
    [JsonPropertyName("downloads")]
    public long Downloads
    {
        get => _downloads.GetValue(InlineErrors);
        set => _downloads.SetValue(value);
    }

    private PropertyValue<bool> _pinned = new PropertyValue<bool>(nameof(NpmPackageVersionDetails), nameof(IsPinned), "pinned");
    
    [Required]
    [JsonPropertyName("pinned")]
    public bool IsPinned
    {
        get => _pinned.GetValue(InlineErrors);
        set => _pinned.SetValue(value);
    }

    private PropertyValue<string?> _comment = new PropertyValue<string?>(nameof(NpmPackageVersionDetails), nameof(Comment), "comment");
    
    [JsonPropertyName("comment")]
    public string? Comment
    {
        get => _comment.GetValue(InlineErrors);
        set => _comment.SetValue(value);
    }

    private PropertyValue<long> _diskSize = new PropertyValue<long>(nameof(NpmPackageVersionDetails), nameof(DiskSize), "diskSize");
    
    [Required]
    [JsonPropertyName("diskSize")]
    public long DiskSize
    {
        get => _diskSize.GetValue(InlineErrors);
        set => _diskSize.SetValue(value);
    }

    private PropertyValue<CPrincipal?> _author = new PropertyValue<CPrincipal?>(nameof(NpmPackageVersionDetails), nameof(Author), "author");
    
    [JsonPropertyName("author")]
    public CPrincipal? Author
    {
        get => _author.GetValue(InlineErrors);
        set => _author.SetValue(value);
    }

    private PropertyValue<List<CPrincipal>?> _authors = new PropertyValue<List<CPrincipal>?>(nameof(NpmPackageVersionDetails), nameof(Authors), "authors");
    
    [JsonPropertyName("authors")]
    public List<CPrincipal>? Authors
    {
        get => _authors.GetValue(InlineErrors);
        set => _authors.SetValue(value);
    }

    private PropertyValue<PackageOrigin?> _origin = new PropertyValue<PackageOrigin?>(nameof(NpmPackageVersionDetails), nameof(Origin), "origin");
    
    [JsonPropertyName("origin")]
    public PackageOrigin? Origin
    {
        get => _origin.GetValue(InlineErrors);
        set => _origin.SetValue(value);
    }

    private PropertyValue<Dictionary<string, string>?> _metadata = new PropertyValue<Dictionary<string, string>?>(nameof(NpmPackageVersionDetails), nameof(Metadata), "metadata");
    
    [JsonPropertyName("metadata")]
    public Dictionary<string, string>? Metadata
    {
        get => _metadata.GetValue(InlineErrors);
        set => _metadata.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(NpmPackageVersionDetails), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<List<NpmPackageDependency>> _dependencies = new PropertyValue<List<NpmPackageDependency>>(nameof(NpmPackageVersionDetails), nameof(Dependencies), "dependencies", new List<NpmPackageDependency>());
    
    [Required]
    [JsonPropertyName("dependencies")]
    public List<NpmPackageDependency> Dependencies
    {
        get => _dependencies.GetValue(InlineErrors);
        set => _dependencies.SetValue(value);
    }

    private PropertyValue<List<string>> _keywords = new PropertyValue<List<string>>(nameof(NpmPackageVersionDetails), nameof(Keywords), "keywords", new List<string>());
    
    [Required]
    [JsonPropertyName("keywords")]
    public List<string> Keywords
    {
        get => _keywords.GetValue(InlineErrors);
        set => _keywords.SetValue(value);
    }

    private PropertyValue<string?> _license = new PropertyValue<string?>(nameof(NpmPackageVersionDetails), nameof(License), "license");
    
    [JsonPropertyName("license")]
    public string? License
    {
        get => _license.GetValue(InlineErrors);
        set => _license.SetValue(value);
    }

    private PropertyValue<string?> _projectUrl = new PropertyValue<string?>(nameof(NpmPackageVersionDetails), nameof(ProjectUrl), "projectUrl");
    
    [JsonPropertyName("projectUrl")]
    public string? ProjectUrl
    {
        get => _projectUrl.GetValue(InlineErrors);
        set => _projectUrl.SetValue(value);
    }

    private PropertyValue<string?> _repositoryUrl = new PropertyValue<string?>(nameof(NpmPackageVersionDetails), nameof(RepositoryUrl), "repositoryUrl");
    
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl
    {
        get => _repositoryUrl.GetValue(InlineErrors);
        set => _repositoryUrl.SetValue(value);
    }

    private PropertyValue<string?> _repositoryRevision = new PropertyValue<string?>(nameof(NpmPackageVersionDetails), nameof(RepositoryRevision), "repositoryRevision");
    
    [JsonPropertyName("repositoryRevision")]
    public string? RepositoryRevision
    {
        get => _repositoryRevision.GetValue(InlineErrors);
        set => _repositoryRevision.SetValue(value);
    }

    private PropertyValue<string?> _readme = new PropertyValue<string?>(nameof(NpmPackageVersionDetails), nameof(Readme), "readme");
    
    [JsonPropertyName("readme")]
    public string? Readme
    {
        get => _readme.GetValue(InlineErrors);
        set => _readme.SetValue(value);
    }

    private PropertyValue<string?> _unityVersion = new PropertyValue<string?>(nameof(NpmPackageVersionDetails), nameof(UnityVersion), "unityVersion");
    
    [JsonPropertyName("unityVersion")]
    public string? UnityVersion
    {
        get => _unityVersion.GetValue(InlineErrors);
        set => _unityVersion.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _type.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repository.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _version.SetAccessPath(parentChainPath, validateHasBeenSet);
        _tags.SetAccessPath(parentChainPath, validateHasBeenSet);
        _created.SetAccessPath(parentChainPath, validateHasBeenSet);
        _accessed.SetAccessPath(parentChainPath, validateHasBeenSet);
        _downloads.SetAccessPath(parentChainPath, validateHasBeenSet);
        _pinned.SetAccessPath(parentChainPath, validateHasBeenSet);
        _comment.SetAccessPath(parentChainPath, validateHasBeenSet);
        _diskSize.SetAccessPath(parentChainPath, validateHasBeenSet);
        _author.SetAccessPath(parentChainPath, validateHasBeenSet);
        _authors.SetAccessPath(parentChainPath, validateHasBeenSet);
        _origin.SetAccessPath(parentChainPath, validateHasBeenSet);
        _metadata.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _dependencies.SetAccessPath(parentChainPath, validateHasBeenSet);
        _keywords.SetAccessPath(parentChainPath, validateHasBeenSet);
        _license.SetAccessPath(parentChainPath, validateHasBeenSet);
        _projectUrl.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repositoryUrl.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repositoryRevision.SetAccessPath(parentChainPath, validateHasBeenSet);
        _readme.SetAccessPath(parentChainPath, validateHasBeenSet);
        _unityVersion.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

