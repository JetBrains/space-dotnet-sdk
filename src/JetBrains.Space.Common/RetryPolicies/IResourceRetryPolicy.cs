using JetBrains.Annotations;

namespace JetBrains.Space.Common.RetryPolicies;

/// <summary>
/// Enables an application to handle transient failures when it tries to connect to a Space organization,
/// by transparently retrying a failed operation. This can improve the stability of the application.
/// </summary>
[PublicAPI]
public interface IResourceRetryPolicy
{
    /// <summary>
    /// Executes a <paramref name="handler"/> function under the current retry policy.
    /// </summary>
    /// <param name="handler">The handler function to execute.</param>
    /// <param name="cancellationToken">Cancellation token that can be used.</param>
    /// <typeparam name="TResult">The return type of the <paramref name="handler"/> function.</typeparam>
    /// <returns>The value returned by the <paramref name="handler"/> function.</returns>
    /// <exception cref="ResourceException">Any non-transient <see cref="ResourceException"/> that may be thrown by the <paramref name="handler"/> function.</exception>
    /// <exception cref="Exception">Any <see cref="Exception"/> that may be thrown by the <paramref name="handler"/> function.</exception>
    Task<TResult> ExecuteAsync<TResult>(Func<Task<TResult>> handler, CancellationToken cancellationToken);
}