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

public sealed class IdeFormerCustomPrompts
     : IPropagatePropertyAccessPath
{
    public IdeFormerCustomPrompts() { }
    
    public IdeFormerCustomPrompts(string? planningSystemMessage = null, string? planningPromptTemplate = null, string? codeEditingSystemMessage = null, string? editFilePromptTemplate = null, string? createFilePromptTemplate = null)
    {
        PlanningSystemMessage = planningSystemMessage;
        PlanningPromptTemplate = planningPromptTemplate;
        CodeEditingSystemMessage = codeEditingSystemMessage;
        EditFilePromptTemplate = editFilePromptTemplate;
        CreateFilePromptTemplate = createFilePromptTemplate;
    }
    
    private PropertyValue<string?> _planningSystemMessage = new PropertyValue<string?>(nameof(IdeFormerCustomPrompts), nameof(PlanningSystemMessage), "planningSystemMessage");
    
    [JsonPropertyName("planningSystemMessage")]
    public string? PlanningSystemMessage
    {
        get => _planningSystemMessage.GetValue(InlineErrors);
        set => _planningSystemMessage.SetValue(value);
    }

    private PropertyValue<string?> _planningPromptTemplate = new PropertyValue<string?>(nameof(IdeFormerCustomPrompts), nameof(PlanningPromptTemplate), "planningPromptTemplate");
    
    [JsonPropertyName("planningPromptTemplate")]
    public string? PlanningPromptTemplate
    {
        get => _planningPromptTemplate.GetValue(InlineErrors);
        set => _planningPromptTemplate.SetValue(value);
    }

    private PropertyValue<string?> _codeEditingSystemMessage = new PropertyValue<string?>(nameof(IdeFormerCustomPrompts), nameof(CodeEditingSystemMessage), "codeEditingSystemMessage");
    
    [JsonPropertyName("codeEditingSystemMessage")]
    public string? CodeEditingSystemMessage
    {
        get => _codeEditingSystemMessage.GetValue(InlineErrors);
        set => _codeEditingSystemMessage.SetValue(value);
    }

    private PropertyValue<string?> _editFilePromptTemplate = new PropertyValue<string?>(nameof(IdeFormerCustomPrompts), nameof(EditFilePromptTemplate), "editFilePromptTemplate");
    
    [JsonPropertyName("editFilePromptTemplate")]
    public string? EditFilePromptTemplate
    {
        get => _editFilePromptTemplate.GetValue(InlineErrors);
        set => _editFilePromptTemplate.SetValue(value);
    }

    private PropertyValue<string?> _createFilePromptTemplate = new PropertyValue<string?>(nameof(IdeFormerCustomPrompts), nameof(CreateFilePromptTemplate), "createFilePromptTemplate");
    
    [JsonPropertyName("createFilePromptTemplate")]
    public string? CreateFilePromptTemplate
    {
        get => _createFilePromptTemplate.GetValue(InlineErrors);
        set => _createFilePromptTemplate.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _planningSystemMessage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _planningPromptTemplate.SetAccessPath(parentChainPath, validateHasBeenSet);
        _codeEditingSystemMessage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _editFilePromptTemplate.SetAccessPath(parentChainPath, validateHasBeenSet);
        _createFilePromptTemplate.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
