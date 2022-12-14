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

public sealed class CratesPackageVersionDetails
     : PackageVersionDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "CratesPackageVersionDetails";
    
    public CratesPackageVersionDetails() { }
    
    public CratesPackageVersionDetails(string repository, string name, string version, long created, long downloads, bool pinned, long diskSize, List<CratesPackageDependency> dependencies, List<string> keywords, List<string> categories, List<string>? tags = null, long? accessed = null, string? comment = null, CPrincipal? author = null, List<CPrincipal>? authors = null, PackageOrigin? origin = null, Dictionary<string, string>? metadata = null, string? description = null, string? documentation = null, string? homepage = null, string? readme = null, string? license = null, string? licenseFileContent = null, string? gitRepository = null, string? links = null)
    {
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
        Dependencies = dependencies;
        Description = description;
        Documentation = documentation;
        Homepage = homepage;
        Readme = readme;
        Keywords = keywords;
        Categories = categories;
        License = license;
        LicenseFileContent = licenseFileContent;
        GitRepository = gitRepository;
        Links = links;
    }
    
    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(CratesPackageVersionDetails), nameof(Repository), "repository");
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue(InlineErrors);
        set => _repository.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(CratesPackageVersionDetails), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string> _version = new PropertyValue<string>(nameof(CratesPackageVersionDetails), nameof(Version), "version");
    
    [Required]
    [JsonPropertyName("version")]
    public string Version
    {
        get => _version.GetValue(InlineErrors);
        set => _version.SetValue(value);
    }

    private PropertyValue<List<string>?> _tags = new PropertyValue<List<string>?>(nameof(CratesPackageVersionDetails), nameof(Tags), "tags");
    
    [JsonPropertyName("tags")]
    public List<string>? Tags
    {
        get => _tags.GetValue(InlineErrors);
        set => _tags.SetValue(value);
    }

    private PropertyValue<long> _created = new PropertyValue<long>(nameof(CratesPackageVersionDetails), nameof(Created), "created");
    
    [Required]
    [JsonPropertyName("created")]
    public long Created
    {
        get => _created.GetValue(InlineErrors);
        set => _created.SetValue(value);
    }

    private PropertyValue<long?> _accessed = new PropertyValue<long?>(nameof(CratesPackageVersionDetails), nameof(Accessed), "accessed");
    
    [JsonPropertyName("accessed")]
    public long? Accessed
    {
        get => _accessed.GetValue(InlineErrors);
        set => _accessed.SetValue(value);
    }

    private PropertyValue<long> _downloads = new PropertyValue<long>(nameof(CratesPackageVersionDetails), nameof(Downloads), "downloads");
    
    [Required]
    [JsonPropertyName("downloads")]
    public long Downloads
    {
        get => _downloads.GetValue(InlineErrors);
        set => _downloads.SetValue(value);
    }

    private PropertyValue<bool> _pinned = new PropertyValue<bool>(nameof(CratesPackageVersionDetails), nameof(IsPinned), "pinned");
    
    [Required]
    [JsonPropertyName("pinned")]
    public bool IsPinned
    {
        get => _pinned.GetValue(InlineErrors);
        set => _pinned.SetValue(value);
    }

    private PropertyValue<string?> _comment = new PropertyValue<string?>(nameof(CratesPackageVersionDetails), nameof(Comment), "comment");
    
    [JsonPropertyName("comment")]
    public string? Comment
    {
        get => _comment.GetValue(InlineErrors);
        set => _comment.SetValue(value);
    }

    private PropertyValue<long> _diskSize = new PropertyValue<long>(nameof(CratesPackageVersionDetails), nameof(DiskSize), "diskSize");
    
    [Required]
    [JsonPropertyName("diskSize")]
    public long DiskSize
    {
        get => _diskSize.GetValue(InlineErrors);
        set => _diskSize.SetValue(value);
    }

    private PropertyValue<CPrincipal?> _author = new PropertyValue<CPrincipal?>(nameof(CratesPackageVersionDetails), nameof(Author), "author");
    
    [JsonPropertyName("author")]
    public CPrincipal? Author
    {
        get => _author.GetValue(InlineErrors);
        set => _author.SetValue(value);
    }

    private PropertyValue<List<CPrincipal>?> _authors = new PropertyValue<List<CPrincipal>?>(nameof(CratesPackageVersionDetails), nameof(Authors), "authors");
    
    [JsonPropertyName("authors")]
    public List<CPrincipal>? Authors
    {
        get => _authors.GetValue(InlineErrors);
        set => _authors.SetValue(value);
    }

    private PropertyValue<PackageOrigin?> _origin = new PropertyValue<PackageOrigin?>(nameof(CratesPackageVersionDetails), nameof(Origin), "origin");
    
    [JsonPropertyName("origin")]
    public PackageOrigin? Origin
    {
        get => _origin.GetValue(InlineErrors);
        set => _origin.SetValue(value);
    }

    private PropertyValue<Dictionary<string, string>?> _metadata = new PropertyValue<Dictionary<string, string>?>(nameof(CratesPackageVersionDetails), nameof(Metadata), "metadata");
    
    [JsonPropertyName("metadata")]
    public Dictionary<string, string>? Metadata
    {
        get => _metadata.GetValue(InlineErrors);
        set => _metadata.SetValue(value);
    }

    private PropertyValue<List<CratesPackageDependency>> _dependencies = new PropertyValue<List<CratesPackageDependency>>(nameof(CratesPackageVersionDetails), nameof(Dependencies), "dependencies", new List<CratesPackageDependency>());
    
    [Required]
    [JsonPropertyName("dependencies")]
    public List<CratesPackageDependency> Dependencies
    {
        get => _dependencies.GetValue(InlineErrors);
        set => _dependencies.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CratesPackageVersionDetails), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<string?> _documentation = new PropertyValue<string?>(nameof(CratesPackageVersionDetails), nameof(Documentation), "documentation");
    
    [JsonPropertyName("documentation")]
    public string? Documentation
    {
        get => _documentation.GetValue(InlineErrors);
        set => _documentation.SetValue(value);
    }

    private PropertyValue<string?> _homepage = new PropertyValue<string?>(nameof(CratesPackageVersionDetails), nameof(Homepage), "homepage");
    
    [JsonPropertyName("homepage")]
    public string? Homepage
    {
        get => _homepage.GetValue(InlineErrors);
        set => _homepage.SetValue(value);
    }

    private PropertyValue<string?> _readme = new PropertyValue<string?>(nameof(CratesPackageVersionDetails), nameof(Readme), "readme");
    
    [JsonPropertyName("readme")]
    public string? Readme
    {
        get => _readme.GetValue(InlineErrors);
        set => _readme.SetValue(value);
    }

    private PropertyValue<List<string>> _keywords = new PropertyValue<List<string>>(nameof(CratesPackageVersionDetails), nameof(Keywords), "keywords", new List<string>());
    
    [Required]
    [JsonPropertyName("keywords")]
    public List<string> Keywords
    {
        get => _keywords.GetValue(InlineErrors);
        set => _keywords.SetValue(value);
    }

    private PropertyValue<List<string>> _categories = new PropertyValue<List<string>>(nameof(CratesPackageVersionDetails), nameof(Categories), "categories", new List<string>());
    
    [Required]
    [JsonPropertyName("categories")]
    public List<string> Categories
    {
        get => _categories.GetValue(InlineErrors);
        set => _categories.SetValue(value);
    }

    private PropertyValue<string?> _license = new PropertyValue<string?>(nameof(CratesPackageVersionDetails), nameof(License), "license");
    
    [JsonPropertyName("license")]
    public string? License
    {
        get => _license.GetValue(InlineErrors);
        set => _license.SetValue(value);
    }

    private PropertyValue<string?> _licenseFileContent = new PropertyValue<string?>(nameof(CratesPackageVersionDetails), nameof(LicenseFileContent), "licenseFileContent");
    
    [JsonPropertyName("licenseFileContent")]
    public string? LicenseFileContent
    {
        get => _licenseFileContent.GetValue(InlineErrors);
        set => _licenseFileContent.SetValue(value);
    }

    private PropertyValue<string?> _gitRepository = new PropertyValue<string?>(nameof(CratesPackageVersionDetails), nameof(GitRepository), "gitRepository");
    
    [JsonPropertyName("gitRepository")]
    public string? GitRepository
    {
        get => _gitRepository.GetValue(InlineErrors);
        set => _gitRepository.SetValue(value);
    }

    private PropertyValue<string?> _links = new PropertyValue<string?>(nameof(CratesPackageVersionDetails), nameof(Links), "links");
    
    [JsonPropertyName("links")]
    public string? Links
    {
        get => _links.GetValue(InlineErrors);
        set => _links.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
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
        _dependencies.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _documentation.SetAccessPath(parentChainPath, validateHasBeenSet);
        _homepage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _readme.SetAccessPath(parentChainPath, validateHasBeenSet);
        _keywords.SetAccessPath(parentChainPath, validateHasBeenSet);
        _categories.SetAccessPath(parentChainPath, validateHasBeenSet);
        _license.SetAccessPath(parentChainPath, validateHasBeenSet);
        _licenseFileContent.SetAccessPath(parentChainPath, validateHasBeenSet);
        _gitRepository.SetAccessPath(parentChainPath, validateHasBeenSet);
        _links.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

