using System.Net;
using JetBrains.Annotations;

namespace JetBrains.Space.Common;

/// <summary>
/// Represents an exception thrown when payload is too large.
/// </summary>
[PublicAPI]
public class PayloadTooLargeException 
    : ResourceException
{
    /// <inheritdoc />
    public PayloadTooLargeException()
    {
    }

    /// <inheritdoc />
    public PayloadTooLargeException(string message) 
        : base(message)
    {
    }

    /// <inheritdoc />
    public PayloadTooLargeException(string message, Uri? requestUri, string? functionName, HttpStatusCode statusCode, string? response) 
        : base(message, requestUri, functionName, statusCode, response)
    {
    }
}