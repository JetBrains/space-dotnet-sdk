using System.Globalization;
using JetBrains.Annotations;

namespace JetBrains.Space.Common;

/// <summary>
/// Epoch tracking HTTP header names.
/// </summary>
[PublicAPI]
public static class EpochTrackerHeaders
{
    /// <summary>
    /// Header name to track epoch.
    /// </summary>
    public const string Epoch = "epoch";
    
    /// <summary>
    /// Header name to track sync epoch.
    /// </summary>
    public const string SyncEpoch = "X-Space-Sync-Epoch";

    /// <summary>
    /// Generate header dictionary for a given Space organization URL and <see cref="EpochTracker"/>.
    /// </summary>
    /// <param name="serverUrl">Space organization URL to generate header dictionary for.</param>
    /// <param name="epochTracker">The <see cref="EpochTracker"/> to get header values from.</param>
    /// <returns>A header dictionary with key/value pairs.</returns>
    public static Dictionary<string, string> GenerateFrom(Uri serverUrl, EpochTracker epochTracker)
    {
        if (epochTracker.TryGetSyncEpochFor(serverUrl, out var syncEpoch))
        {
            return new Dictionary<string, string>
            {
                { SyncEpoch, syncEpoch.ToString(CultureInfo.InvariantCulture) }
            };
        }

        return new Dictionary<string, string>();
    }
}