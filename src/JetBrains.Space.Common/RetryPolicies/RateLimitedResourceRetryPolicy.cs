using System;
using JetBrains.Annotations;

namespace JetBrains.Space.Common.RetryPolicies;

/// <summary>
/// A <see cref="IResourceRetryPolicy"/> that retries operations that failed because of a <see cref="RateLimitedException"/>.
/// </summary>
[PublicAPI]
public class RateLimitedResourceRetryPolicy 
    : ResourceRetryPolicyBase
{
    /// <summary>
    /// Shared <see cref="RateLimitedResourceRetryPolicy"/> instance that can be used by the Space SDK.
    /// </summary>
    public static readonly RateLimitedResourceRetryPolicy Instance = new();
        
    /// <inheritdoc />
    public RateLimitedResourceRetryPolicy(
        int maxRetries = 5,
        double multiplier = 1.5,
        TimeSpan? initialDelay = null,
        TimeSpan? maximumDelay = null) : base(maxRetries, multiplier, initialDelay, maximumDelay)
    {
    }

    /// <inheritdoc />
    protected override bool ShouldRetry(Exception exception) => exception is RateLimitedException;
}