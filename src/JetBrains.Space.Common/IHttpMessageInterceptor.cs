using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace JetBrains.Space.Common;

/// <summary>
/// Infrastructure to intercept HTTP requests and responses.
/// </summary>
[PublicAPI]
public interface IHttpMessageInterceptor
{
    /// <summary>
    /// Intercept the <paramref name="requestMessage"/>.
    /// </summary>
    /// <param name="serverUrl">Space organization URL that the request is made against.</param>
    /// <param name="requestMessage">The <see cref="HttpRequestMessage"/> to intercept.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The <see cref="HttpRequestMessage"/> after interception.</returns>
    Task<HttpRequestMessage> BeforeRequestAsync(Uri serverUrl, HttpRequestMessage requestMessage, CancellationToken cancellationToken);

    /// <summary>
    /// Intercept the <paramref name="responseMessage"/>.
    /// </summary>
    /// <param name="serverUrl">Space organization URL that the original request is made against.</param>
    /// <param name="responseMessage">The <see cref="HttpResponseMessage"/> to intercept.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The <see cref="HttpResponseMessage"/> after interception.</returns>
    Task<HttpResponseMessage> AfterResponseAsync(Uri serverUrl, HttpResponseMessage responseMessage, CancellationToken cancellationToken);
}