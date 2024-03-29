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

namespace JetBrains.Space.Client.TextDocumentHttpBodyPartialBuilder;

public static class TextDocumentHttpBodyPartialExtensions
{
    public static Partial<TextDocumentHttpBody> WithDocContent(this Partial<TextDocumentHttpBody> it)
        => it.AddFieldName("docContent");
    
    public static Partial<TextDocumentHttpBody> WithDocContent(this Partial<TextDocumentHttpBody> it, Func<Partial<TextDocumentContent>, Partial<TextDocumentContent>> partialBuilder)
        => it.AddFieldName("docContent", partialBuilder(new Partial<TextDocumentContent>(it)));
    
    public static Partial<TextDocumentHttpBody> WithAttachments(this Partial<TextDocumentHttpBody> it)
        => it.AddFieldName("attachments");
    
    public static Partial<TextDocumentHttpBody> WithAttachments(this Partial<TextDocumentHttpBody> it, Func<Partial<AttachmentInfo>, Partial<AttachmentInfo>> partialBuilder)
        => it.AddFieldName("attachments", partialBuilder(new Partial<AttachmentInfo>(it)));
    
}

