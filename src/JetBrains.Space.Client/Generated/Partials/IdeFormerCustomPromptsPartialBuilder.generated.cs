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

namespace JetBrains.Space.Client.IdeFormerCustomPromptsPartialBuilder;

public static class IdeFormerCustomPromptsPartialExtensions
{
    public static Partial<IdeFormerCustomPrompts> WithPlanningSystemMessage(this Partial<IdeFormerCustomPrompts> it)
        => it.AddFieldName("planningSystemMessage");
    
    public static Partial<IdeFormerCustomPrompts> WithPlanningPromptTemplate(this Partial<IdeFormerCustomPrompts> it)
        => it.AddFieldName("planningPromptTemplate");
    
    public static Partial<IdeFormerCustomPrompts> WithCodeEditingSystemMessage(this Partial<IdeFormerCustomPrompts> it)
        => it.AddFieldName("codeEditingSystemMessage");
    
    public static Partial<IdeFormerCustomPrompts> WithEditFilePromptTemplate(this Partial<IdeFormerCustomPrompts> it)
        => it.AddFieldName("editFilePromptTemplate");
    
    public static Partial<IdeFormerCustomPrompts> WithCreateFilePromptTemplate(this Partial<IdeFormerCustomPrompts> it)
        => it.AddFieldName("createFilePromptTemplate");
    
}

