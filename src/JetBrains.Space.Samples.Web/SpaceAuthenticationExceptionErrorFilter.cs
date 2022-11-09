using JetBrains.Annotations;
using JetBrains.Space.Common;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Filters;

namespace JetBrains.Space.Samples.Web;

[UsedImplicitly]
public class SpaceAuthenticationExceptionErrorFilter : IAsyncExceptionFilter
{
    private readonly ILogger<SpaceAuthenticationExceptionErrorFilter> _logger;

    public SpaceAuthenticationExceptionErrorFilter(
        ILogger<SpaceAuthenticationExceptionErrorFilter> logger)
    {
        _logger = logger;
    }
        
    public async Task OnExceptionAsync(ExceptionContext context)
    {
        if (context.Exception is AuthenticationRequiredException)
        {
            // Space authentication required - handle login
            await HandleException(context);
        }
        else if (context.Exception is PermissionDeniedException)
        {
            // Space extra permissions required - handle login
            _logger.LogCritical(context.Exception, "Extra permissions are required in Space");
                
            await HandleException(context);
        }
    }

    private async Task HandleException(ExceptionContext context)
    {
        await context.HttpContext.SignOutAsync();
        await context.HttpContext.ChallengeAsync();

        context.ExceptionHandled = true;
    }
}