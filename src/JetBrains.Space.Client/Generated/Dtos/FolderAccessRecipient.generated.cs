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

public sealed class FolderAccessRecipient
     : IPropagatePropertyAccessPath
{
    public FolderAccessRecipient() { }
    
    public FolderAccessRecipient(bool isContainerAccessible, FolderSharingAccessType? access = null, PermissionsRecipient? recipient = null)
    {
        Access = access;
        Recipient = recipient;
        IsContainerAccessible = isContainerAccessible;
    }
    
    private PropertyValue<FolderSharingAccessType?> _access = new PropertyValue<FolderSharingAccessType?>(nameof(FolderAccessRecipient), nameof(Access), "access");
    
    [JsonPropertyName("access")]
    public FolderSharingAccessType? Access
    {
        get => _access.GetValue(InlineErrors);
        set => _access.SetValue(value);
    }

    private PropertyValue<PermissionsRecipient?> _recipient = new PropertyValue<PermissionsRecipient?>(nameof(FolderAccessRecipient), nameof(Recipient), "recipient");
    
    [JsonPropertyName("recipient")]
    public PermissionsRecipient? Recipient
    {
        get => _recipient.GetValue(InlineErrors);
        set => _recipient.SetValue(value);
    }

    private PropertyValue<bool> _isContainerAccessible = new PropertyValue<bool>(nameof(FolderAccessRecipient), nameof(IsContainerAccessible), "isContainerAccessible");
    
    [Required]
    [JsonPropertyName("isContainerAccessible")]
    public bool IsContainerAccessible
    {
        get => _isContainerAccessible.GetValue(InlineErrors);
        set => _isContainerAccessible.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _access.SetAccessPath(parentChainPath, validateHasBeenSet);
        _recipient.SetAccessPath(parentChainPath, validateHasBeenSet);
        _isContainerAccessible.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

