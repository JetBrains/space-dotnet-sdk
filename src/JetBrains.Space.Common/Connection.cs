using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Common;

/// <summary>
/// Abstract base class which represents a connection against a Space organization and provides
/// the necessary infrastructure to make requests to it.
/// </summary>
[PublicAPI]
public abstract class Connection
{
    /// <summary>
    /// Space organization URL that will be connected against.
    /// </summary>
    public Uri ServerUrl { get; }

    /// <summary>
    /// JSON serializer options that will be used when (de)serializing options.
    /// </summary>
    protected static readonly JsonSerializerOptions JsonSerializerOptions = new();
        
    /// <summary>
    /// Initializes static members of the <see cref="Connection" /> class.
    /// </summary>
    static Connection()
    {
        JsonSerializerOptions.AddSpaceJsonTypeConverters();
    }
        
    /// <summary>
    /// Creates an instance of the <see cref="Connection" /> class.
    /// </summary>
    /// <param name="serverUrl">Space organization URL that will be connected against.</param>
    protected Connection(Uri serverUrl)
    {
        ServerUrl = serverUrl;
    }

    /// <summary>
    /// Requests a resource at a given URL.
    /// </summary>
    /// <param name="httpMethod">The HTTP method to use.</param>
    /// <param name="urlPath">The path to access the resource.</param>
    /// <param name="requestHeaders">Request headers to send to the resource.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
    public async Task RequestResourceAsync(string httpMethod, string urlPath, Dictionary<string, string>? requestHeaders, CancellationToken cancellationToken = default)
    {
        await RequestResourceInternalAsync(httpMethod, urlPath, requestHeaders, cancellationToken);
    }
        
    /// <summary>
    /// Requests a resource at a given URL.
    /// </summary>
    /// <param name="httpMethod">The HTTP method to use.</param>
    /// <param name="urlPath">The path to access the resource.</param>
    /// <param name="requestHeaders">Request headers to send to the resource.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <returns>The requested resource.</returns>
    /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
    public async Task<TResult> RequestResourceAsync<TResult>(string httpMethod, string urlPath, Dictionary<string, string>? requestHeaders, CancellationToken cancellationToken = default)
    {
        var value = await RequestResourceInternalAsync<TResult>(httpMethod, urlPath, requestHeaders, cancellationToken);
           
        PropagatePropertyAccessPathHelper.SetAccessPathForValue(typeof(TResult).Name, true, value);
            
        return value;
    }

    /// <summary>
    /// Sends a payload to a resource at a given URL.
    /// </summary>
    /// <param name="httpMethod">The HTTP method to use.</param>
    /// <param name="urlPath">The path to access the resource.</param>
    /// <param name="payload">The payload to send to the resource.</param>
    /// <param name="requestHeaders">Request headers to send to the resource.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
    public async Task RequestResourceAsync<TPayload>(string httpMethod, string urlPath, TPayload payload, Dictionary<string, string>? requestHeaders, CancellationToken cancellationToken = default)
    {
        await RequestResourceInternalAsync(httpMethod, urlPath, payload, requestHeaders, cancellationToken);
    }
        
    /// <summary>
    /// Sends a payload to a resource at a given URL.
    /// </summary>
    /// <param name="httpMethod">The HTTP method to use.</param>
    /// <param name="urlPath">The path to access the resource.</param>
    /// <param name="payload">The payload to send to the resource.</param>
    /// <param name="requestHeaders">Request headers to send to the resource.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <returns>The requested resource.</returns>
    /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
    public async Task<TResult> RequestResourceAsync<TPayload, TResult>(string httpMethod, string urlPath, TPayload payload, Dictionary<string, string>? requestHeaders, CancellationToken cancellationToken = default)
    {
        var value = await RequestResourceInternalAsync<TPayload, TResult>(httpMethod, urlPath, payload, requestHeaders, cancellationToken);
            
        PropagatePropertyAccessPathHelper.SetAccessPathForValue(typeof(TResult).Name, true, value);
            
        return value;
    }
        
    /// <summary>
    /// Requests a blob resource at a given URL.
    /// </summary>
    /// <param name="httpMethod">The HTTP method to use.</param>
    /// <param name="urlPath">The path to access the resource.</param>
    /// <param name="requestHeaders">Request headers to send to the resource.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <returns>The requested resource.</returns>
    /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
    public async Task<SpaceBlob> RequestBlobResourceAsync(string httpMethod, string urlPath, CancellationToken cancellationToken = default)
    {
        return await RequestBlobResourceInternalAsync(httpMethod, urlPath, cancellationToken);
    }
        
    /// <summary>
    /// Requests a resource at a given URL.
    /// </summary>
    /// <param name="httpMethod">The HTTP method to use.</param>
    /// <param name="urlPath">The path to access the resource.</param>
    /// <param name="requestHeaders">Request headers to send to the resource.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
    protected abstract Task RequestResourceInternalAsync(string httpMethod, string urlPath, Dictionary<string, string>? requestHeaders, CancellationToken cancellationToken);
        
    /// <summary>
    /// Requests a resource at a given URL.
    /// </summary>
    /// <param name="httpMethod">The HTTP method to use.</param>
    /// <param name="urlPath">The path to access the resource.</param>
    /// <param name="requestHeaders">Request headers to send to the resource.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <returns>The requested resource.</returns>
    /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
    protected abstract Task<TResult> RequestResourceInternalAsync<TResult>(string httpMethod, string urlPath, Dictionary<string, string>? requestHeaders, CancellationToken cancellationToken);
        
    /// <summary>
    /// Sends a payload to a resource at a given URL.
    /// </summary>
    /// <param name="httpMethod">The HTTP method to use.</param>
    /// <param name="urlPath">The path to access the resource.</param>
    /// <param name="payload">The payload to send to the resource.</param>
    /// <param name="requestHeaders">Request headers to send to the resource.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
    protected abstract Task RequestResourceInternalAsync<TPayload>(string httpMethod, string urlPath, TPayload payload, Dictionary<string, string>? requestHeaders, CancellationToken cancellationToken);
        
    /// <summary>
    /// Sends a payload to a resource at a given URL.
    /// </summary>
    /// <param name="httpMethod">The HTTP method to use.</param>
    /// <param name="urlPath">The path to access the resource.</param>
    /// <param name="payload">The payload to send to the resource.</param>
    /// <param name="requestHeaders">Request headers to send to the resource.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <returns>The requested resource.</returns>
    /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
    protected abstract Task<TResult> RequestResourceInternalAsync<TPayload, TResult>(string httpMethod, string urlPath, TPayload payload, Dictionary<string, string>? requestHeaders, CancellationToken cancellationToken);
        
    /// <summary>
    /// Requests a blob resource at a given URL.
    /// </summary>
    /// <param name="httpMethod">The HTTP method to use.</param>
    /// <param name="urlPath">The path to access the resource.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <returns>The requested resource.</returns>
    /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
    protected abstract Task<SpaceBlob> RequestBlobResourceInternalAsync(string httpMethod, string urlPath, CancellationToken cancellationToken);
}