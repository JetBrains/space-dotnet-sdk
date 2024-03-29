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

public sealed class UpdatePackageRepositoryAccessIn
     : IPropagatePropertyAccessPath
{
    public UpdatePackageRepositoryAccessIn() { }
    
    public UpdatePackageRepositoryAccessIn(List<PackagesAccessRecipientIdentifier>? addAccessTo = null, List<PermissionsRecipientIdentifier>? removeAccessFrom = null, bool? restricted = null)
    {
        AddAccessTo = addAccessTo;
        RemoveAccessFrom = removeAccessFrom;
        IsRestricted = restricted;
    }
    
    private PropertyValue<List<PackagesAccessRecipientIdentifier>?> _addAccessTo = new PropertyValue<List<PackagesAccessRecipientIdentifier>?>(nameof(UpdatePackageRepositoryAccessIn), nameof(AddAccessTo), "addAccessTo");
    
    [JsonPropertyName("addAccessTo")]
    public List<PackagesAccessRecipientIdentifier>? AddAccessTo
    {
        get => _addAccessTo.GetValue(InlineErrors);
        set => _addAccessTo.SetValue(value);
    }

    private PropertyValue<List<PermissionsRecipientIdentifier>?> _removeAccessFrom = new PropertyValue<List<PermissionsRecipientIdentifier>?>(nameof(UpdatePackageRepositoryAccessIn), nameof(RemoveAccessFrom), "removeAccessFrom");
    
    [JsonPropertyName("removeAccessFrom")]
    public List<PermissionsRecipientIdentifier>? RemoveAccessFrom
    {
        get => _removeAccessFrom.GetValue(InlineErrors);
        set => _removeAccessFrom.SetValue(value);
    }

    private PropertyValue<bool?> _restricted = new PropertyValue<bool?>(nameof(UpdatePackageRepositoryAccessIn), nameof(IsRestricted), "restricted");
    
    [JsonPropertyName("restricted")]
    public bool? IsRestricted
    {
        get => _restricted.GetValue(InlineErrors);
        set => _restricted.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _addAccessTo.SetAccessPath(parentChainPath, validateHasBeenSet);
        _removeAccessFrom.SetAccessPath(parentChainPath, validateHasBeenSet);
        _restricted.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

