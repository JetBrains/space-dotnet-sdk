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

namespace JetBrains.Space.Client.ImportMessageCreatePartialBuilder;

public static class ImportMessageCreatePartialExtensions
{
    public static Partial<ImportMessageCreate> WithMessageId(this Partial<ImportMessageCreate> it)
        => it.AddFieldName("messageId");
    
    public static Partial<ImportMessageCreate> WithMessageId(this Partial<ImportMessageCreate> it, Func<Partial<ChatMessageIdentifierExternalId>, Partial<ChatMessageIdentifierExternalId>> partialBuilder)
        => it.AddFieldName("messageId", partialBuilder(new Partial<ChatMessageIdentifierExternalId>(it)));
    
    public static Partial<ImportMessageCreate> WithMessage(this Partial<ImportMessageCreate> it)
        => it.AddFieldName("message");
    
    public static Partial<ImportMessageCreate> WithMessage(this Partial<ImportMessageCreate> it, Func<Partial<ChatMessage>, Partial<ChatMessage>> partialBuilder)
        => it.AddFieldName("message", partialBuilder(new Partial<ChatMessage>(it)));
    
    public static Partial<ImportMessageCreate> WithAuthor(this Partial<ImportMessageCreate> it)
        => it.AddFieldName("author");
    
    public static Partial<ImportMessageCreate> WithAuthor(this Partial<ImportMessageCreate> it, Func<Partial<PrincipalIn>, Partial<PrincipalIn>> partialBuilder)
        => it.AddFieldName("author", partialBuilder(new Partial<PrincipalIn>(it)));
    
    public static Partial<ImportMessageCreate> WithCreatedAtUtc(this Partial<ImportMessageCreate> it)
        => it.AddFieldName("createdAtUtc");
    
    public static Partial<ImportMessageCreate> WithEditedAtUtc(this Partial<ImportMessageCreate> it)
        => it.AddFieldName("editedAtUtc");
    
    public static Partial<ImportMessageCreate> WithAttachments(this Partial<ImportMessageCreate> it)
        => it.AddFieldName("attachments");
    
    public static Partial<ImportMessageCreate> WithAttachments(this Partial<ImportMessageCreate> it, Func<Partial<AttachmentIn>, Partial<AttachmentIn>> partialBuilder)
        => it.AddFieldName("attachments", partialBuilder(new Partial<AttachmentIn>(it)));
    
}

