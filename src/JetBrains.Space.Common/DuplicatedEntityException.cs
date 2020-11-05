using System.Net;
using JetBrains.Annotations;

namespace JetBrains.Space.Common
{
    /// <summary>
    /// Represents an exception thrown when an entity is a duplicate.
    /// </summary>
    [PublicAPI]
    public class DuplicatedEntityException 
        : ResourceException
    {
        /// <inheritdoc />
        public DuplicatedEntityException()
        {
        }

        /// <inheritdoc />
        public DuplicatedEntityException(string message) 
            : base(message)
        {
        }

        /// <inheritdoc />
        public DuplicatedEntityException(string message, HttpStatusCode statusCode, string response) 
            : base(message, statusCode, response)
        {
        }
    }
}