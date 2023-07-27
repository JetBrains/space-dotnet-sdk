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

public sealed class DocumentFolderItemDocumentItem
     : DocumentFolderItem, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "DocumentFolderItem.DocumentItem";
    
    public DocumentFolderItemDocumentItem() { }
    
    public DocumentFolderItemDocumentItem(Document document, DocumentsSearchHighlights? highlights = null)
    {
        Document = document;
        Highlights = highlights;
    }
    
    private PropertyValue<Document> _document = new PropertyValue<Document>(nameof(DocumentFolderItemDocumentItem), nameof(Document), "document");
    
    [Required]
    [JsonPropertyName("document")]
    public Document Document
    {
        get => _document.GetValue(InlineErrors);
        set => _document.SetValue(value);
    }

    private PropertyValue<DocumentsSearchHighlights?> _highlights = new PropertyValue<DocumentsSearchHighlights?>(nameof(DocumentFolderItemDocumentItem), nameof(Highlights), "highlights");
    
    [JsonPropertyName("highlights")]
    public DocumentsSearchHighlights? Highlights
    {
        get => _highlights.GetValue(InlineErrors);
        set => _highlights.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _document.SetAccessPath(parentChainPath, validateHasBeenSet);
        _highlights.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

