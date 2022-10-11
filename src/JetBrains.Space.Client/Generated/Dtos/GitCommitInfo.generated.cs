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

public sealed class GitCommitInfo
     : IPropagatePropertyAccessPath
{
    public GitCommitInfo() { }
    
    public GitCommitInfo(string id, string message, long authorDate, long commitDate, GitAuthorInfo author, GitAuthorInfo committer, List<string> parents, List<string> heads, TDMemberProfile? authorProfile = null, TDMemberProfile? committerProfile = null, GitCommitSignature? signature = null, bool? committerIsSpace = null)
    {
        Id = id;
        Message = message;
        AuthorDate = authorDate;
        CommitDate = commitDate;
        Author = author;
        AuthorProfile = authorProfile;
        Committer = committer;
        CommitterProfile = committerProfile;
        Parents = parents;
        Heads = heads;
        Signature = signature;
        IsCommitterIsSpace = committerIsSpace;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(GitCommitInfo), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _message = new PropertyValue<string>(nameof(GitCommitInfo), nameof(Message), "message");
    
    [Required]
    [JsonPropertyName("message")]
    public string Message
    {
        get => _message.GetValue(InlineErrors);
        set => _message.SetValue(value);
    }

    private PropertyValue<long> _authorDate = new PropertyValue<long>(nameof(GitCommitInfo), nameof(AuthorDate), "authorDate");
    
    [Required]
    [JsonPropertyName("authorDate")]
    public long AuthorDate
    {
        get => _authorDate.GetValue(InlineErrors);
        set => _authorDate.SetValue(value);
    }

    private PropertyValue<long> _commitDate = new PropertyValue<long>(nameof(GitCommitInfo), nameof(CommitDate), "commitDate");
    
    [Required]
    [JsonPropertyName("commitDate")]
    public long CommitDate
    {
        get => _commitDate.GetValue(InlineErrors);
        set => _commitDate.SetValue(value);
    }

    private PropertyValue<GitAuthorInfo> _author = new PropertyValue<GitAuthorInfo>(nameof(GitCommitInfo), nameof(Author), "author");
    
    [Required]
    [JsonPropertyName("author")]
    public GitAuthorInfo Author
    {
        get => _author.GetValue(InlineErrors);
        set => _author.SetValue(value);
    }

    private PropertyValue<TDMemberProfile?> _authorProfile = new PropertyValue<TDMemberProfile?>(nameof(GitCommitInfo), nameof(AuthorProfile), "authorProfile");
    
    [JsonPropertyName("authorProfile")]
    public TDMemberProfile? AuthorProfile
    {
        get => _authorProfile.GetValue(InlineErrors);
        set => _authorProfile.SetValue(value);
    }

    private PropertyValue<GitAuthorInfo> _committer = new PropertyValue<GitAuthorInfo>(nameof(GitCommitInfo), nameof(Committer), "committer");
    
    [Required]
    [JsonPropertyName("committer")]
    public GitAuthorInfo Committer
    {
        get => _committer.GetValue(InlineErrors);
        set => _committer.SetValue(value);
    }

    private PropertyValue<TDMemberProfile?> _committerProfile = new PropertyValue<TDMemberProfile?>(nameof(GitCommitInfo), nameof(CommitterProfile), "committerProfile");
    
    [JsonPropertyName("committerProfile")]
    public TDMemberProfile? CommitterProfile
    {
        get => _committerProfile.GetValue(InlineErrors);
        set => _committerProfile.SetValue(value);
    }

    private PropertyValue<List<string>> _parents = new PropertyValue<List<string>>(nameof(GitCommitInfo), nameof(Parents), "parents", new List<string>());
    
    [Required]
    [JsonPropertyName("parents")]
    public List<string> Parents
    {
        get => _parents.GetValue(InlineErrors);
        set => _parents.SetValue(value);
    }

    private PropertyValue<List<string>> _heads = new PropertyValue<List<string>>(nameof(GitCommitInfo), nameof(Heads), "heads", new List<string>());
    
    [Required]
    [JsonPropertyName("heads")]
    public List<string> Heads
    {
        get => _heads.GetValue(InlineErrors);
        set => _heads.SetValue(value);
    }

    private PropertyValue<GitCommitSignature?> _signature = new PropertyValue<GitCommitSignature?>(nameof(GitCommitInfo), nameof(Signature), "signature");
    
    [JsonPropertyName("signature")]
    public GitCommitSignature? Signature
    {
        get => _signature.GetValue(InlineErrors);
        set => _signature.SetValue(value);
    }

    private PropertyValue<bool?> _committerIsSpace = new PropertyValue<bool?>(nameof(GitCommitInfo), nameof(IsCommitterIsSpace), "committerIsSpace");
    
    [JsonPropertyName("committerIsSpace")]
    public bool? IsCommitterIsSpace
    {
        get => _committerIsSpace.GetValue(InlineErrors);
        set => _committerIsSpace.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _message.SetAccessPath(parentChainPath, validateHasBeenSet);
        _authorDate.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commitDate.SetAccessPath(parentChainPath, validateHasBeenSet);
        _author.SetAccessPath(parentChainPath, validateHasBeenSet);
        _authorProfile.SetAccessPath(parentChainPath, validateHasBeenSet);
        _committer.SetAccessPath(parentChainPath, validateHasBeenSet);
        _committerProfile.SetAccessPath(parentChainPath, validateHasBeenSet);
        _parents.SetAccessPath(parentChainPath, validateHasBeenSet);
        _heads.SetAccessPath(parentChainPath, validateHasBeenSet);
        _signature.SetAccessPath(parentChainPath, validateHasBeenSet);
        _committerIsSpace.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

