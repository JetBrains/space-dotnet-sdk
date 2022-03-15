using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Space.AspNetCore.Experimental.WebHooks.Options;
using JetBrains.Space.Client;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks;

/// <inheritdoc/>
public abstract class SpaceWebHookHandler
    : ISpaceWebHookHandler
{
    /// <inheritdoc />
    public virtual Task<SpaceWebHookOptions> ConfigureRequestValidationOptionsAsync(SpaceWebHookOptions options, ApplicationPayload payload)
        => Task.FromResult(options);

    /// <inheritdoc/>
    public virtual Task<Commands> HandleListCommandsAsync(ListCommandsPayload payload) 
        => Task.FromResult(new Commands(new List<CommandDetail>()));

    /// <inheritdoc/>
    public virtual Task HandleMessageAsync(MessagePayload payload)
        => Task.CompletedTask;

    /// <inheritdoc/>
    public virtual Task<AppUserActionExecutionResult> HandleMessageActionAsync(MessageActionPayload payload)
        => Task.FromResult<AppUserActionExecutionResult>(AppUserActionExecutionResult.Success());

    /// <inheritdoc/>
    public virtual Task<AppUserActionExecutionResult> HandleMenuActionAsync(MenuActionPayload payload)
        => Task.FromResult<AppUserActionExecutionResult>(AppUserActionExecutionResult.Success());
        
    /// <inheritdoc/>
    public virtual Task<ApplicationExecutionResult> HandleWebhookRequestAsync(WebhookRequestPayload payload)
        => Task.FromResult(new ApplicationExecutionResult());

    /// <inheritdoc/>
    public virtual Task<ApplicationExecutionResult> HandleNewUnfurlQueueItemsAsync(NewUnfurlQueueItemsPayload payload)
        => Task.FromResult(new ApplicationExecutionResult());

    /// <inheritdoc/>
    public virtual Task<ApplicationExecutionResult> HandleUnfurlActionPayloadAsync(UnfurlActionPayload payload)
        => Task.FromResult(new ApplicationExecutionResult());

    /// <inheritdoc/>
    public virtual Task<ApplicationExecutionResult> HandleInitAsync(InitPayload payload)
        => Task.FromResult(new ApplicationExecutionResult());
        
    /// <inheritdoc/>
    public virtual Task<ApplicationExecutionResult> HandleChangeClientSecretRequestAsync(ChangeClientSecretPayload payload)
        => Task.FromResult(new ApplicationExecutionResult());
        
    /// <inheritdoc/>
    public virtual Task<ApplicationExecutionResult> HandleChangeServerUrlAsync(ChangeServerUrlPayload payload)
        => Task.FromResult(new ApplicationExecutionResult());

    /// <inheritdoc/>
    public virtual Task<ApplicationExecutionResult> HandleAppPublicationCheckAsync(AppPublicationCheckPayload payload)
        => Task.FromResult(new ApplicationExecutionResult());
    
    /// <inheritdoc/>
    public virtual Task<ApplicationExecutionResult> HandleRefreshTokenAsync(RefreshTokenPayload payload)
        => Task.FromResult(new ApplicationExecutionResult());
}