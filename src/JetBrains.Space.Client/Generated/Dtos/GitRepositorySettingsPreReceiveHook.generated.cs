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

public sealed class GitRepositorySettingsPreReceiveHook
     : IPropagatePropertyAccessPath
{
    public GitRepositorySettingsPreReceiveHook() { }
    
    public GitRepositorySettingsPreReceiveHook(string? serverUrl = null, string? script = null, string? scriptOid = null)
    {
        ServerUrl = serverUrl;
        Script = script;
        ScriptOid = scriptOid;
    }
    
    private PropertyValue<string?> _serverUrl = new PropertyValue<string?>(nameof(GitRepositorySettingsPreReceiveHook), nameof(ServerUrl), "serverUrl");
    
    [JsonPropertyName("serverUrl")]
    public string? ServerUrl
    {
        get => _serverUrl.GetValue(InlineErrors);
        set => _serverUrl.SetValue(value);
    }

    private PropertyValue<string?> _script = new PropertyValue<string?>(nameof(GitRepositorySettingsPreReceiveHook), nameof(Script), "script");
    
    [JsonPropertyName("script")]
    public string? Script
    {
        get => _script.GetValue(InlineErrors);
        set => _script.SetValue(value);
    }

    private PropertyValue<string?> _scriptOid = new PropertyValue<string?>(nameof(GitRepositorySettingsPreReceiveHook), nameof(ScriptOid), "scriptOid");
    
    [JsonPropertyName("scriptOid")]
    public string? ScriptOid
    {
        get => _scriptOid.GetValue(InlineErrors);
        set => _scriptOid.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _serverUrl.SetAccessPath(parentChainPath, validateHasBeenSet);
        _script.SetAccessPath(parentChainPath, validateHasBeenSet);
        _scriptOid.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

