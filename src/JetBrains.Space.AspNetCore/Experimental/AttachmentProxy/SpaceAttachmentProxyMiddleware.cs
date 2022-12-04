using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using JetBrains.Annotations;
using JetBrains.Space.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;

namespace JetBrains.Space.AspNetCore.Experimental.AttachmentProxy;

/// <summary>
/// Space attachment proxy middleware.
/// </summary>
[PublicAPI]
public class SpaceAttachmentProxyMiddleware
{
    private readonly ILogger<SpaceAttachmentProxyMiddleware> _logger;

    private readonly Dictionary<string, string> _defaultHeaders = new()
    {
        {"X-Frame-Options", "deny"},
        {"X-XSS-Protection", "1; mode=block"},
        {"X-Content-Type-Options", "nosniff"},
        {"Content-Security-Policy", "frame-ancestors 'none'"}
    };

    /// <summary>
    /// Creates a new <see cref="SpaceAttachmentProxyMiddleware"/>.
    /// </summary>
    /// <param name="next">Next <see cref="RequestDelegate"/>. Will be ignored by this middleware.</param>
    /// <param name="logger">Logger to emit log entries.</param>
    public SpaceAttachmentProxyMiddleware(
        RequestDelegate next,
        ILogger<SpaceAttachmentProxyMiddleware> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Invokes middleware for the current request.
    /// </summary>
    /// <param name="context">The current <see cref="HttpContext"/>.</param>
    /// <param name="connection"><see cref="Connection"/> to access Space organization.</param>
    public async Task InvokeAsync(HttpContext context, Connection connection)
    {
        // Check request method
        if (!HttpMethods.IsGet(context.Request.Method) && !HttpMethods.IsHead(context.Request.Method))
        {
            _logger.LogWarning("Request method {RequestMethod} is not supported", context.Request.Method);
            WriteStatusCodeAndHeadersTo(context.Response, HttpStatusCode.MethodNotAllowed, _defaultHeaders);
            return;
        }

        // Get route values
        var resourceId = context.GetRouteValue("resourceId")?.ToString();
        if (string.IsNullOrEmpty(resourceId))
        {
            _logger.LogWarning("Resource identifier was not provided in the request");
            WriteStatusCodeAndHeadersTo(context.Response, HttpStatusCode.NotFound, _defaultHeaders);
            return;
        }

        try
        {
            // Stream response
            var upstreamBlob = await connection.RequestBlobResourceAsync("GET", $"d/{resourceId}", functionName: null);
            await using var upstreamResponseStream = upstreamBlob.Stream;

            // Not found
            if (upstreamResponseStream == null)
            {
                WriteStatusCodeAndHeadersTo(context.Response, HttpStatusCode.NotFound, _defaultHeaders);
                return;
            }
                
            // Pass upstream response stream
            var headers = new Dictionary<string, string>(_defaultHeaders);
            if (upstreamBlob.Etag != null)
            {
                headers.Add("Etag", upstreamBlob.Etag);
            }
            if (upstreamBlob.LastModified != null)
            {
                headers.Add("last-modified", upstreamBlob.LastModified);
            }
            if (upstreamBlob.ContentType != null)
            {
                headers.Add("content-type", upstreamBlob.ContentType);
            }
            WriteStatusCodeAndHeadersTo(context.Response, HttpStatusCode.OK, headers);
            await upstreamResponseStream.CopyToAsync(context.Response.Body);
        }
        catch (NotFoundException ex)
        {
            WriteStatusCodeAndHeadersTo(context.Response, ex.StatusCode ?? HttpStatusCode.NotFound, _defaultHeaders);
        }
        catch (AuthenticationRequiredException ex)
        {
            WriteStatusCodeAndHeadersTo(context.Response, ex.StatusCode ?? HttpStatusCode.Unauthorized, _defaultHeaders);
        }
        catch (ResourceException)
        {
            WriteStatusCodeAndHeadersTo(context.Response, HttpStatusCode.BadRequest, _defaultHeaders);
        }
    }

    private static void WriteStatusCodeAndHeadersTo(HttpResponse response, HttpStatusCode statusCode, Dictionary<string, string> headers)
    {
        response.StatusCode = (int)statusCode;
            
        foreach (var (key, value) in headers)
        {
            response.Headers.Append(key, value);
        }
    }
}