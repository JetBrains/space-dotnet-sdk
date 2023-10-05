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

public sealed class MergeRequestCodeIssueAnchor
     : IPropagatePropertyAccessPath
{
    public MergeRequestCodeIssueAnchor() { }
    
    public MergeRequestCodeIssueAnchor(string commitId, string filePath, int line, int? column = null, int? endLine = null, int? endColumn = null)
    {
        CommitId = commitId;
        FilePath = filePath;
        Line = line;
        Column = column;
        EndLine = endLine;
        EndColumn = endColumn;
    }
    
    private PropertyValue<string> _commitId = new PropertyValue<string>(nameof(MergeRequestCodeIssueAnchor), nameof(CommitId), "commitId");
    
    [Required]
    [JsonPropertyName("commitId")]
    public string CommitId
    {
        get => _commitId.GetValue(InlineErrors);
        set => _commitId.SetValue(value);
    }

    private PropertyValue<string> _filePath = new PropertyValue<string>(nameof(MergeRequestCodeIssueAnchor), nameof(FilePath), "filePath");
    
    [Required]
    [JsonPropertyName("filePath")]
    public string FilePath
    {
        get => _filePath.GetValue(InlineErrors);
        set => _filePath.SetValue(value);
    }

    private PropertyValue<int> _line = new PropertyValue<int>(nameof(MergeRequestCodeIssueAnchor), nameof(Line), "line");
    
    [Required]
    [JsonPropertyName("line")]
    public int Line
    {
        get => _line.GetValue(InlineErrors);
        set => _line.SetValue(value);
    }

    private PropertyValue<int?> _column = new PropertyValue<int?>(nameof(MergeRequestCodeIssueAnchor), nameof(Column), "column");
    
    [JsonPropertyName("column")]
    public int? Column
    {
        get => _column.GetValue(InlineErrors);
        set => _column.SetValue(value);
    }

    private PropertyValue<int?> _endLine = new PropertyValue<int?>(nameof(MergeRequestCodeIssueAnchor), nameof(EndLine), "endLine");
    
    [JsonPropertyName("endLine")]
    public int? EndLine
    {
        get => _endLine.GetValue(InlineErrors);
        set => _endLine.SetValue(value);
    }

    private PropertyValue<int?> _endColumn = new PropertyValue<int?>(nameof(MergeRequestCodeIssueAnchor), nameof(EndColumn), "endColumn");
    
    [JsonPropertyName("endColumn")]
    public int? EndColumn
    {
        get => _endColumn.GetValue(InlineErrors);
        set => _endColumn.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _commitId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _filePath.SetAccessPath(parentChainPath, validateHasBeenSet);
        _line.SetAccessPath(parentChainPath, validateHasBeenSet);
        _column.SetAccessPath(parentChainPath, validateHasBeenSet);
        _endLine.SetAccessPath(parentChainPath, validateHasBeenSet);
        _endColumn.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

