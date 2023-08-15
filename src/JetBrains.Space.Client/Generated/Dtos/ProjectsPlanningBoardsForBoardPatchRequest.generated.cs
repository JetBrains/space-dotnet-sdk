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

internal class ProjectsPlanningBoardsForBoardPatchRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsPlanningBoardsForBoardPatchRequest() { }
    
    public ProjectsPlanningBoardsForBoardPatchRequest(string? name = null, string? description = null, string? swimlaneKey = null, BoardColumns? columns = null, List<BoardIssueInputField>? issueFields = null, List<string>? memberOwners = null, List<string>? teamOwners = null, BacklogTypeIn? backlogType = null)
    {
        Name = name;
        Description = description;
        SwimlaneKey = swimlaneKey;
        Columns = columns;
        IssueFields = issueFields;
        MemberOwners = memberOwners;
        TeamOwners = teamOwners;
        BacklogType = backlogType;
    }
    
    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(ProjectsPlanningBoardsForBoardPatchRequest), nameof(Name), "name");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectsPlanningBoardsForBoardPatchRequest), nameof(Description), "description");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<string?> _swimlaneKey = new PropertyValue<string?>(nameof(ProjectsPlanningBoardsForBoardPatchRequest), nameof(SwimlaneKey), "swimlaneKey");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("swimlaneKey")]
    public string? SwimlaneKey
    {
        get => _swimlaneKey.GetValue(InlineErrors);
        set => _swimlaneKey.SetValue(value);
    }

    private PropertyValue<BoardColumns?> _columns = new PropertyValue<BoardColumns?>(nameof(ProjectsPlanningBoardsForBoardPatchRequest), nameof(Columns), "columns");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("columns")]
    public BoardColumns? Columns
    {
        get => _columns.GetValue(InlineErrors);
        set => _columns.SetValue(value);
    }

    private PropertyValue<List<BoardIssueInputField>?> _issueFields = new PropertyValue<List<BoardIssueInputField>?>(nameof(ProjectsPlanningBoardsForBoardPatchRequest), nameof(IssueFields), "issueFields");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("issueFields")]
    public List<BoardIssueInputField>? IssueFields
    {
        get => _issueFields.GetValue(InlineErrors);
        set => _issueFields.SetValue(value);
    }

    private PropertyValue<List<string>?> _memberOwners = new PropertyValue<List<string>?>(nameof(ProjectsPlanningBoardsForBoardPatchRequest), nameof(MemberOwners), "memberOwners");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("memberOwners")]
    public List<string>? MemberOwners
    {
        get => _memberOwners.GetValue(InlineErrors);
        set => _memberOwners.SetValue(value);
    }

    private PropertyValue<List<string>?> _teamOwners = new PropertyValue<List<string>?>(nameof(ProjectsPlanningBoardsForBoardPatchRequest), nameof(TeamOwners), "teamOwners");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("teamOwners")]
    public List<string>? TeamOwners
    {
        get => _teamOwners.GetValue(InlineErrors);
        set => _teamOwners.SetValue(value);
    }

    private PropertyValue<BacklogTypeIn?> _backlogType = new PropertyValue<BacklogTypeIn?>(nameof(ProjectsPlanningBoardsForBoardPatchRequest), nameof(BacklogType), "backlogType");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("backlogType")]
    public BacklogTypeIn? BacklogType
    {
        get => _backlogType.GetValue(InlineErrors);
        set => _backlogType.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _swimlaneKey.SetAccessPath(parentChainPath, validateHasBeenSet);
        _columns.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issueFields.SetAccessPath(parentChainPath, validateHasBeenSet);
        _memberOwners.SetAccessPath(parentChainPath, validateHasBeenSet);
        _teamOwners.SetAccessPath(parentChainPath, validateHasBeenSet);
        _backlogType.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

