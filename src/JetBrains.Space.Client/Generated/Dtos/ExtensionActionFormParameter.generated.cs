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

[JsonConverter(typeof(ClassNameDtoTypeConverter))]
public class ExtensionActionFormParameter
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public virtual string? ClassName => "ExtensionActionFormParameter";
    
    public static ExtensionActionFormParameterBoolean Boolean(string key, string title, bool defaultValue)
        => new ExtensionActionFormParameterBoolean(key: key, title: title, defaultValue: defaultValue);
    
    public static ExtensionActionFormParameterSelect Select(string key, string title, List<ExtensionActionFormParameterSelectOption> options, bool canEnterNewValue, bool required, string? defaultValue = null)
        => new ExtensionActionFormParameterSelect(key: key, title: title, options: options, canEnterNewValue: canEnterNewValue, required: required, defaultValue: defaultValue);
    
    public static ExtensionActionFormParameterText Text(string key, string title, bool required, bool multiline, string? defaultValue = null)
        => new ExtensionActionFormParameterText(key: key, title: title, required: required, multiline: multiline, defaultValue: defaultValue);
    
    public ExtensionActionFormParameter() { }
    
    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
