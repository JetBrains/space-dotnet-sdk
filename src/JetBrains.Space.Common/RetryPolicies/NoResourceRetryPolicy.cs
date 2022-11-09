using JetBrains.Annotations;

namespace JetBrains.Space.Common.RetryPolicies;

/// <summary>
/// A <see cref="IResourceRetryPolicy"/> that does not retry failed operations.
/// </summary>
[PublicAPI]
public class NoResourceRetryPolicy
    : IResourceRetryPolicy
{
    /// <inheritdoc />
    public Task<TResult> ExecuteAsync<TResult>(Func<Task<TResult>> handler, CancellationToken cancellationToken) 
        => handler();
}