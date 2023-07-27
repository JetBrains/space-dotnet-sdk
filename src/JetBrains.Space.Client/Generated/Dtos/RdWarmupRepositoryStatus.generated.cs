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

public sealed class RdWarmupRepositoryStatus
     : RdRepositoryStatus, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "RdWarmupRepositoryStatus";
    
    public RdWarmupRepositoryStatus() { }
    
    public RdWarmupRepositoryStatus(string commit, string branch)
    {
        Commit = commit;
        Branch = branch;
    }
    
    private PropertyValue<string> _commit = new PropertyValue<string>(nameof(RdWarmupRepositoryStatus), nameof(Commit), "commit");
    
    [Required]
    [JsonPropertyName("commit")]
    public string Commit
    {
        get => _commit.GetValue(InlineErrors);
        set => _commit.SetValue(value);
    }

    private PropertyValue<string> _branch = new PropertyValue<string>(nameof(RdWarmupRepositoryStatus), nameof(Branch), "branch");
    
    [Required]
    [JsonPropertyName("branch")]
    public string Branch
    {
        get => _branch.GetValue(InlineErrors);
        set => _branch.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _commit.SetAccessPath(parentChainPath, validateHasBeenSet);
        _branch.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

