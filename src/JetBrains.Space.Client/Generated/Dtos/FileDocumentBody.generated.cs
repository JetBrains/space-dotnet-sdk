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

public sealed class FileDocumentBody
     : DocumentBodyInfo, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "FileDocumentBody";
    
    public FileDocumentBody() { }
    
    public FileDocumentBody(string versionId, string contentType, long fileSize)
    {
        VersionId = versionId;
        ContentType = contentType;
        FileSize = fileSize;
    }
    
    private PropertyValue<string> _versionId = new PropertyValue<string>(nameof(FileDocumentBody), nameof(VersionId), "versionId");
    
    [Required]
    [JsonPropertyName("versionId")]
    public string VersionId
    {
        get => _versionId.GetValue(InlineErrors);
        set => _versionId.SetValue(value);
    }

    private PropertyValue<string> _contentType = new PropertyValue<string>(nameof(FileDocumentBody), nameof(ContentType), "contentType");
    
    [Required]
    [JsonPropertyName("contentType")]
    public string ContentType
    {
        get => _contentType.GetValue(InlineErrors);
        set => _contentType.SetValue(value);
    }

    private PropertyValue<long> _fileSize = new PropertyValue<long>(nameof(FileDocumentBody), nameof(FileSize), "fileSize");
    
    [Required]
    [JsonPropertyName("fileSize")]
    public long FileSize
    {
        get => _fileSize.GetValue(InlineErrors);
        set => _fileSize.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _versionId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _contentType.SetAccessPath(parentChainPath, validateHasBeenSet);
        _fileSize.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

