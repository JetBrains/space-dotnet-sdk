using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaceDotNet.Client;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.AspNetCore.WebHooks.Mvc.Controllers
{
    public class SpaceWebHookController : Controller
    {
        private static readonly JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions
        {
            MaxDepth = 32,
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        }.AddSpaceJsonTypeConverters();
        
        private readonly IServiceProvider _serviceProvider;

        public SpaceWebHookController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        
        [HttpPost]
        public async Task<IActionResult> Receive([FromBody]ApplicationPayload payload)
        {
            // Find handler
            if (!RouteData.Values.TryGetValue(RouteKeyConstants.HandlerType, out object t) 
                || !(t is Type handlerType)
                || !(_serviceProvider.GetService(handlerType)is ISpaceWebHookHandler handler))
            {
                return BadRequest($"No registered " + typeof(ISpaceWebHookHandler) + " could be found.");
            }
            
            // Handle payload
            switch (payload)
            {
                // List commands?
                case ListCommandsPayload listCommandsPayload:
                    var commands = await handler.HandleListCommandsAsync(listCommandsPayload);
                    PropagatePropertyAccessPathHelper.SetAccessPathForValue(string.Empty, false, commands);
                    
                    // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                    if (commands.CommandsItems == null)
                    {
                        commands.CommandsItems = new List<CommandDetail>();
                    }
                    
                    return new JsonResult(commands, JsonSerializerOptions);
                
                // List menu extensions?
                case ListMenuExtensionsPayload listMenuExtensionsPayload:
                    var menuExtensions = await handler.HandleListMenuExtensionsAsync(listMenuExtensionsPayload);
                    PropagatePropertyAccessPathHelper.SetAccessPathForValue(string.Empty, false, menuExtensions);
                    
                    // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                    if (menuExtensions.Extensions == null)
                    {
                        menuExtensions.Extensions = new List<MenuExtensionDetail>();
                    }
                    
                    return new JsonResult(menuExtensions, JsonSerializerOptions);
                
                // Message?
                case MessagePayload messagePayload:
                    await handler.HandleMessageAsync(messagePayload);
                    return Ok();
                
                // Action?
                case MessageActionPayload actionPayload:
                    await handler.HandleMessageActionAsync(actionPayload);
                    return Ok();
                
                // Menu action?
                case MenuActionPayload menuActionPayload:
                    await handler.HandleMenuActionAsync(menuActionPayload);
                    return Ok();
            }

            return BadRequest($"Payload is not supported.");
        }
    }
}