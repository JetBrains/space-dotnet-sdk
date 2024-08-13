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

public sealed class ExtensionActionParametersForm
     : IPropagatePropertyAccessPath
{
    public ExtensionActionParametersForm() { }
    
    public ExtensionActionParametersForm(string formTitle, string confirmButtonTitle, List<ExtensionActionFormParameter> parameters)
    {
        FormTitle = formTitle;
        ConfirmButtonTitle = confirmButtonTitle;
        Parameters = parameters;
    }
    
    private PropertyValue<string> _formTitle = new PropertyValue<string>(nameof(ExtensionActionParametersForm), nameof(FormTitle), "formTitle");
    
    [Required]
    [JsonPropertyName("formTitle")]
    public string FormTitle
    {
        get => _formTitle.GetValue(InlineErrors);
        set => _formTitle.SetValue(value);
    }

    private PropertyValue<string> _confirmButtonTitle = new PropertyValue<string>(nameof(ExtensionActionParametersForm), nameof(ConfirmButtonTitle), "confirmButtonTitle");
    
    [Required]
    [JsonPropertyName("confirmButtonTitle")]
    public string ConfirmButtonTitle
    {
        get => _confirmButtonTitle.GetValue(InlineErrors);
        set => _confirmButtonTitle.SetValue(value);
    }

    private PropertyValue<List<ExtensionActionFormParameter>> _parameters = new PropertyValue<List<ExtensionActionFormParameter>>(nameof(ExtensionActionParametersForm), nameof(Parameters), "parameters", new List<ExtensionActionFormParameter>());
    
    [Required]
    [JsonPropertyName("parameters")]
    public List<ExtensionActionFormParameter> Parameters
    {
        get => _parameters.GetValue(InlineErrors);
        set => _parameters.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _formTitle.SetAccessPath(parentChainPath, validateHasBeenSet);
        _confirmButtonTitle.SetAccessPath(parentChainPath, validateHasBeenSet);
        _parameters.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

