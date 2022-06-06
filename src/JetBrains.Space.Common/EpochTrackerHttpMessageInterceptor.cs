using System;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace JetBrains.Space.Common;

/// <summary>
/// Infrastructure to track epoch and sync epoch headers in HTTP requests and responses using an <see cref="EpochTracker"/> instance.
/// </summary>
[PublicAPI]
public class EpochTrackerHttpMessageInterceptor : IHttpMessageInterceptor
{
    private readonly EpochTracker _epochTracker;

    /// <summary>
    /// Creates a new <see cref="EpochTrackerHttpMessageInterceptor"/>.
    /// </summary>
    /// <param name="epochTracker">The <see cref="EpochTracker"/> to use.</param>
    public EpochTrackerHttpMessageInterceptor(EpochTracker epochTracker)
    {
        _epochTracker = epochTracker;
    }

    /// <inheritdoc />
    public Task<HttpRequestMessage> BeforeRequestAsync(Uri serverUrl, HttpRequestMessage requestMessage, CancellationToken cancellationToken)
    {
        if (_epochTracker.TryGetSyncEpochFor(serverUrl, out var epoch))
        {
            requestMessage.Headers.TryAddWithoutValidation(EpochTrackerHeaders.Epoch, epoch.ToString(CultureInfo.InvariantCulture));
        }

        return Task.FromResult(requestMessage);
    }

    /// <inheritdoc />
    public Task<HttpResponseMessage> AfterResponseAsync(Uri serverUrl, HttpResponseMessage responseMessage, CancellationToken cancellationToken)
    {
        // ReSharper disable PossibleMultipleEnumeration
        if (responseMessage.Headers.TryGetValues(EpochTrackerHeaders.Epoch, out var epochHeaders) &&
            epochHeaders.Any() &&
            long.TryParse(epochHeaders.First(), out var epoch))
        {
            _epochTracker.UpdateEpochFor(serverUrl, epoch);
        }

        return Task.FromResult(responseMessage);
    }
}