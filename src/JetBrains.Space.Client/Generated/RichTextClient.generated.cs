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
    /// Parses [Space markdown syntax](https://www.jetbrains.com/help/space/markdown-syntax.html) into a tree presentation
    /// </summary>
    public async Task<RtDocument> ParseMarkdownAsync(string text, Func<Partial<RtDocument>, Partial<RtDocument>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        queryParameters.Append("$fields", (partial != null ? partial(new Partial<RtDocument>()) : Partial<RtDocument>.Default()).ToString());
        
        return await _connection.RequestResourceAsync<RichTextParseMarkdownPostRequest, RtDocument>("POST", $"api/http/rich-text/parse-markdown{queryParameters.ToQueryString()}", 
            new RichTextParseMarkdownPostRequest
            { 
                Text = text,
            }, requestHeaders: null, functionName: "ParseMarkdown", cancellationToken: cancellationToken);
    }
    

}

