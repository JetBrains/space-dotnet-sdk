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

public sealed class TextDocumentHttpBody
     : DocumentHttpBody, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "TextDocumentHttpBody";
    
    public TextDocumentHttpBody() { }
    
    public TextDocumentHttpBody(TextDocumentContent docContent, List<AttachmentInfo> attachments)
    {
        DocContent = docContent;
        Attachments = attachments;
    }
    
    private PropertyValue<TextDocumentContent> _docContent = new PropertyValue<TextDocumentContent>(nameof(TextDocumentHttpBody), nameof(DocContent), "docContent");
    
    [Required]
    [JsonPropertyName("docContent")]
    public TextDocumentContent DocContent
    {
        get => _docContent.GetValue(InlineErrors);
        set => _docContent.SetValue(value);
    }

    private PropertyValue<List<AttachmentInfo>> _attachments = new PropertyValue<List<AttachmentInfo>>(nameof(TextDocumentHttpBody), nameof(Attachments), "attachments", new List<AttachmentInfo>());
    
    [Required]
    [JsonPropertyName("attachments")]
    public List<AttachmentInfo> Attachments
    {
        get => _attachments.GetValue(InlineErrors);
        set => _attachments.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _docContent.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attachments.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

