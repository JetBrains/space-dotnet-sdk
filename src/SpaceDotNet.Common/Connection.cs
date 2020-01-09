using System;
using System.Threading.Tasks;

namespace SpaceDotNet.Common
{
    /// <summary>
    /// Abstract base class which represents a connection against a Space organization and provides
    /// the necessary infrastructure to make requests to it.
    /// </summary>
    public abstract class Connection
    {
        /// <summary>
        /// Space organization URL that will be connected against.
        /// </summary>
        protected Uri ServerUri { get; }
        
        /// <summary>
        /// Creates an instance of the <see cref="Connection" /> class.
        /// </summary>
        /// <param name="serverUrl">Space organization URL that will be connected against.</param>
        /// <exception cref="ArgumentException">
        /// The <paramref name="serverUrl" /> was null, empty or did not represent a valid and absolute <see cref="T:System.Uri" />.
        /// </exception>
        protected Connection(string serverUrl)
        {
            if (string.IsNullOrEmpty(serverUrl)
                || !Uri.TryCreate(EnsureTrailingSlash(serverUrl), UriKind.Absolute, out var serverUri))
            {
                throw new ArgumentException("The Space organization URL is invalid.", nameof(serverUrl));
            }

            ServerUri = serverUri;
        }
        
        /// <summary>
        /// Ensures a trailing slash is present for the given string.
        /// </summary>
        /// <param name="url">URL represented as a <see cref="T:System.String" /></param>
        /// <returns>A <see cref="T:System.String" /> with trailing slash based on <paramref name="url" />.</returns>
        private static string EnsureTrailingSlash(string url) => !url.EndsWith("/") ? url + "/" : url;

        /// <summary>
        /// Requests a resource at a given URL.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="urlPath">The path to access the resource.</param>
        /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
        public abstract Task RequestResourceAsync(string httpMethod, string urlPath);

        /// <summary>
        /// Requests a resource at a given URL.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="urlPath">The path to access the resource.</param>
        /// <returns>The requested resource.</returns>
        /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
        public abstract Task<TResult> RequestResourceAsync<TResult>(string httpMethod, string urlPath);

        /// <summary>
        /// Sends a payload to a resource at a given URL.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="urlPath">The path to access the resource.</param>
        /// <param name="payload">The payload to send to the resource.</param>
        /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
        public abstract Task RequestResourceAsync<TPayload>(string httpMethod, string urlPath, TPayload payload);

        /// <summary>
        /// Sends a payload to a resource at a given URL.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="urlPath">The path to access the resource.</param>
        /// <param name="payload">The payload to send to the resource.</param>
        /// <returns>The requested resource.</returns>
        /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
        public abstract Task<TResult> RequestResourceAsync<TPayload, TResult>(string httpMethod, string urlPath, TPayload payload);
    }
}