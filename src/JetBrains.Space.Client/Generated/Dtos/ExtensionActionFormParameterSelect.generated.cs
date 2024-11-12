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

public sealed class ExtensionActionFormParameterSelect
     : ExtensionActionFormParameter, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "ExtensionActionFormParameter.Select";
    
    public ExtensionActionFormParameterSelect() { }
    
    public ExtensionActionFormParameterSelect(string key, string title, List<ExtensionActionFormParameterSelectOption> options, bool canEnterNewValue, bool required, string? defaultValue = null)
    {
        Key = key;
        Title = title;
        Options = options;
        CanEnterNewValue = canEnterNewValue;
        IsRequired = required;
        DefaultValue = defaultValue;
    }
    
    private PropertyValue<string> _key = new PropertyValue<string>(nameof(ExtensionActionFormParameterSelect), nameof(Key), "key");
    
    [Required]
    [JsonPropertyName("key")]
    public string Key
    {
        get => _key.GetValue(InlineErrors);
        set => _key.SetValue(value);
    }

    private PropertyValue<string> _title = new PropertyValue<string>(nameof(ExtensionActionFormParameterSelect), nameof(Title), "title");
    
    [Required]
    [JsonPropertyName("title")]
    public string Title
    {
        get => _title.GetValue(InlineErrors);
        set => _title.SetValue(value);
    }

    private PropertyValue<List<ExtensionActionFormParameterSelectOption>> _options = new PropertyValue<List<ExtensionActionFormParameterSelectOption>>(nameof(ExtensionActionFormParameterSelect), nameof(Options), "options", new List<ExtensionActionFormParameterSelectOption>());
    
    [Required]
    [JsonPropertyName("options")]
    public List<ExtensionActionFormParameterSelectOption> Options
    {
        get => _options.GetValue(InlineErrors);
        set => _options.SetValue(value);
    }

    private PropertyValue<bool> _canEnterNewValue = new PropertyValue<bool>(nameof(ExtensionActionFormParameterSelect), nameof(CanEnterNewValue), "canEnterNewValue");
    
    [Required]
    [JsonPropertyName("canEnterNewValue")]
    public bool CanEnterNewValue
    {
        get => _canEnterNewValue.GetValue(InlineErrors);
        set => _canEnterNewValue.SetValue(value);
    }

    private PropertyValue<bool> _required = new PropertyValue<bool>(nameof(ExtensionActionFormParameterSelect), nameof(IsRequired), "required");
    
    [Required]
    [JsonPropertyName("required")]
    public bool IsRequired
    {
        get => _required.GetValue(InlineErrors);
        set => _required.SetValue(value);
    }

    private PropertyValue<string?> _defaultValue = new PropertyValue<string?>(nameof(ExtensionActionFormParameterSelect), nameof(DefaultValue), "defaultValue");
    
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue
    {
        get => _defaultValue.GetValue(InlineErrors);
        set => _defaultValue.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _key.SetAccessPath(parentChainPath, validateHasBeenSet);
        _title.SetAccessPath(parentChainPath, validateHasBeenSet);
        _options.SetAccessPath(parentChainPath, validateHasBeenSet);
        _canEnterNewValue.SetAccessPath(parentChainPath, validateHasBeenSet);
        _required.SetAccessPath(parentChainPath, validateHasBeenSet);
        _defaultValue.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
