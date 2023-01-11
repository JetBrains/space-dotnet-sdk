using System.Threading.Tasks;
using JetBrains.Annotations;
using JetBrains.Space.AspNetCore.Experimental.WebHooks.Options;
using JetBrains.Space.Client;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks;

/// <summary>
/// Handle Space WebHook payloads.
/// </summary>
[PublicAPI]
public interface ISpaceWebHookHandler
{
    /// <summary>
    /// Configure <see cref="SpaceWebHookOptions"/> for request validation,
    /// based on the <see cref="ApplicationPayload"/> read from the current request.
    /// 
    /// This method can be used to configure signature validation etc. before dispatching
    /// the <see cref="ApplicationPayload"/> to other methods on the <see cref="ISpaceWebHookHandler"/>.
    /// </summary>
    /// <param name="options">The <see cref="SpaceWebHookOptions"/> to configure.</param>
    /// <param name="payload">The <see cref="ApplicationPayload"/>.</param>
    /// <returns>The configured (or original) <see cref="SpaceWebHookOptions"/>.</returns>
    Task<SpaceWebHookOptions> ConfigureRequestValidationOptionsAsync(SpaceWebHookOptions options, ApplicationPayload payload);

    /// <summary>
    /// Handle "list commands" request. Use the response to provide details about available slash commands to Space.
    /// </summary>
    /// <param name="payload">The <see cref="ListCommandsPayload"/>.</param>
    /// <returns>List of available commands.</returns>
    Task<Commands> HandleListCommandsAsync(ListCommandsPayload payload);
        
    /// <summary>
    /// Handle message request. This method is called when a user sends our application a chat message.
    /// </summary>
    /// <param name="payload">The <see cref="MessagePayload"/>.</param>
    Task HandleMessageAsync(MessagePayload payload);

    /// <summary>
    /// Handle message action request. This method is called when a user interacts with our application by clicking a button.
    /// </summary>
    /// <param name="payload">The <see cref="MessageActionPayload"/>.</param>
    /// <returns>The result of executing this action. When <value>null</value>, no further action will be taken by the Space server. When <seealso cref="AppUserActionExecutionResult"/>, Space server may prompt the user to perform additional actions.</returns>
    Task<AppUserActionExecutionResult> HandleMessageActionAsync(MessageActionPayload payload);
        
    /// <summary>
    /// Handle menu action request. This method is called when a user interacts with our application by clicking a menu item on a message.
    /// </summary>
    /// <param name="payload">The <see cref="MenuActionPayload"/>.</param>
    /// <returns>The result of executing this action. When <value>null</value>, no further action will be taken by the Space server. When <seealso cref="AppUserActionExecutionResult"/>, Space server may prompt the user to perform additional actions.</returns>
    Task<AppUserActionExecutionResult> HandleMenuActionAsync(MenuActionPayload payload);

    /// <summary>
    /// Handle webhook request. This method is called when a webhook payload is delivered from Space.
    /// </summary>
    /// <param name="payload">The <see cref="WebhookRequestPayload"/>.</param>
    /// <returns>The result of executing this action. The result message will be displayed in the Space user interface.</returns>
    Task<ApplicationExecutionResult> HandleWebhookRequestAsync(WebhookRequestPayload payload);
    
    /// <summary>
    /// Handle event when new unfurl requests are available.
    /// </summary>
    /// <param name="payload">The <see cref="NewUnfurlQueueItemsPayload"/>.</param>
    /// <returns>The result of executing this action.</returns>
    Task<ApplicationExecutionResult> HandleNewUnfurlQueueItemsAsync(NewUnfurlQueueItemsPayload payload);
    
    /// <summary>
    /// Handle event when an action is executed from an unfurl.
    /// </summary>
    /// <param name="payload">The <see cref="UnfurlActionPayload"/>.</param>
    /// <returns>The result of executing this action.</returns>
    Task<ApplicationExecutionResult> HandleUnfurlActionPayloadAsync(UnfurlActionPayload payload);

    /// <summary>
    /// Handle application initialization event.
    /// </summary>
    /// <param name="payload">The <see cref="InitPayload"/>.</param>
    /// <returns>The result of executing this action. The result message will be displayed in the Space user interface.</returns>
    Task<ApplicationExecutionResult> HandleInitAsync(InitPayload payload);

    /// <summary>
    /// Handle application uninstall event.
    /// </summary>
    /// <param name="payload">The <see cref="InitPayload"/>.</param>
    /// <returns>The result of executing this action.</returns>
    Task<ApplicationExecutionResult> HandleUninstalledAsync(ApplicationUninstalledPayload payload);
        
    /// <summary>
    /// Handle event when application client secret is updated in Space organization.
    /// </summary>
    /// <param name="payload">The <see cref="ChangeClientSecretPayload"/>.</param>
    /// <returns>The result of executing this action.</returns>
    Task<ApplicationExecutionResult> HandleChangeClientSecretRequestAsync(ChangeClientSecretPayload payload);
        
    /// <summary>
    /// Handle event when application server URL is updated.
    /// </summary>
    /// <param name="payload">The <see cref="ChangeServerUrlPayload"/>.</param>
    /// <returns>The result of executing this action.</returns>
    Task<ApplicationExecutionResult> HandleChangeServerUrlAsync(ChangeServerUrlPayload payload);

    /// <summary>
    /// Handle event that checks the application.
    /// </summary>
    /// <param name="payload">The <see cref="AppPublicationCheckPayload"/>.</param>
    /// <returns>The result of executing this action.</returns>
    Task<ApplicationExecutionResult> HandleAppPublicationCheckAsync(AppPublicationCheckPayload payload);

    /// <summary>
    /// Handle event when refresh token is updated in Space organization.
    /// </summary>
    /// <param name="payload">The <see cref="RefreshTokenPayload"/>.</param>
    /// <returns>The result of executing this action.</returns>
    Task<ApplicationExecutionResult> HandleRefreshTokenAsync(RefreshTokenPayload payload);
}