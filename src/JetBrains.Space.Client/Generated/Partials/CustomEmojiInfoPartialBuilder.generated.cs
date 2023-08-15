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

namespace JetBrains.Space.Client.CustomEmojiInfoPartialBuilder;

public static class CustomEmojiInfoPartialExtensions
{
    public static Partial<CustomEmojiInfo> WithName(this Partial<CustomEmojiInfo> it)
        => it.AddFieldName("name");
    
    public static Partial<CustomEmojiInfo> WithProvider(this Partial<CustomEmojiInfo> it)
        => it.AddFieldName("provider");
    
    public static Partial<CustomEmojiInfo> WithProvider(this Partial<CustomEmojiInfo> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
        => it.AddFieldName("provider", partialBuilder(new Partial<CPrincipal>(it)));
    
    public static Partial<CustomEmojiInfo> WithUploaded(this Partial<CustomEmojiInfo> it)
        => it.AddFieldName("uploaded");
    
    public static Partial<CustomEmojiInfo> WithAttachmentId(this Partial<CustomEmojiInfo> it)
        => it.AddFieldName("attachmentId");
    
    public static Partial<CustomEmojiInfo> WithIsDeleted(this Partial<CustomEmojiInfo> it)
        => it.AddFieldName("deleted");
    
}
