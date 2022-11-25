using System;
using System.Net;
using JetBrains.Annotations;

namespace JetBrains.Space.Common;

/// <summary>
/// Represents an exception thrown when permission is denied.
/// </summary>
[PublicAPI]
public class PermissionDeniedException 
    : ResourceException
{
    /// <inheritdoc />
    public PermissionDeniedException()
    {
    }

    /// <inheritdoc />
    public PermissionDeniedException(string message) 
        : base(message)
    {
    }

    /// <inheritdoc />
    public PermissionDeniedException(string message, Uri? requestUri, HttpStatusCode statusCode, string? response) 
        : base(message, requestUri, statusCode, response)
    {
    }
}