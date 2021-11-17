using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using JetBrains.Space.AspNetCore.Experimental.WebHooks.EndpointAuthentication;
using JetBrains.Space.AspNetCore.Experimental.WebHooks.Options;
using JetBrains.Space.Client;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks;

/// <summary>
/// Handle Space WebHook HTTP requests and delegate the payload to the provided <see cref="ISpaceWebHookHandler"/>.
/// </summary>
/// <typeparam name="TWebHookHandler">The <see cref="ISpaceWebHookHandler"/> implementation that handles webhook payloads.</typeparam>
public class SpaceWebHookRequestHandler<TWebHookHandler>
    where TWebHookHandler : class, ISpaceWebHookHandler
{
    private readonly ILogger<SpaceWebHookRequestHandler<TWebHookHandler>> _logger;
        
    // ReSharper disable once StaticMemberInGenericType
    private static readonly JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions
    {
        MaxDepth = 32,
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    }.AddSpaceJsonTypeConverters();

    /// <summary>
    /// Creates a new <see cref="SpaceWebHookRequestHandler{T}"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger{T}"/> used by the current <see cref="SpaceWebHookRequestHandler{T}"/>.</param>
    public SpaceWebHookRequestHandler(
        ILogger<SpaceWebHookRequestHandler<TWebHookHandler>> logger)
    {
        _logger = logger;
    }
        
    /// <summary>
    /// Handle incoming webhook HTTP request.
    /// </summary>
    /// <param name="context">The current <see cref="HttpContext"/>.</param>
    /// <param name="optionsName">The (optional) name of the <see cref="SpaceWebHookOptions"/> options that apply.</param>
    public async Task HandleAsync(HttpContext context, string? optionsName)
    {
        // Determine handler
        var handler = context.RequestServices.GetRequiredService<TWebHookHandler>();
            
        // Validate and read payload
        var (isValid, payload) = await ValidateAndReadModelFromRequestAsync(context, optionsName);
        if (!isValid || payload == null)
        {
            // When not valid, ValidateAndReadModelFromRequestAsync already has written a status code and response.
            return;
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
                await WriteJsonResponse(context.Response, 200, commands);
                return;
                
            // List menu extensions?
            case ListMenuExtensionsPayload listMenuExtensionsPayload:
                var menuExtensions = await handler.HandleListMenuExtensionsAsync(listMenuExtensionsPayload);
                PropagatePropertyAccessPathHelper.SetAccessPathForValue(string.Empty, false, menuExtensions);
                    
                // ReSharper disable once ConstantNullCoalescingCondition
                menuExtensions.Extensions ??= new List<MenuExtensionDetail>();
                await WriteJsonResponse(context.Response, 200, menuExtensions);
                return;
                
            // Message?
            case MessagePayload messagePayload:
                await handler.HandleMessageAsync(messagePayload);
                await WriteTextResponse(context.Response, 200);
                return;
                
            // Action?
            case MessageActionPayload actionPayload:
                var actionResult = await handler.HandleMessageActionAsync(actionPayload);
                await WriteApplicationExecutionResultAsync(context.Response, actionResult);
                return;
                
            // Menu action?
            case MenuActionPayload menuActionPayload:
                var menuActionResult = await handler.HandleMenuActionAsync(menuActionPayload);
                await WriteApplicationExecutionResultAsync(context.Response, menuActionResult);
                return;
                
            // Webhook?
            case WebhookRequestPayload webhookRequestPayload:
                var webhookActionResult = await handler.HandleWebhookRequestAsync(webhookRequestPayload);
                await WriteApplicationExecutionResultAsync(context.Response, webhookActionResult);
                return;
                
            // New unfurl requests are available?
            case NewUnfurlQueueItemsPayload unfurlRequestPayload:
                var unfurlQueueResult = await handler.HandleNewUnfurlQueueItemsAsync(unfurlRequestPayload);
                await WriteApplicationExecutionResultAsync(context.Response, unfurlQueueResult);
                return;
                
            // New unfurl requests are available?
            case UnfurlActionPayload unfurlActionPayload:
                var unfurlActionResult = await handler.HandleUnfurlActionPayloadAsync(unfurlActionPayload);
                await WriteApplicationExecutionResultAsync(context.Response, unfurlActionResult);
                return;
            
            // Application initialized in in Space organization?
            case InitPayload initPayload:
                var initActionResult = await handler.HandleInitAsync(initPayload);
                await WriteApplicationExecutionResultAsync(context.Response, initActionResult);
                return;
                    
            // Client secret updated in Space organization?
            case ChangeClientSecretPayload changeClientSecretPayload:
                var changeClientSecretActionResult = await handler.HandleChangeClientSecretRequestAsync(changeClientSecretPayload);
                await WriteApplicationExecutionResultAsync(context.Response, changeClientSecretActionResult);
                return;
                
            // Server URL updated in Space organization?
            case ChangeServerUrlPayload changeServerUrlPayload:
                var changeServerUrlActionResult = await handler.HandleChangeServerUrlAsync(changeServerUrlPayload);
                await WriteApplicationExecutionResultAsync(context.Response, changeServerUrlActionResult);
                return;
                
            // Publication check?
            case AppPublicationCheckPayload publicationCheckPayload:
                var publicationCheckPayloadActionResult = await handler.HandleAppPublicationCheckAsync(publicationCheckPayload);
                await WriteApplicationExecutionResultAsync(context.Response, publicationCheckPayloadActionResult);
                return;
        }

        await WriteTextResponse(context.Response, 400, "Payload is not supported.");
    }

    private async Task<(bool, ApplicationPayload?)> ValidateAndReadModelFromRequestAsync(HttpContext context, string? optionsName)
    {
        try 
        {
            using var inputStreamReader = new StreamReader(context.Request.Body);
            var inputJsonString = await inputStreamReader.ReadToEndAsync();
                
            // Deserialize model
            var payload = JsonSerializer.Deserialize(inputJsonString, typeof(ApplicationPayload), JsonSerializerOptions) as ApplicationPayload;
            if (payload != null)
            {
                PropagatePropertyAccessPathHelper.SetAccessPathForValue(string.Empty, false, payload);
            }
                
            // Validate request
            foreach (var endpointAuthenticationHandler in context.RequestServices.GetServices<ISpaceEndpointAuthenticationHandler>())
            {
                if (!await endpointAuthenticationHandler.AuthenticateRequestAsync(optionsName, context, inputJsonString, payload))
                {
                    await WriteTextResponse(context.Response, 401, "The request could not be validated. Check the application log for more information.");
                    return (false, null);
                }
            }
                
            // Good to go!
            return (true, payload);
        }
        catch (JsonException jsonException)
        {
            var path = jsonException.Path;
            var formatterException = new InputFormatterException(jsonException.Message, jsonException);
                
            _logger.LogError(jsonException, "JSON input formatter threw an exception at path {Path}: {Message}", path, formatterException.Message);
                
            await WriteTextResponse(context.Response, 400, "The request payload could not be read. Check the application log for more information.");
            return (false, null);
        }
        catch (Exception exception) when (exception is FormatException or OverflowException)
        {
            _logger.LogError(exception, "JSON input formatter threw an exception: {Message}", exception.Message);
                
            await WriteTextResponse(context.Response, 400, "The request payload could not be read. Check the application log for more information.");
            return (false, null);
        }
    }

    private Task WriteApplicationExecutionResultAsync(HttpResponse response, ApplicationExecutionResult executionResult) 
        => WriteTextResponse(response, executionResult.StatusCode, executionResult.Message);

    private async Task WriteTextResponse(HttpResponse response, int statusCode, string? body = null)
    {
        response.StatusCode = statusCode;
        if (!string.IsNullOrEmpty(body))
        {
            response.ContentType = "text/plain";
            await response.WriteAsync(body);
        }
    }

    private async Task WriteJsonResponse<TResponsePayload>(HttpResponse response, int statusCode, TResponsePayload payload)
    {
        response.StatusCode = statusCode;

#if NET6_0_OR_GREATER
        await response.WriteAsJsonAsync(payload, JsonSerializerOptions);
#else
            response.ContentType = "application/json; charset=utf-8";
            await JsonSerializer.SerializeAsync(response.Body, payload, JsonSerializerOptions);
#endif
    }
}