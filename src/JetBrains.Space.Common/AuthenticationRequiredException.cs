using System.Net;
using JetBrains.Annotations;

namespace JetBrains.Space.Common;

/// <summary>
/// Represents an exception thrown when authentication is required.
/// </summary>
[PublicAPI]
public class AuthenticationRequiredException 
    : ResourceException
{
    /// <inheritdoc />
    public AuthenticationRequiredException()
    {
    }

    /// <inheritdoc />
    public AuthenticationRequiredException(string message) 
        : base(message)
    {
    }

    /// <inheritdoc />
    public AuthenticationRequiredException(string message, Uri? requestUri, string? functionName, HttpStatusCode statusCode, string? response) 
        : base(message, requestUri, functionName, statusCode, response)
    {
    }
}