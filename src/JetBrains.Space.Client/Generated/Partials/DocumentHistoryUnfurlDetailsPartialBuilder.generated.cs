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

namespace JetBrains.Space.Client.DocumentHistoryUnfurlDetailsPartialBuilder;

public static class DocumentHistoryUnfurlDetailsPartialExtensions
{
    public static Partial<DocumentHistoryUnfurlDetails> WithDocument(this Partial<DocumentHistoryUnfurlDetails> it)
        => it.AddFieldName("document");
    
    public static Partial<DocumentHistoryUnfurlDetails> WithTitle(this Partial<DocumentHistoryUnfurlDetails> it)
        => it.AddFieldName("title");
    
    public static Partial<DocumentHistoryUnfurlDetails> WithVersion2(this Partial<DocumentHistoryUnfurlDetails> it)
        => it.AddFieldName("version2");
    
    public static Partial<DocumentHistoryUnfurlDetails> WithBase2(this Partial<DocumentHistoryUnfurlDetails> it)
        => it.AddFieldName("base2");
    
    public static Partial<DocumentHistoryUnfurlDetails> WithPreview2(this Partial<DocumentHistoryUnfurlDetails> it)
        => it.AddFieldName("preview2");
    
}

