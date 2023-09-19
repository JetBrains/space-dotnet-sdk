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

public partial class IssueClient : ISpaceClient
{
    private readonly Connection _connection;
    
    public IssueClient(Connection connection)
    {
        _connection = connection;
    }
    
    /// <summary>
    /// Retrieve list of issues by identifiers. Issues can belong to different projects. Up to 100 issues can be retrieved within a single request. See also <a href="/extensions/httpApiPlayground?resource=projects_xxx_planning_issues&amp;endpoint=rest_query">Get all issues</a> (`/projects/{project}/planning/issues`)
    /// </summary>
    /// <remarks>
    /// Required permissions:
    /// <list type="bullet">
    /// <item>
    /// <term>View issues</term>
    /// <description>View issues in a project</description>
    /// </item>
    /// </list>
    /// </remarks>
    public async Task<List<Issue>> GetIssuesByIdentifiersAsync(List<IssueIdentifier> issueIdentifiers, bool? withDeleted = null, Func<Partial<Issue>, Partial<Issue>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        queryParameters.Append("$fields", (partial != null ? partial(new Partial<Issue>()) : Partial<Issue>.Default()).ToString());
        
        return await _connection.RequestResourceAsync<IssuesGetByIdsPostRequest, List<Issue>>("POST", $"api/http/issues/get-by-ids{queryParameters.ToQueryString()}", 
            new IssuesGetByIdsPostRequest
            { 
                IssueIdentifiers = issueIdentifiers,
                IsWithDeleted = withDeleted,
            }, requestHeaders: null, functionName: "GetIssuesByIdentifiers", cancellationToken: cancellationToken);
    }
    

    /// <summary>
    /// Retrieve an issue by its identifier
    /// </summary>
    /// <remarks>
    /// Required permissions:
    /// <list type="bullet">
    /// <item>
    /// <term>View issues</term>
    /// <description>View issues in a project</description>
    /// </item>
    /// </list>
    /// </remarks>
    public async Task<Issue> GetIssueAsync(IssueIdentifier issueId, Func<Partial<Issue>, Partial<Issue>>? partial = null, Dictionary<string, string>? requestHeaders = null, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        queryParameters.Append("issueId", issueId.ToString());
        queryParameters.Append("$fields", (partial != null ? partial(new Partial<Issue>()) : Partial<Issue>.Default()).ToString());
        
        return await _connection.RequestResourceAsync<Issue>("GET", $"api/http/issues{queryParameters.ToQueryString()}", requestHeaders: null, functionName: "GetIssue", cancellationToken: cancellationToken);
    }
    

}

