using System.Net;
using JetBrains.Annotations;

namespace JetBrains.Space.Common;

/// <summary>
/// Represents an exception thrown when a resource is not found.
/// </summary>
[PublicAPI]
public class NotFoundException 
    : ResourceException
{
    /// <inheritdoc />
    public NotFoundException()
    {
    }

    /// <inheritdoc />
    public NotFoundException(string message) 
        : base(message)
    {
    }

    /// <inheritdoc />
    public NotFoundException(string message, HttpStatusCode statusCode, string? response) 
        : base(message, statusCode, response)
    {
    }
}