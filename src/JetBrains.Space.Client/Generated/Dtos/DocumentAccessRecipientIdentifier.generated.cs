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

public sealed class DocumentAccessRecipientIdentifier
     : IPropagatePropertyAccessPath
{
    public DocumentAccessRecipientIdentifier() { }
    
    public DocumentAccessRecipientIdentifier(DocumentSharingAccessType? access = null, PermissionsRecipientIdentifier? recipient = null)
    {
        Access = access;
        Recipient = recipient;
    }
    
    private PropertyValue<DocumentSharingAccessType?> _access = new PropertyValue<DocumentSharingAccessType?>(nameof(DocumentAccessRecipientIdentifier), nameof(Access), "access");
    
    [JsonPropertyName("access")]
    public DocumentSharingAccessType? Access
    {
        get => _access.GetValue(InlineErrors);
        set => _access.SetValue(value);
    }

    private PropertyValue<PermissionsRecipientIdentifier?> _recipient = new PropertyValue<PermissionsRecipientIdentifier?>(nameof(DocumentAccessRecipientIdentifier), nameof(Recipient), "recipient");
    
    [JsonPropertyName("recipient")]
    public PermissionsRecipientIdentifier? Recipient
    {
        get => _recipient.GetValue(InlineErrors);
        set => _recipient.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _access.SetAccessPath(parentChainPath, validateHasBeenSet);
        _recipient.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

