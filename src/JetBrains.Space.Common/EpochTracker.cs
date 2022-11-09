using System.Collections.Concurrent;
using JetBrains.Annotations;

namespace JetBrains.Space.Common;

/// <summary>
/// Keeps track of epoch header values per Space organization URL.
/// </summary>
[PublicAPI]
public class EpochTracker
{
    /// <summary>
    /// Returns a static <see cref="EpochTracker"/>.
    /// </summary>
    public static readonly EpochTracker Instance = new();
    
    private ConcurrentDictionary<Uri, long> _epochPerHost = new();
    private ConcurrentDictionary<Uri, long> _syncEpochPerHost = new();

    private EpochTracker() { }
    
    /// <summary>
    /// Get the current epoch for the Space organization URL provided in <paramref name="serverUrl"/>.
    /// </summary>
    /// <param name="serverUrl">The Space organization URL to get epoch value for.</param>
    /// <param name="epoch">The epoch value.</param>
    /// <returns><see langword="true"/> if the epoch is available; <see langword="false"/> otherwise.</returns>
    public bool TryGetEpochFor(Uri serverUrl, out long epoch) => _epochPerHost.TryGetValue(serverUrl, out epoch);

    /// <summary>
    /// Updates the current epoch for the Space organization URL provided in <paramref name="serverUrl"/>.
    /// </summary>
    /// <param name="serverUrl">The Space organization URL to set epoch value for.</param>
    /// <param name="epochValue">The current epoch value.</param>
    public void UpdateEpochFor(Uri serverUrl, long epochValue) => UpdateEpoch(serverUrl, epochValue, _epochPerHost);
    
    /// <summary>
    /// Get the current sync epoch for the Space organization URL provided in <paramref name="serverUrl"/>.
    /// </summary>
    /// <param name="serverUrl">The Space organization URL to get sync epoch value for.</param>
    /// <param name="syncEpoch">The sync epoch value.</param>
    /// <returns><see langword="true"/> if the sync epoch is available; <see langword="false"/> otherwise.</returns>
    public bool TryGetSyncEpochFor(Uri serverUrl, out long syncEpoch) => _syncEpochPerHost.TryGetValue(serverUrl, out syncEpoch);

    /// <summary>
    /// Updates the current sync epoch for the Space organization URL provided in <paramref name="serverUrl"/>.
    /// </summary>
    /// <param name="serverUrl">The Space organization URL to set sync epoch value for.</param>
    /// <param name="epochValue">The current sync epoch value.</param>
    public void UpdateSyncEpochFor(Uri serverUrl, long epochValue) => UpdateEpoch(serverUrl, epochValue, _syncEpochPerHost);

    private void UpdateEpoch(Uri serverUrl, long epochValue, ConcurrentDictionary<Uri, long> targetDictionary)
    {
        if (epochValue <= 0) return;

        targetDictionary.AddOrUpdate(
            serverUrl,
            _ => epochValue,
            (uri, previousValue) =>
            {
                if (epochValue > previousValue) return previousValue;
                return epochValue;
            });
    }
}