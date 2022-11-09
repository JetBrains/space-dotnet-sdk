using System.Collections.ObjectModel;
using JetBrains.Space.Common;
using JetBrains.Space.Common.RetryPolicies;
using Xunit;

namespace JetBrains.Space.Client.Tests.RetryPolicies;

public class RateLimitedResourceRetryPolicyTests
{
    [Fact]
    public async Task DoesNotRetryWhenNoExceptions()
    {
        // Arrange & Act
        var numberOfTries = 0;
            
        var target = new RateLimitedResourceRetryPolicy();
        var result = await target.ExecuteAsync(
            () =>
            {
                numberOfTries++;
                return Task.FromResult("OK");
            },
            CancellationToken.None);

        // Assert
        Assert.Equal("OK", result);
        Assert.Equal(1, numberOfTries);
    }

    [Fact]
    public async Task DoesNotRetryWhenNotRateLimitedException()
    {
        // Arrange, Assert, Act
        var numberOfTries = 0;

        var target = new RateLimitedResourceRetryPolicy();

        await Assert.ThrowsAsync<ResourceException>(async () =>
        {
            await target.ExecuteAsync<string>(
                () =>
                {
                    numberOfTries++;
                    throw new ResourceException("Not a rate limit exception.");
                },
                CancellationToken.None);
        });

        Assert.Equal(1, numberOfTries);
    }

    [Fact]
    public async Task RetriesWhenRateLimitedException()
    {
        // Arrange, Assert, Act
        var numberOfTries = 0;
        var expectedNumberOfTries = 5;
            
        var target = new RateLimitedResourceRetryPolicy(expectedNumberOfTries);

        var result = await Assert.ThrowsAsync<ResourceException>(async () =>
        {
            await target.ExecuteAsync<string>(
                () =>
                {
                    numberOfTries++;
                    throw new RateLimitedException("Rate limit exception.");
                },
                CancellationToken.None);
        });

        Assert.Equal(expectedNumberOfTries, numberOfTries);
        Assert.NotNull(result.InnerException);

        var innerExceptions = (result.InnerException as AggregateException)?.InnerExceptions ?? new ReadOnlyCollection<Exception>(new List<Exception>());
        Assert.Equal(expectedNumberOfTries, innerExceptions.Count);
        Assert.All(innerExceptions, it =>
        {
            if (it is not RateLimitedException) throw new Exception("Not a " + nameof(RateLimitedException));
        });
    }
        
    [Fact]
    public async Task RetriesWhenRateLimitedExceptionAndReturnsWhenActionSucceeds()
    {
        // Arrange & Act
        var numberOfTries = 0;
        var maximumNumberOfTries = 5;
            
        var target = new RateLimitedResourceRetryPolicy();
        var result = await target.ExecuteAsync(
            () =>
            {
                numberOfTries++;
                if (numberOfTries < maximumNumberOfTries - 1)
                {
                    throw new RateLimitedException("Rate limit exception.");
                }
                return Task.FromResult("OK");
            },
            CancellationToken.None);

        // Assert
        Assert.Equal("OK", result);
        Assert.True(numberOfTries < maximumNumberOfTries);
    }
}