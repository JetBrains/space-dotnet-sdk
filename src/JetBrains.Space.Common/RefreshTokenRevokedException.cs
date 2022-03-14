using System.Net;
using JetBrains.Annotations;

namespace JetBrains.Space.Common;

/// <summary>
/// Represents an exception thrown when a refresh token is revoked.
/// </summary>
[PublicAPI]
public class RefreshTokenRevokedException 
    : ResourceException
{
    /// <inheritdoc />
    public RefreshTokenRevokedException()
    {
    }

    /// <inheritdoc />
    public RefreshTokenRevokedException(string message) 
        : base(message)
    {
    }

    /// <inheritdoc />
    public RefreshTokenRevokedException(string message, HttpStatusCode statusCode, string? response) 
        : base(message, statusCode, response)
    {
    }
}