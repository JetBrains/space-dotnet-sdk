using System.Threading.Tasks;
using JetBrains.Annotations;
using JetBrains.Space.Client;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks
{
    /// <summary>
    /// Handle Space WebHook payloads.
    /// </summary>
    [PublicAPI]
    public interface ISpaceWebHookHandler
    {
        /// <summary>
        /// Handle "list commands" request. Use the response to provide details about available slash commands to Space.
        /// </summary>
        /// <param name="payload">The <see cref="ListCommandsPayload"/>.</param>
        /// <returns>List of available commands.</returns>
        Task<Commands> HandleListCommandsAsync(ListCommandsPayload payload);
        
        /// <summary>
        /// Handle "list menu extensions" request. Use the response to provide details about available menu extensions to Space.
        /// </summary>
        /// <param name="payload">The <see cref="ListMenuExtensionsPayload"/>.</param>
        /// <returns>List of available menu extensions.</returns>
        Task<MenuExtensions> HandleListMenuExtensionsAsync(ListMenuExtensionsPayload payload);
        
        /// <summary>
        /// Handle message request. This method is called when a user sends our application a chat message.
        /// </summary>
        /// <param name="payload">The <see cref="MessagePayload"/>.</param>
        Task HandleMessageAsync(MessagePayload payload);
        
        /// <summary>
        /// Handle message action request. This method is called when a user interacts with our application by clicking a button.
        /// </summary>
        /// <param name="payload">The <see cref="MessageActionPayload"/>.</param>
        /// <returns>The result of executing this action. The result message will be displayed in the Space user interface.</returns>
        Task<ApplicationExecutionResult> HandleMessageActionAsync(MessageActionPayload payload);
        
        /// <summary>
        /// Handle menu action request. This method is called when a user interacts with our application by clicking a menu item on a message.
        /// </summary>
        /// <param name="payload">The <see cref="MenuActionPayload"/>.</param>
        /// <returns>The result of executing this action. The result message will be displayed in the Space user interface.</returns>
        Task<ApplicationExecutionResult> HandleMenuActionAsync(MenuActionPayload payload);

        /// <summary>
        /// Handle webhook request. This method is called when a webhook payload is delivered from Space.
        /// </summary>
        /// <param name="payload">The <see cref="WebhookRequestPayload"/>.</param>
        /// <returns>The result of executing this action. The result message will be displayed in the Space user interface.</returns>
        Task<ApplicationExecutionResult> HandleWebhookRequestAsync(WebhookRequestPayload payload);

        /// <summary>
        /// Handle application initialization event.
        /// </summary>
        /// <param name="payload">The <see cref="InitPayload"/>.</param>
        /// <returns>The result of executing this action. The result message will be displayed in the Space user interface.</returns>
        Task<ApplicationExecutionResult> HandleInitAsync(InitPayload payload);
        
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
    }
}