using System;
using System.Net;
using JetBrains.Annotations;

namespace JetBrains.Space.Common;

/// <summary>
/// Represents an exception thrown when rate limited.
/// </summary>
[PublicAPI]
public class RateLimitedException 
    : ResourceException
{
    /// <inheritdoc />
    public RateLimitedException()
    {
    }

    /// <inheritdoc />
    public RateLimitedException(string message) 
        : base(message)
    {
    }

    /// <inheritdoc />
    public RateLimitedException(string message, Uri? requestUri, HttpStatusCode statusCode, string? response) 
        : base(message, requestUri, statusCode, response)
    {
    }
}