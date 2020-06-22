using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

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
        protected Uri ServerUrl { get; }

        /// <summary>
        /// JSON serializer options that will be used when (de)serializing options.
        /// </summary>
        protected static readonly JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions();
        
        /// <summary>
        /// Initializes static members of the <see cref="Connection" /> class.
        /// </summary>
        static Connection()
        {
            JsonSerializerOptions.Converters.Add(new ClassNameInterfaceDtoTypeConverter());
        }
        
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

            ServerUrl = serverUri;
        }
        
        /// <summary>
        /// Ensures a trailing slash is present for the given string.
        /// </summary>
        /// <param name="url">URL represented as a <see cref="T:System.String" /></param>
        /// <returns>A <see cref="T:System.String" /> with trailing slash based on <paramref name="url" />.</returns>
        private static string EnsureTrailingSlash(string url) => !url.EndsWith("/") ? url + "/" : url;

        /// <summary>
        /// Clean nullable null query string parameters - Space API requires nullable null values to not be present as part of the URL.
        /// </summary>
        /// <param name="urlPath">URL path to clean.</param>
        /// <returns>A <see cref="T:System.String" /> that does not contain valueless query string parameters.</returns>
        private static string CleanNullableNullQueryStringParameters(string urlPath)
        {
            var pathAndQuery = urlPath.Split('?', StringSplitOptions.RemoveEmptyEntries);

            if (pathAndQuery.Length > 1)
            {
                // Strip empty entries
                var queryStringCollection = HttpUtility.ParseQueryString(pathAndQuery[1]);
                foreach (var key in queryStringCollection.AllKeys)
                {
                    if (queryStringCollection[key] == "null")
                    {
                        queryStringCollection.Remove(key);
                    }
                    else if (key == "$fields" && string.IsNullOrEmpty(queryStringCollection[key]))
                    {
                        queryStringCollection.Remove(key);
                    }
                }

                // ReSharper disable once AssignNullToNotNullAttribute
                return pathAndQuery[0].TrimStart('/') + "?" + queryStringCollection;
            }

            return urlPath;
        }

        /// <summary>
        /// Requests a resource at a given URL.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="urlPath">The path to access the resource.</param>
        /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
        public async Task RequestResourceAsync(string httpMethod, string urlPath)
        {
            await RequestResourceInternalAsync(httpMethod, CleanNullableNullQueryStringParameters(urlPath));
        }
        
        /// <summary>
        /// Requests a resource at a given URL.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="urlPath">The path to access the resource.</param>
        /// <returns>The requested resource.</returns>
        /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
        public async Task<TResult> RequestResourceAsync<TResult>(string httpMethod, string urlPath)
        {
            var value = await RequestResourceInternalAsync<TResult>(httpMethod, CleanNullableNullQueryStringParameters(urlPath));
           
            PropagatePropertyAccessPathHelper.SetAccessPathForValue(typeof(TResult).Name, true, value);
            
            return value;
        }

        /// <summary>
        /// Sends a payload to a resource at a given URL.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="urlPath">The path to access the resource.</param>
        /// <param name="payload">The payload to send to the resource.</param>
        /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
        public async Task RequestResourceAsync<TPayload>(string httpMethod, string urlPath, TPayload payload)
        {
            await RequestResourceInternalAsync(httpMethod, CleanNullableNullQueryStringParameters(urlPath), payload);
        }
        
        /// <summary>
        /// Sends a payload to a resource at a given URL.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="urlPath">The path to access the resource.</param>
        /// <param name="payload">The payload to send to the resource.</param>
        /// <returns>The requested resource.</returns>
        /// <exception cref="ResourceException">Something went wrong accessing the resource.</exception>
        public async Task<TResult> RequestResourceAsync<TPayload, TResult>(string httpMethod, string urlPath, TPayload payload)
        {
            var value = await RequestResourceInternalAsync<TPayload, TResult>(httpMethod, CleanNullableNullQueryStringParameters(urlPath), payload);
            
            PropagatePropertyAccessPathHelper.SetAccessPathForValue(typeof(TResult).Name, true, value);
            
            return value;
        }
        
        protected abstract Task RequestResourceInternalAsync(string httpMethod, string urlPath);
        protected abstract Task<TResult> RequestResourceInternalAsync<TResult>(string httpMethod, string urlPath);
        protected abstract Task RequestResourceInternalAsync<TPayload>(string httpMethod, string urlPath, TPayload payload);
        protected abstract Task<TResult> RequestResourceInternalAsync<TPayload, TResult>(string httpMethod, string urlPath, TPayload payload);
    }
}