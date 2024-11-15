// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public interface ApplicationPayload
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static AppPublicationCheckPayload AppPublicationCheckPayload()
        => new AppPublicationCheckPayload();
    
    public static ApplicationUninstalledPayload ApplicationUninstalledPayload(string serverUrl, string clientId, string? verificationToken = null)
        => new ApplicationUninstalledPayload(serverUrl: serverUrl, clientId: clientId, verificationToken: verificationToken);
    
    public static ChangeClientSecretPayload ChangeClientSecretPayload(string newClientSecret, string clientId, string? userId = null, string? verificationToken = null)
        => new ChangeClientSecretPayload(newClientSecret: newClientSecret, clientId: clientId, userId: userId, verificationToken: verificationToken);
    
    public static ChangeServerUrlPayload ChangeServerUrlPayload(string newServerUrl, string clientId, string? userId = null, string? verificationToken = null)
        => new ChangeServerUrlPayload(newServerUrl: newServerUrl, clientId: clientId, userId: userId, verificationToken: verificationToken);
    
    public static CreateExternalIssueRequestPayload CreateExternalIssueRequestPayload(string spaceUserId, string clientId, string? requestId = null, string? summary = null, string? description = null, string? issuePrefix = null, string? verificationToken = null)
        => new CreateExternalIssueRequestPayload(spaceUserId: spaceUserId, clientId: clientId, requestId: requestId, summary: summary, description: description, issuePrefix: issuePrefix, verificationToken: verificationToken);
    
    public static CustomActionPayload CustomActionPayload(string actionId, string clientId, string userId, string? actionValue = null, string? verificationToken = null)
        => new CustomActionPayload(actionId: actionId, clientId: clientId, userId: userId, actionValue: actionValue, verificationToken: verificationToken);
    
    public static InitPayload InitPayload(string clientSecret, string serverUrl, string clientId, string? state = null, string? userId = null, string? verificationToken = null)
        => new InitPayload(clientSecret: clientSecret, serverUrl: serverUrl, clientId: clientId, state: state, userId: userId, verificationToken: verificationToken);
    
    public static ListCommandsPayload ListCommandsPayload(string clientId, string? userId = null, string? verificationToken = null)
        => new ListCommandsPayload(clientId: clientId, userId: userId, verificationToken: verificationToken);
    
    public static MenuActionPayload MenuActionPayload(string menuItemUniqueCode, string clientId, string userId, MenuActionContext? context = null, List<ExtensionActionFormParameterValue>? parameterValues = null, string? verificationToken = null)
        => new MenuActionPayload(menuItemUniqueCode: menuItemUniqueCode, clientId: clientId, userId: userId, context: context, parameterValues: parameterValues, verificationToken: verificationToken);
    
    public static MessageActionPayload MessageActionPayload(string actionId, string actionValue, MessageContext message, string clientId, string userId, string? verificationToken = null)
        => new MessageActionPayload(actionId: actionId, actionValue: actionValue, message: message, clientId: clientId, userId: userId, verificationToken: verificationToken);
    
    public static MessagePayload MessagePayload(MessageContext message, string clientId, string userId, string? verificationToken = null)
        => new MessagePayload(message: message, clientId: clientId, userId: userId, verificationToken: verificationToken);
    
    public static NewExternalIssueEventPayload NewExternalIssueEventPayload(string clientId, string? verificationToken = null)
        => new NewExternalIssueEventPayload(clientId: clientId, verificationToken: verificationToken);
    
    public static NewUnfurlQueueItemsPayload NewUnfurlQueueItemsPayload(string clientId, string? verificationToken = null)
        => new NewUnfurlQueueItemsPayload(clientId: clientId, verificationToken: verificationToken);
    
    public static RefreshTokenPayload RefreshTokenPayload(string refreshToken, PermissionScope scope, string clientId, string userId, string? verificationToken = null)
        => new RefreshTokenPayload(refreshToken: refreshToken, scope: scope, clientId: clientId, userId: userId, verificationToken: verificationToken);
    
    public static SafeMergeCommandPayload SafeMergeCommandPayload(string clientId, SafeMergeCommand command, string? verificationToken = null)
        => new SafeMergeCommandPayload(clientId: clientId, command: command, verificationToken: verificationToken);
    
    public static UnfurlActionPayload UnfurlActionPayload(string actionId, string actionValue, string link, ApplicationUnfurlContext context, string clientId, string userId, string? verificationToken = null)
        => new UnfurlActionPayload(actionId: actionId, actionValue: actionValue, link: link, context: context, clientId: clientId, userId: userId, verificationToken: verificationToken);
    
    public static WebhookRequestPayload WebhookRequestPayload(string clientId, string webhookId, WebhookEvent payload, string? verificationToken = null)
        => new WebhookRequestPayload(clientId: clientId, webhookId: webhookId, payload: payload, verificationToken: verificationToken);
    
}

