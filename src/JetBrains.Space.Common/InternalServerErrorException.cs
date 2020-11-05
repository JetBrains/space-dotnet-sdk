using System.Net;
using JetBrains.Annotations;

namespace JetBrains.Space.Common
{
    /// <summary>
    /// Represents an exception thrown when an internal server error occurs.
    /// </summary>
    [PublicAPI]
    public class InternalServerErrorException 
        : ResourceException
    {
        /// <inheritdoc />
        public InternalServerErrorException()
        {
        }

        /// <inheritdoc />
        public InternalServerErrorException(string message) 
            : base(message)
        {
        }

        /// <inheritdoc />
        public InternalServerErrorException(string message, HttpStatusCode statusCode, string response) 
            : base(message, statusCode, response)
        {
        }
    }
}