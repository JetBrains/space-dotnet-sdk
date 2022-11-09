using JetBrains.Annotations;

namespace JetBrains.Space.Common.RetryPolicies;

/// <summary>
/// A base <see cref="IResourceRetryPolicy"/> that retries operations a maximum number of times, with a delay between executions.
/// Implementations must specify which exceptions have to be retried.
/// </summary>
[PublicAPI]
public abstract class ResourceRetryPolicyBase
    : IResourceRetryPolicy
{
    private readonly int _maxRetries;
    private readonly double _multiplier;
    private readonly TimeSpan _initialDelay;
    private readonly TimeSpan _maximumDelay;

    /// <summary>
    /// Creates a new <see cref="ResourceRetryPolicyBase"/> instance.
    /// </summary>
    /// <param name="maxRetries">The maximum number of retries that should be attempted. Maximum retry count must be greater than zero.</param>
    /// <param name="multiplier">Multiplier to increase delay between executions. Multiplier must be greater than zero.</param>
    /// <param name="initialDelay">Initial delay between executions. Initial delay must be greater than zero.</param>
    /// <param name="maximumDelay">Maximum delay between executions. Maximum delay must be greater than zero, and greater than or equal to <paramref name="initialDelay"/></param>.
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    protected ResourceRetryPolicyBase(
        int maxRetries = 5,
        double multiplier = 1.5,
        TimeSpan? initialDelay = null,
        TimeSpan? maximumDelay = null)
    {
        if (maxRetries <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(maxRetries), "Maximum retry count must be greater than zero.");
        }
        if (multiplier <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(multiplier), "Multiplier must be greater than zero.");
        }
        if (initialDelay != null && initialDelay <= TimeSpan.Zero)
        {
            throw new ArgumentOutOfRangeException(nameof(initialDelay), "Initial delay must be greater than zero.");
        }
        if (maximumDelay != null && (maximumDelay <= TimeSpan.Zero || maximumDelay < initialDelay))
        {
            throw new ArgumentOutOfRangeException(nameof(maximumDelay), $"Maximum delay must be greater than zero, and greater than or equal to {nameof(initialDelay)}.");
        }

        _maxRetries = maxRetries;
        _multiplier = multiplier;
        _initialDelay = initialDelay ?? TimeSpan.FromMilliseconds(500);
        _maximumDelay = maximumDelay ?? TimeSpan.FromSeconds(15);
    }
        
    /// <inheritdoc />
    public async Task<TResult> ExecuteAsync<TResult>(
        Func<Task<TResult>> handler,
        CancellationToken cancellationToken)
    {
        var previousExceptions = new List<Exception>();
        var currentDelay = _initialDelay;

        for (var currentRetry = 0; currentRetry < _maxRetries; currentRetry++)
        {
            try
            {
                cancellationToken.ThrowIfCancellationRequested();
                return await handler();
            }
            catch (ResourceException exception)
            {
                if (ShouldRetry(exception))
                {
                    previousExceptions.Add(exception);

                    await Task.Delay(currentDelay, cancellationToken);
                        
                    var multipliedDelay = currentDelay * _multiplier;
                    if (multipliedDelay < _maximumDelay)
                    {
                        currentDelay = multipliedDelay;
                    }
                }
                else
                {
                    throw;
                }
            }
        }

        throw new ResourceException(
            $"Failed to execute handler function. The retry limit of {_maxRetries} was reached. " +
            $"See the inner {nameof(AggregateException)} for exceptions caught in previous attempts.", 
            new AggregateException(previousExceptions));
    }

    /// <summary>
    /// Determine whether the <paramref name="exception"/> should be retried.
    /// </summary>
    /// <param name="exception">The <see cref="Exception"/> to analyze.</param>
    /// <returns>True when <paramref name="exception"/> should be retried; false otherwise.</returns>
    protected abstract bool ShouldRetry(Exception exception);
}