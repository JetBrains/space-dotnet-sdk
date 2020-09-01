using System.Threading.Tasks;
using JetBrains.Annotations;
using SpaceDotNet.Client;

namespace SpaceDotNet.AspNetCore.WebHooks
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
        /// Handle message request.
        /// </summary>
        /// <param name="payload">The <see cref="MessagePayload"/>.</param>
        Task HandleMessageAsync(MessagePayload payload);
        
        /// <summary>
        /// Handle message action request.
        /// </summary>
        /// <param name="payload">The <see cref="MessageActionPayload"/>.</param>
        Task HandleMessageActionAsync(MessageActionPayload payload);
    }
}