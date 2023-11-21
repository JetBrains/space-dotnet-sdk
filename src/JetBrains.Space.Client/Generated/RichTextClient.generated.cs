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

public partial class RichTextClient : ISpaceClient
{
    private readonly Connection _connection;
    
    public RichTextClient(Connection connection)
    {
        _connection = connection;
    }
    
    /// <summary>
    /// Parses <a href="https://www.jetbrains.com/help/space/markdown-syntax.html">Space markdown syntax</a> into a tree presentation
    /// </summary>
    /// <remarks>
    /// We are currently refining the hierarchy of the RtDocument, and it is likely to undergo changes in the near future. This hierarchy will be utilized in various subsystems such as documents, chats, and issues.
    /// </remarks>
#if NET8_0_OR_GREATER
    [System.Diagnostics.CodeAnalysis.Experimental("SPC001")]
#elif NET6_0_OR_GREATER
    [Obsolete("We are currently refining the hierarchy of the RtDocument, and it is likely to undergo changes in the near future. This hierarchy will be utilized in various subsystems such as documents, chats, and issues.", DiagnosticId = "SPC001")]
#else
    [Obsolete("We are currently refining the hierarchy of the RtDocument, and it is likely to undergo changes in the near future. This hierarchy will be utilized in various subsystems such as documents, chats, and issues.")]
#endif
    
    public async Task<RtDocument> ParseMarkdownAsync(string text, string? schemaVersion = null, Func<Partial<RtDocument>, Partial<RtDocument>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        queryParameters.Append("$fields", (partial != null ? partial(new Partial<RtDocument>()) : Partial<RtDocument>.Default()).ToString());
        
        return await _connection.RequestResourceAsync<RichTextParseMarkdownPostRequest, RtDocument>("POST", $"api/http/rich-text/parse-markdown{queryParameters.ToQueryString()}", 
            new RichTextParseMarkdownPostRequest
            { 
                Text = text,
                SchemaVersion = schemaVersion,
            }, requestHeaders: null, functionName: "ParseMarkdown", cancellationToken: cancellationToken);
    }
    

}

