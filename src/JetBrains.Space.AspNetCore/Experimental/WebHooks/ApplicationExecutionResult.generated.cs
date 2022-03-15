#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

/// <summary>
/// Represents the result of executing an application action.
/// </summary>
public sealed class ApplicationExecutionResult
{
    /// <summary>
    /// Status code to return to Space.
    /// </summary>
    public int StatusCode { get; }
        
    /// <summary>
    /// Optional message to return to Space.
    /// </summary>
    public string? Message { get; }
        
    /// <summary>
    /// Creates a new <see cref="ApplicationExecutionResult"/>.
    /// </summary>
    public ApplicationExecutionResult()
        : this(null, statusCode: 200) { }
        
    /// <summary>
    /// Creates a new <see cref="ApplicationExecutionResult"/> with a message to return to Space.
    /// </summary>
    /// <param name="message">Optional message to return to Space.</param>
    /// <param name="statusCode">Status code to return to Space.</param>
    public ApplicationExecutionResult(string? message, int statusCode = 200)
    {
        Message = message;
        StatusCode = statusCode;
    }
}