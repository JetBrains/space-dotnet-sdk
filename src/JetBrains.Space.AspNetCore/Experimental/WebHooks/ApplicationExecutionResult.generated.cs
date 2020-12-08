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

namespace JetBrains.Space.Client
{
    public sealed class ApplicationExecutionResult
    {
        public string? Message { get; }
        
        public ApplicationExecutionResult() { }
        
        public ApplicationExecutionResult(string? message)
        {
            Message = message;
        }
    }
}
