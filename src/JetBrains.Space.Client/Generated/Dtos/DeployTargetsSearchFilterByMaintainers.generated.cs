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

public sealed class DeployTargetsSearchFilterByMaintainers
     : DeployTargetsSearchFilter, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "DeployTargetsSearchFilter.ByMaintainers";
    
    public DeployTargetsSearchFilterByMaintainers() { }
    
    public DeployTargetsSearchFilterByMaintainers(List<DeployTargetsSearchFilterMaintainer> maintainers, bool negated)
    {
        Maintainers = maintainers;
        IsNegated = negated;
    }
    
    private PropertyValue<List<DeployTargetsSearchFilterMaintainer>> _maintainers = new PropertyValue<List<DeployTargetsSearchFilterMaintainer>>(nameof(DeployTargetsSearchFilterByMaintainers), nameof(Maintainers), "maintainers", new List<DeployTargetsSearchFilterMaintainer>());
    
    [Required]
    [JsonPropertyName("maintainers")]
    public List<DeployTargetsSearchFilterMaintainer> Maintainers
    {
        get => _maintainers.GetValue(InlineErrors);
        set => _maintainers.SetValue(value);
    }

    private PropertyValue<bool> _negated = new PropertyValue<bool>(nameof(DeployTargetsSearchFilterByMaintainers), nameof(IsNegated), "negated");
    
    [Required]
    [JsonPropertyName("negated")]
    public bool IsNegated
    {
        get => _negated.GetValue(InlineErrors);
        set => _negated.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _maintainers.SetAccessPath(parentChainPath, validateHasBeenSet);
        _negated.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

