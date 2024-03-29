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

public sealed class DocumentMenuActionContext
     : MenuActionContext, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "DocumentMenuActionContext";
    
    public DocumentMenuActionContext() { }
    
    public DocumentMenuActionContext(string documentId, ProjectIdentifier? projectIdentifier = null)
    {
        DocumentId = documentId;
        ProjectIdentifier = projectIdentifier;
    }
    
    private PropertyValue<string> _documentId = new PropertyValue<string>(nameof(DocumentMenuActionContext), nameof(DocumentId), "documentId");
    
    [Required]
    [JsonPropertyName("documentId")]
    public string DocumentId
    {
        get => _documentId.GetValue(InlineErrors);
        set => _documentId.SetValue(value);
    }

    private PropertyValue<ProjectIdentifier?> _projectIdentifier = new PropertyValue<ProjectIdentifier?>(nameof(DocumentMenuActionContext), nameof(ProjectIdentifier), "projectIdentifier");
    
    [JsonPropertyName("projectIdentifier")]
    public ProjectIdentifier? ProjectIdentifier
    {
        get => _projectIdentifier.GetValue(InlineErrors);
        set => _projectIdentifier.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _documentId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _projectIdentifier.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

