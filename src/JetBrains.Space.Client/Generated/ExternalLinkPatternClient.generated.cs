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

public partial class ExternalLinkPatternClient : ISpaceClient
{
    private readonly Connection _connection;
    
    public ExternalLinkPatternClient(Connection connection)
    {
        _connection = connection;
    }
    
    /// <summary>
    /// Add a prefix to be expanded to external links
    /// <a href="https://www.jetbrains.com/help/space/external-links.html">Read more...</a>
    /// </summary>
    /// <remarks>
    /// Required permissions:
    /// <list type="bullet">
    /// <item>
    /// <term>Manage external entity link patterns</term>
    /// </item>
    /// </list>
    /// </remarks>
    public async Task CreateExternalLinkPatternAsync(string pattern, string linkReplacement, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        
        await _connection.RequestResourceAsync("POST", $"api/http/external-link-patterns{queryParameters.ToQueryString()}", 
            new ExternalLinkPatternsPostRequest
            { 
                Pattern = pattern,
                LinkReplacement = linkReplacement,
            }, requestHeaders: null, functionName: "CreateExternalLinkPattern", cancellationToken: cancellationToken);
    }
    

    /// <summary>
    /// List all prefixes to be automatically expanded to external links
    /// <a href="https://www.jetbrains.com/help/space/external-links.html">Read more...</a>
    /// </summary>
    /// <remarks>
    /// Required permissions:
    /// <list type="bullet">
    /// <item>
    /// <term>View external entity link patterns</term>
    /// </item>
    /// </list>
    /// </remarks>
    public async Task<List<ExternalLinkPattern>> GetAllExternalLinkPatternsAsync(Func<Partial<ExternalLinkPattern>, Partial<ExternalLinkPattern>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        queryParameters.Append("$fields", (partial != null ? partial(new Partial<ExternalLinkPattern>()) : Partial<ExternalLinkPattern>.Default()).ToString());
        
        return await _connection.RequestResourceAsync<List<ExternalLinkPattern>>("GET", $"api/http/external-link-patterns{queryParameters.ToQueryString()}", requestHeaders: null, functionName: "GetAllExternalLinkPatterns", cancellationToken: cancellationToken);
    }
    

    /// <summary>
    /// Delete prefix for expanding to external links
    /// <a href="https://www.jetbrains.com/help/space/external-links.html">Read more...</a>
    /// </summary>
    /// <remarks>
    /// Required permissions:
    /// <list type="bullet">
    /// <item>
    /// <term>Manage external entity link patterns</term>
    /// </item>
    /// </list>
    /// </remarks>
    public async Task DeleteExternalLinkPatternAsync(string pattern, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        queryParameters.Append("pattern", pattern);
        
        await _connection.RequestResourceAsync("DELETE", $"api/http/external-link-patterns{queryParameters.ToQueryString()}", requestHeaders: null, functionName: "DeleteExternalLinkPattern", cancellationToken: cancellationToken);
    }
    

}

