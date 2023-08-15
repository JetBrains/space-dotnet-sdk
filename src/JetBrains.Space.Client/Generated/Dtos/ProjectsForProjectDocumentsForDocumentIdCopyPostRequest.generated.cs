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

internal class ProjectsForProjectDocumentsForDocumentIdCopyPostRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectDocumentsForDocumentIdCopyPostRequest() { }
    
    public ProjectsForProjectDocumentsForDocumentIdCopyPostRequest(string name, FolderIdentifier folder)
    {
        Name = name;
        Folder = folder;
    }
    
    private PropertyValue<string> _name = new PropertyValue<string>(nameof(ProjectsForProjectDocumentsForDocumentIdCopyPostRequest), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<FolderIdentifier> _folder = new PropertyValue<FolderIdentifier>(nameof(ProjectsForProjectDocumentsForDocumentIdCopyPostRequest), nameof(Folder), "folder");
    
    [Required]
    [JsonPropertyName("folder")]
    public FolderIdentifier Folder
    {
        get => _folder.GetValue(InlineErrors);
        set => _folder.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _folder.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

