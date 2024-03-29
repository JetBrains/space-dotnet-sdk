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

public sealed class CustomFieldData
     : IPropagatePropertyAccessPath
{
    public CustomFieldData() { }
    
    public CustomFieldData(string id, string name, CustomFieldType type, bool multivalued, bool required, CFValue defaultValue, int order, bool archived, CFParameters? parameters = null, CFConstraint? constraint = null, string? description = null)
    {
        Id = id;
        Name = name;
        Type = type;
        IsMultivalued = multivalued;
        Parameters = parameters;
        IsRequired = required;
        DefaultValue = defaultValue;
        Constraint = constraint;
        Description = description;
        Order = order;
        IsArchived = archived;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(CustomFieldData), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(CustomFieldData), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<CustomFieldType> _type = new PropertyValue<CustomFieldType>(nameof(CustomFieldData), nameof(Type), "type");
    
    [Required]
    [JsonPropertyName("type")]
    public CustomFieldType Type
    {
        get => _type.GetValue(InlineErrors);
        set => _type.SetValue(value);
    }

    private PropertyValue<bool> _multivalued = new PropertyValue<bool>(nameof(CustomFieldData), nameof(IsMultivalued), "multivalued");
    
    [Required]
    [JsonPropertyName("multivalued")]
    public bool IsMultivalued
    {
        get => _multivalued.GetValue(InlineErrors);
        set => _multivalued.SetValue(value);
    }

    private PropertyValue<CFParameters?> _parameters = new PropertyValue<CFParameters?>(nameof(CustomFieldData), nameof(Parameters), "parameters");
    
    [JsonPropertyName("parameters")]
    public CFParameters? Parameters
    {
        get => _parameters.GetValue(InlineErrors);
        set => _parameters.SetValue(value);
    }

    private PropertyValue<bool> _required = new PropertyValue<bool>(nameof(CustomFieldData), nameof(IsRequired), "required");
    
    [Required]
    [JsonPropertyName("required")]
    public bool IsRequired
    {
        get => _required.GetValue(InlineErrors);
        set => _required.SetValue(value);
    }

    private PropertyValue<CFValue> _defaultValue = new PropertyValue<CFValue>(nameof(CustomFieldData), nameof(DefaultValue), "defaultValue");
    
    [Required]
    [JsonPropertyName("defaultValue")]
    public CFValue DefaultValue
    {
        get => _defaultValue.GetValue(InlineErrors);
        set => _defaultValue.SetValue(value);
    }

    private PropertyValue<CFConstraint?> _constraint = new PropertyValue<CFConstraint?>(nameof(CustomFieldData), nameof(Constraint), "constraint");
    
    [JsonPropertyName("constraint")]
    public CFConstraint? Constraint
    {
        get => _constraint.GetValue(InlineErrors);
        set => _constraint.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CustomFieldData), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<int> _order = new PropertyValue<int>(nameof(CustomFieldData), nameof(Order), "order");
    
    [Required]
    [JsonPropertyName("order")]
    public int Order
    {
        get => _order.GetValue(InlineErrors);
        set => _order.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(CustomFieldData), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _type.SetAccessPath(parentChainPath, validateHasBeenSet);
        _multivalued.SetAccessPath(parentChainPath, validateHasBeenSet);
        _parameters.SetAccessPath(parentChainPath, validateHasBeenSet);
        _required.SetAccessPath(parentChainPath, validateHasBeenSet);
        _defaultValue.SetAccessPath(parentChainPath, validateHasBeenSet);
        _constraint.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _order.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

