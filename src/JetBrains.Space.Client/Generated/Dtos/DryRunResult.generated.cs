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

public sealed class DryRunResult
     : IPropagatePropertyAccessPath
{
    public DryRunResult() { }
    
    public DryRunResult(List<TDTeam> teams, List<PRProject> projects, List<TDLocation> locations, List<string> records)
    {
        Teams = teams;
        Projects = projects;
        Locations = locations;
        Records = records;
    }
    
    private PropertyValue<List<TDTeam>> _teams = new PropertyValue<List<TDTeam>>(nameof(DryRunResult), nameof(Teams), "teams", new List<TDTeam>());
    
    [Required]
    [JsonPropertyName("teams")]
    public List<TDTeam> Teams
    {
        get => _teams.GetValue(InlineErrors);
        set => _teams.SetValue(value);
    }

    private PropertyValue<List<PRProject>> _projects = new PropertyValue<List<PRProject>>(nameof(DryRunResult), nameof(Projects), "projects", new List<PRProject>());
    
    [Required]
    [JsonPropertyName("projects")]
    public List<PRProject> Projects
    {
        get => _projects.GetValue(InlineErrors);
        set => _projects.SetValue(value);
    }

    private PropertyValue<List<TDLocation>> _locations = new PropertyValue<List<TDLocation>>(nameof(DryRunResult), nameof(Locations), "locations", new List<TDLocation>());
    
    [Required]
    [JsonPropertyName("locations")]
    public List<TDLocation> Locations
    {
        get => _locations.GetValue(InlineErrors);
        set => _locations.SetValue(value);
    }

    private PropertyValue<List<string>> _records = new PropertyValue<List<string>>(nameof(DryRunResult), nameof(Records), "records", new List<string>());
    
    [Required]
    [JsonPropertyName("records")]
    public List<string> Records
    {
        get => _records.GetValue(InlineErrors);
        set => _records.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _teams.SetAccessPath(parentChainPath, validateHasBeenSet);
        _projects.SetAccessPath(parentChainPath, validateHasBeenSet);
        _locations.SetAccessPath(parentChainPath, validateHasBeenSet);
        _records.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

