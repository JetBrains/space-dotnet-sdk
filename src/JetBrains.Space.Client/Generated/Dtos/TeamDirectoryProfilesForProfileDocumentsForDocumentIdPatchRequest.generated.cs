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

internal class TeamDirectoryProfilesForProfileDocumentsForDocumentIdPatchRequest
     : IPropagatePropertyAccessPath
{
    public TeamDirectoryProfilesForProfileDocumentsForDocumentIdPatchRequest() { }
    
    public TeamDirectoryProfilesForProfileDocumentsForDocumentIdPatchRequest(string? name = null, DocumentBodyUpdateIn? updateIn = null, PublicationDetailsIn? publicationDetailsIn = null)
    {
        Name = name;
        UpdateIn = updateIn;
        PublicationDetailsIn = publicationDetailsIn;
    }
    
    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfileDocumentsForDocumentIdPatchRequest), nameof(Name), "name");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<DocumentBodyUpdateIn?> _updateIn = new PropertyValue<DocumentBodyUpdateIn?>(nameof(TeamDirectoryProfilesForProfileDocumentsForDocumentIdPatchRequest), nameof(UpdateIn), "updateIn");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("updateIn")]
    public DocumentBodyUpdateIn? UpdateIn
    {
        get => _updateIn.GetValue(InlineErrors);
        set => _updateIn.SetValue(value);
    }

    private PropertyValue<PublicationDetailsIn?> _publicationDetailsIn = new PropertyValue<PublicationDetailsIn?>(nameof(TeamDirectoryProfilesForProfileDocumentsForDocumentIdPatchRequest), nameof(PublicationDetailsIn), "publicationDetailsIn");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("publicationDetailsIn")]
    public PublicationDetailsIn? PublicationDetailsIn
    {
        get => _publicationDetailsIn.GetValue(InlineErrors);
        set => _publicationDetailsIn.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _updateIn.SetAccessPath(parentChainPath, validateHasBeenSet);
        _publicationDetailsIn.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

