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

internal class ProjectsForProjectDocumentsFoldersForFolderAccessPatchRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectDocumentsFoldersForFolderAccessPatchRequest() { }
    
    public ProjectsForProjectDocumentsFoldersForFolderAccessPatchRequest(UpdateFolderAccessIn accessChange, bool silent = false)
    {
        AccessChange = accessChange;
        IsSilent = silent;
    }
    
    private PropertyValue<UpdateFolderAccessIn> _accessChange = new PropertyValue<UpdateFolderAccessIn>(nameof(ProjectsForProjectDocumentsFoldersForFolderAccessPatchRequest), nameof(AccessChange), "accessChange");
    
    [Required]
    [JsonPropertyName("accessChange")]
    public UpdateFolderAccessIn AccessChange
    {
        get => _accessChange.GetValue(InlineErrors);
        set => _accessChange.SetValue(value);
    }

    private PropertyValue<bool> _silent = new PropertyValue<bool>(nameof(ProjectsForProjectDocumentsFoldersForFolderAccessPatchRequest), nameof(IsSilent), "silent");
    
    [JsonPropertyName("silent")]
    public bool IsSilent
    {
        get => _silent.GetValue(InlineErrors);
        set => _silent.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _accessChange.SetAccessPath(parentChainPath, validateHasBeenSet);
        _silent.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

