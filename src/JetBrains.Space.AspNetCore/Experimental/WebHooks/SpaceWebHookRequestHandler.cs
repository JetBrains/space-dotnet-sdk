using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using JetBrains.Space.AspNetCore.Experimental.WebHooks.EndpointAuthentication;
using JetBrains.Space.AspNetCore.Experimental.WebHooks.Options;
using JetBrains.Space.Client;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks;

/// <summary>
/// Handle Space WebHook HTTP requests and delegate the payload to the provided <see cref="ISpaceWebHookHandler"/>.
/// </summary>
/// <typeparam name="TWebHookHandler">The <see cref="ISpaceWebHookHandler"/> implementation that handles webhook payloads.</typeparam>
public class SpaceWebHookRequestHandler<TWebHookHandler>
    where TWebHookHandler : class, ISpaceWebHookHandler
{
    private readonly IOptionsSnapshot<SpaceWebHookOptions> _options;
    private readonly ILogger<SpaceWebHookRequestHandler<TWebHookHandler>> _logger;
    
    private readonly EpochTracker _epochTracker = EpochTracker.Instance;
    
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
    /// <param name="options">The <see cref="SpaceWebHookOptions"/> used by the current <see cref="SpaceWebHookRequestHandler{T}"/>.</param>
    /// <param name="logger">An <see cref="ILogger{T}"/> used by the current <see cref="SpaceWebHookRequestHandler{T}"/>.</param>
    public SpaceWebHookRequestHandler(
        IOptionsSnapshot<SpaceWebHookOptions> options,
        ILogger<SpaceWebHookRequestHandler<TWebHookHandler>> logger)
    {
        _options = options;
        _logger = logger;
    }
        
    /// <summary>
    /// Handle incoming webhook HTTP request.
    /// </summary>
    /// <param name="context">The current <see cref="HttpContext"/>.</param>
    /// <param name="optionsName">The (optional) name of the <see cref="SpaceWebHookOptions"/> options that apply.</param>
    public async Task HandleAsync(HttpContext context, string? optionsName)
    {
        // Read payload
        var readPayloadResult = await TryReadPayloadFromRequestAsync(context.Request);
        if (!readPayloadResult.Succeeded || readPayloadResult.PayloadJson == null || readPayloadResult.Payload == null)
        {
            await WriteTextResponse(context.Response, 400, "The request payload could not be read. Check the application log for more information.");
            return;
        }
        
        // Determine handler
        var handler = context.RequestServices.GetRequiredService<TWebHookHandler>();
        
        // Determine options to use (in case multiple are registered)
        var options = optionsName != null
            ? _options.Get(optionsName)
            : _options.Value;
        
        var configuredOptions = await handler.ConfigureRequestValidationOptionsAsync(
            // REVIEW: Is there a faster way of doing a deep copy of an options DTO?
            options: JsonSerializer.Deserialize<SpaceWebHookOptions>(JsonSerializer.Serialize(options))!,
            payload: readPayloadResult.Payload);

        // Validate payload
        if (!await IsValidPayloadAsync(configuredOptions, context, readPayloadResult.PayloadJson, readPayloadResult.Payload))
        {
            await WriteTextResponse(context.Response, 400, "The request could not be validated. Check the application log for more information.");
            return;
        }
        
        // Handle sync epoch header
        if (configuredOptions.ServerUrl != null)
        {
            if (context.Request.Headers.TryGetValue(EpochTrackerHeaders.SyncEpoch, out var syncEpochHeaders) &&
                syncEpochHeaders.Count > 0 &&
                long.TryParse(syncEpochHeaders[0], out var syncEpoch))
            {
                _epochTracker.UpdateEpochFor(configuredOptions.ServerUrl, syncEpoch);
            }
        }
        
        // Handle payload
        switch (readPayloadResult.Payload)
        {
            // List commands?
            case ListCommandsPayload listCommandsPayload:
                var commands = await handler.HandleListCommandsAsync(listCommandsPayload);
                PropagatePropertyAccessPathHelper.SetAccessPathForValue(string.Empty, false, commands);
                    
                // ReSharper disable once ConstantNullCoalescingCondition
                commands.CommandsItems ??= new List<CommandDetail>();
                await WriteJsonResponse(context.Response, 200, commands);
                return;
                
            // Message?
            case MessagePayload messagePayload:
                await handler.HandleMessageAsync(messagePayload);
                await WriteTextResponse(context.Response, 200);
                return;
                
            // Action?
            case MessageActionPayload actionPayload:
                var actionResult = await handler.HandleMessageActionAsync(actionPayload);
                await WriteJsonResponse(context.Response, 200, actionResult);
                return;
                
            // Menu action?
            case MenuActionPayload menuActionPayload:
                var menuActionResult = await handler.HandleMenuActionAsync(menuActionPayload);
                await WriteJsonResponse(context.Response, 200, menuActionResult);
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
            
            // Application initialized in Space organization?
            case InitPayload initPayload:
                var initActionResult = await handler.HandleInitAsync(initPayload);
                await WriteApplicationExecutionResultAsync(context.Response, initActionResult);
                return;

            // Application uninstalled from Space organization?
            case ApplicationUninstalledPayload uninstallPayload:
                var uninstallActionResult = await handler.HandleUninstalledAsync(uninstallPayload);
                await WriteApplicationExecutionResultAsync(context.Response, uninstallActionResult);
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
                
            // Refresh token updated?
            case RefreshTokenPayload refreshTokenPayload:
                var refreshTokenResult = await handler.HandleRefreshTokenAsync(refreshTokenPayload);
                await WriteApplicationExecutionResultAsync(context.Response, refreshTokenResult);
                return;
        }

        await WriteTextResponse(context.Response, 400, "Payload is not supported.");
    }
    
    private async Task<ReadPayloadResult> TryReadPayloadFromRequestAsync(HttpRequest httpRequest)
    {
        try 
        {
            using var inputStreamReader = new StreamReader(httpRequest.Body);
            var inputJsonString = await inputStreamReader.ReadToEndAsync();
            
            // Deserialize model
            if (JsonSerializer.Deserialize(inputJsonString, typeof(ApplicationPayload), JsonSerializerOptions) is ApplicationPayload payload)
            {
                PropagatePropertyAccessPathHelper.SetAccessPathForValue(string.Empty, false, payload);
                return ReadPayloadResult.Success(inputJsonString, payload);
            }

            _logger.LogError("JSON payload could not be deserialized. A null value was returned");
            return ReadPayloadResult.Failed();
        }
        catch (JsonException jsonException)
        {
            var path = jsonException.Path;
            var formatterException = new InputFormatterException(jsonException.Message, jsonException);
            
            _logger.LogError(jsonException, "JSON input formatter threw an exception at path {Path}: {Message}", path, formatterException.Message);
            
            return ReadPayloadResult.Failed();
        }
        catch (Exception exception) when (exception is FormatException or OverflowException)
        {
            _logger.LogError(exception, "JSON input formatter threw an exception: {Message}", exception.Message);
            
            return ReadPayloadResult.Failed();
        }
    }
    
    private async Task<bool> IsValidPayloadAsync(SpaceWebHookOptions options, HttpContext context, string payloadJson, ApplicationPayload payload)
    {
        // Validate request
        foreach (var endpointAuthenticationHandler in context.RequestServices.GetServices<ISpaceEndpointAuthenticationHandler>())
        {
            if (!await endpointAuthenticationHandler.AuthenticateRequestAsync(options, context, payloadJson, payload))
            {
                return false;
            }
        }

        return true;
    }

    private static Task WriteApplicationExecutionResultAsync(HttpResponse response, ApplicationExecutionResult executionResult) 
        => WriteTextResponse(response, executionResult.StatusCode, executionResult.Message);

    private static async Task WriteTextResponse(HttpResponse response, int statusCode, string? body = null)
    {
        response.StatusCode = statusCode;
        if (!string.IsNullOrEmpty(body))
        {
            response.ContentType = "text/plain";
            await response.WriteAsync(body);
        }
    }

    private static async Task WriteJsonResponse<TResponsePayload>(HttpResponse response, int statusCode, TResponsePayload payload)
    {
        response.StatusCode = statusCode;

#if NET6_0_OR_GREATER
        await response.WriteAsJsonAsync(payload, JsonSerializerOptions);
#else
            response.ContentType = "application/json; charset=utf-8";
            await JsonSerializer.SerializeAsync(response.Body, payload, JsonSerializerOptions);
#endif
    }
    
    private class ReadPayloadResult
    {
        public static ReadPayloadResult Success(string payloadJson, ApplicationPayload payload) =>
            new(true, payloadJson, payload);
        
        public static ReadPayloadResult Failed() =>
            new(false, null, null);
        
        private ReadPayloadResult(bool succeeded, string? payloadJson, ApplicationPayload? payload)
        {
            Succeeded = succeeded;
            PayloadJson = payloadJson;
            Payload = payload;
        }

        public bool Succeeded { get; protected set; }
        public string? PayloadJson { get; protected set; }
        public ApplicationPayload? Payload { get; protected set; }
    }
}