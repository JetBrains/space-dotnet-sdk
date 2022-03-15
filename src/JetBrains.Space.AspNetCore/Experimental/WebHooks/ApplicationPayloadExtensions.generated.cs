#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public static class ApplicationPayloadExtensions
{
    /// <summary>
    /// Gets the Space clientId value from the current <see cref="ApplicationPayload" />.
    /// </summary>
    /// <param name="current">The current <see cref="ApplicationPayload" />.</param>
    /// <returns>The clientId value.</returns>
    /// <exception cref="ArgumentOutOfRangeException">When an unsupported <see cref="ApplicationPayload" /> is queried.</exception>
    public static string GetClientId(this ApplicationPayload current)
    {
        return current switch
        {
            ChangeClientSecretPayload payload => payload.ClientId,
            ChangeServerUrlPayload payload => payload.ClientId,
            InitPayload payload => payload.ClientId,
            ListCommandsPayload payload => payload.ClientId,
            MenuActionPayload payload => payload.ClientId,
            MessageActionPayload payload => payload.ClientId,
            MessagePayload payload => payload.ClientId,
            NewUnfurlQueueItemsPayload payload => payload.ClientId,
            RefreshTokenPayload payload => payload.ClientId,
            UnfurlActionPayload payload => payload.ClientId,
            WebhookRequestPayload payload => payload.ClientId,
            _ => throw new ArgumentOutOfRangeException(nameof(current))
        };
    }
}