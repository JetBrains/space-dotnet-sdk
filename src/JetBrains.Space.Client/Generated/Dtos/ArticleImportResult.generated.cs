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

public sealed class ArticleImportResult
     : IPropagatePropertyAccessPath
{
    public ArticleImportResult() { }
    
    public ArticleImportResult(string? externalId = null, ArticleRecord? article = null, string? error = null)
    {
        ExternalId = externalId;
        Article = article;
        Error = error;
    }
    
    private PropertyValue<string?> _externalId = new PropertyValue<string?>(nameof(ArticleImportResult), nameof(ExternalId), "externalId");
    
    [JsonPropertyName("externalId")]
    public string? ExternalId
    {
        get => _externalId.GetValue(InlineErrors);
        set => _externalId.SetValue(value);
    }

    private PropertyValue<ArticleRecord?> _article = new PropertyValue<ArticleRecord?>(nameof(ArticleImportResult), nameof(Article), "article");
    
    [JsonPropertyName("article")]
    public ArticleRecord? Article
    {
        get => _article.GetValue(InlineErrors);
        set => _article.SetValue(value);
    }

    private PropertyValue<string?> _error = new PropertyValue<string?>(nameof(ArticleImportResult), nameof(Error), "error");
    
    [JsonPropertyName("error")]
    public string? Error
    {
        get => _error.GetValue(InlineErrors);
        set => _error.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _externalId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _article.SetAccessPath(parentChainPath, validateHasBeenSet);
        _error.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

