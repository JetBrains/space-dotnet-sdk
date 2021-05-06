using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using JetBrains.Annotations;
using JetBrains.Space.Client;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;
using Microsoft.AspNetCore.Mvc;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks.Mvc.Controllers
{
    /// <summary>
    /// Controller that handles Space application webhook payloads.
    /// </summary>
    public class SpaceWebHookController : Controller
    {
        private static readonly JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions
        {
            MaxDepth = 32,
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        }.AddSpaceJsonTypeConverters();
        
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Creates a new <see cref="SpaceWebHookController"/> instance.
        /// </summary>
        /// <param name="serviceProvider">An <see cref="IServiceProvider"/> that gives access to registered services.</param>
        public SpaceWebHookController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        
        /// <summary>
        /// Receive and handle a Space application webhook payload.
        /// </summary>
        /// <param name="payload">The <see cref="ApplicationPayload"/> payload to handle.</param>
        /// <returns>The result provided by the registered <see cref="ISpaceWebHookHandler"/>.</returns>
        [HttpPost]
        public async Task<IActionResult> Receive([FromBody]ApplicationPayload payload)
        {
            // Find handler
            if (!RouteData.Values.TryGetValue(RouteKeyConstants.HandlerType, out object t) 
                || !(t is Type handlerType)
                || !(_serviceProvider.GetService(handlerType)is ISpaceWebHookHandler handler))
            {
                return BadRequest($"No registered {nameof(ISpaceWebHookHandler)} could be found.");
            }
            
            // Handle payload
            switch (payload)
            {
                // List commands?
                case ListCommandsPayload listCommandsPayload:
                    var commands = await handler.HandleListCommandsAsync(listCommandsPayload);
                    PropagatePropertyAccessPathHelper.SetAccessPathForValue(string.Empty, false, commands);
                    
                    // ReSharper disable once ConstantNullCoalescingCondition
                    commands.CommandsItems ??= new List<CommandDetail>();
                    
                    return new JsonResult(commands, JsonSerializerOptions);
                
                // List menu extensions?
                case ListMenuExtensionsPayload listMenuExtensionsPayload:
                    var menuExtensions = await handler.HandleListMenuExtensionsAsync(listMenuExtensionsPayload);
                    PropagatePropertyAccessPathHelper.SetAccessPathForValue(string.Empty, false, menuExtensions);
                    
                    // ReSharper disable once ConstantNullCoalescingCondition
                    menuExtensions.Extensions ??= new List<MenuExtensionDetail>();
                    
                    return new JsonResult(menuExtensions, JsonSerializerOptions);
                
                // Message?
                case MessagePayload messagePayload:
                    await handler.HandleMessageAsync(messagePayload);
                    return Ok();
                
                // Action?
                case MessageActionPayload actionPayload:
                    var actionResult = await handler.HandleMessageActionAsync(actionPayload);
                    return BuildActionResultFrom(actionResult);
                
                // Menu action?
                case MenuActionPayload menuActionPayload:
                    var menuActionResult = await handler.HandleMenuActionAsync(menuActionPayload);
                    return BuildActionResultFrom(menuActionResult);
                
                // Webhook?
                case WebhookRequestPayload webhookRequestPayload:
                    var webhookActionResult = await handler.HandleWebhookRequestAsync(webhookRequestPayload);
                    return BuildActionResultFrom(webhookActionResult);
            }

            return BadRequest("Payload is not supported.");
        }

        /// <summary>
        /// Builds an <see cref="IActionResult"/> from a given <see cref="ApplicationExecutionResult"/>.
        /// </summary>
        /// <param name="executionResult">The <see cref="ApplicationExecutionResult"/> to create an <see cref="IActionResult"/> for.</param>
        /// <returns>An <see cref="IActionResult"/> that can be dispatched by ASP.NET Core.</returns>
        private IActionResult BuildActionResultFrom(ApplicationExecutionResult executionResult)
        {
            if (!string.IsNullOrEmpty(executionResult.Message))
            {
                var contentResult = Content(executionResult.Message, "text/plain");
                contentResult.StatusCode = executionResult.StatusCode;
                return contentResult;
            }

            return new StatusCodeResult(executionResult.StatusCode);
        }
    }
}