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

public interface MCInlineElementDetails
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static MCIcon MCIcon(string name, MessageStyle? style = null)
        => new MCIcon(name: name, style: style);
    
    public static MCInlineText MCInlineText(string content, bool markdown, MessageStyle? style = null)
        => new MCInlineText(content: content, markdown: markdown, style: style);
    
    public static MCTag MCTag(string text, MessageStyle? style = null)
        => new MCTag(text: text, style: style);
    
    public static MCTimestamp MCTimestamp(long ts, bool strikethrough, MessageStyle? style = null, MessageTimestampFormat? format = null)
        => new MCTimestamp(ts: ts, strikethrough: strikethrough, style: style, format: format);
    
}

