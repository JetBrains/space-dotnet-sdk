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
        /// Handle "list commands" request.
        /// </summary>
        /// <param name="payload">The <see cref="ListCommandsPayload"/>.</param>
        /// <returns>List of available commands.</returns>
        Task<Commands> HandleListCommandsAsync(ListCommandsPayload payload);
        
        /// <summary>
        /// Handle "list menu extensions" request.
        /// </summary>
        /// <param name="payload">The <see cref="ListMenuExtensionsPayload"/>.</param>
        /// <returns>List of available menu extensions.</returns>
        Task<MenuExtensions> HandleListMenuExtensionsAsync(ListMenuExtensionsPayload payload);
        
        /// <summary>
        /// Handle message request.
        /// </summary>
        /// <param name="payload">The <see cref="MessagePayload"/>.</param>
        Task HandleMessageAsync(MessagePayload payload);
        
        /// <summary>
        /// Handle message action request.
        /// </summary>
        /// <param name="payload">The <see cref="MessageActionPayload"/>.</param>
        /// <returns>The result of executing this action. The result message will be displayed in the Space user interface.</returns>
        Task<ApplicationExecutionResult> HandleMessageActionAsync(MessageActionPayload payload);
        
        /// <summary>
        /// Handle menu action request.
        /// </summary>
        /// <param name="payload">The <see cref="MenuActionPayload"/>.</param>
        /// <returns>The result of executing this action. The result message will be displayed in the Space user interface.</returns>
        Task<ApplicationExecutionResult> HandleMenuActionAsync(MenuActionPayload payload);

        /// <summary>
        /// Handle webhook request.
        /// </summary>
        /// <param name="payload">The <see cref="WebhookRequestPayload"/>.</param>
        /// <returns>The result of executing this action. The result message will be displayed in the Space user interface.</returns>
        Task<ApplicationExecutionResult> HandleWebhookRequestAsync(WebhookRequestPayload payload);
    }
}