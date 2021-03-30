using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JetBrains.Space.Client;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks.Mvc.Formatters
{
    /// <summary>
    /// Space payload input formatter.
    /// 
    /// Inspired on <see cref="SystemTextJsonInputFormatter"/>, validates Space signature headers.
    /// </summary>
    public class SpaceActionPayloadInputFormatter 
        : TextInputFormatter, IInputFormatterExceptionPolicy
    {
        private const string HeaderSpaceSignature = "X-Space-Signature";
        private const string HeaderSpaceTimestamp = "X-Space-Timestamp";

        private readonly IOptionsMonitor<SpaceWebHookOptions> _options;
        private readonly ILogger<SpaceActionPayloadInputFormatter> _logger;
        private readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions
        {
            MaxDepth = 32,
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        /// <summary>
        /// Initializes a new instance of <see cref="SpaceActionPayloadInputFormatter"/>.
        /// </summary>
        /// <param name="options">The <see cref="SpaceWebHookOptions"/>.</param>
        /// <param name="logger">The <see cref="ILogger"/>.</param>
        public SpaceActionPayloadInputFormatter(
            IOptionsMonitor<SpaceWebHookOptions> options,
            ILogger<SpaceActionPayloadInputFormatter> logger)
        {
            _options = options;
            _logger = logger;

            _jsonSerializerOptions.AddSpaceJsonTypeConverters();
            
            SupportedEncodings.Add(UTF8EncodingWithoutBOM);
            SupportedEncodings.Add(UTF16EncodingLittleEndian);
            
            SupportedMediaTypes.Add("application/json");
            SupportedMediaTypes.Add("text/json");
            SupportedMediaTypes.Add("text/plain");
            SupportedMediaTypes.Add("text/plain; charset=UTF-8");
        }

        /// <inheritdoc />
        InputFormatterExceptionPolicy IInputFormatterExceptionPolicy.ExceptionPolicy => InputFormatterExceptionPolicy.MalformedInputExceptions;

        /// <inheritdoc />
        public override bool CanRead(InputFormatterContext context) =>
            context.HttpContext.Request.Headers.ContainsKey(HeaderSpaceSignature) && 
            context.HttpContext.Request.Headers.ContainsKey(HeaderSpaceTimestamp);

        /// <inheritdoc />
        protected override bool CanReadType(Type type) =>
            typeof(ApplicationPayload).IsAssignableFrom(type);

        /// <inheritdoc />
        public sealed override async Task<InputFormatterResult> ReadRequestBodyAsync(
            InputFormatterContext context,
            Encoding encoding)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (encoding == null)
            {
                throw new ArgumentNullException(nameof(encoding));
            }

            var httpContext = context.HttpContext;
            var inputStream = httpContext.Request.Body;

            ApplicationPayload? model;
            try
            {
                using var inputStreamReader = new StreamReader(inputStream);
                
                var inputJsonString = await inputStreamReader.ReadToEndAsync();
                
                // Determine options name to use (in case multiple are registered)
                var options = httpContext.Request.RouteValues.TryGetValue(RouteKeyConstants.OptionsName, out object optionsName)
                        ? _options.Get(optionsName.ToString())
                        : _options.CurrentValue;

                // Verify signature
                if (options.ValidatePayloadSignature) 
                {
                    if (!string.IsNullOrEmpty(options.EndpointSigningKey))
                    {
                        var secret = Encoding.ASCII.GetBytes(options.EndpointSigningKey);
                        
                        var signatureBytes = Encoding.UTF8.GetBytes(context.HttpContext.Request.Headers[HeaderSpaceTimestamp] + ":" + inputJsonString);
                        using (var hmSha1 = new HMACSHA256(secret))
                        {
                            var signatureHash = hmSha1.ComputeHash(signatureBytes);
                            var signatureString = ToHexString(signatureHash);
                            if (!signatureString.Equals(context.HttpContext.Request.Headers[HeaderSpaceSignature]))
                            {
                                throw new InvalidOperationException("The webhook signature does not match the webhook payload. Make sure the endpoint signing key is configured correctly in your Space organization, and the current application.");
                            }
                        }
                    } 
                    else
                    {
                        _logger.LogWarning(nameof(SpaceWebHookOptions.ValidatePayloadSignature) + " is enabled, but no " + nameof(SpaceWebHookOptions.EndpointSigningKey) + " is configured. Skipping payload signature validation.");
                    }
                }
                
                // Deserialize model
                model = JsonSerializer.Deserialize(inputJsonString, context.ModelType, _jsonSerializerOptions) as ApplicationPayload;
                if (model != null)
                {
                    PropagatePropertyAccessPathHelper.SetAccessPathForValue(string.Empty, false, model);
                }

                // Verify payload
                if (options.ValidatePayloadVerificationToken)
                {
                    var payloadVerificationTokenValue = GetPayloadVerificationTokenValue(model);
                    if (!string.IsNullOrEmpty(payloadVerificationTokenValue))
                    {
                        if (payloadVerificationTokenValue != options.EndpointVerificationToken)
                        {
                            throw new InvalidOperationException(
                                "The webhook verification token does not your configured verification token. Make sure the endpoint verification token is configured correctly in your Space organization, and the current application.");
                        }
                    }
                    else
                    {
                        _logger.LogWarning(nameof(SpaceWebHookOptions.ValidatePayloadVerificationToken) + " is enabled, but no " + nameof(SpaceWebHookOptions.EndpointVerificationToken) + " is configured. Skipping verification token validation.");
                    }
                }
            }
            catch (JsonException jsonException)
            {
                var path = jsonException.Path;
                
                var formatterException = new InputFormatterException(jsonException.Message, jsonException);
                context.ModelState.TryAddModelError(path, formatterException, context.Metadata);
                
                Log.JsonInputException(_logger, jsonException);
                
                return await InputFormatterResult.FailureAsync();
            }
            catch (Exception exception) when (exception is FormatException || exception is OverflowException)
            {
                context.ModelState.TryAddModelError(string.Empty, exception, context.Metadata);
                
                Log.JsonInputException(_logger, exception);
                
                return await InputFormatterResult.FailureAsync();
            }

            if (model == null && !context.TreatEmptyInputAsDefaultValue)
            {
                return await InputFormatterResult.NoValueAsync();
            }

            Log.JsonInputSuccess(_logger, context.ModelType);
                
            return await InputFormatterResult.SuccessAsync(model);
        }

        private static string? GetPayloadVerificationTokenValue(ApplicationPayload? payload)
        {
            return payload?.GetType()
                .GetProperty(nameof(MessagePayload.VerificationToken))?.GetValue(payload) as string;
        }

        private static string ToHexString(IReadOnlyCollection<byte> bytes)
        {
            var builder = new StringBuilder(bytes.Count * 2);
            foreach (var b in bytes)
            {
                builder.AppendFormat("{0:x2}", b);
            }
            return builder.ToString();
        }

        private static class Log
        {
            private static readonly Action<ILogger, string, Exception?> JsonInputExceptionAction;
            private static readonly Action<ILogger, string, Exception?> JsonInputSuccessAction;

            static Log()
            {
                JsonInputExceptionAction = LoggerMessage.Define<string>(
                    LogLevel.Debug,
                    new EventId(1, "SystemTextJsonInputException"),
                    "JSON input formatter threw an exception: {Message}");

                JsonInputSuccessAction = LoggerMessage.Define<string>(
                    LogLevel.Debug,
                    new EventId(2, "SystemTextJsonInputSuccess"),
                    "JSON input formatter succeeded, deserializing to type '{TypeName}'");
            }

            public static void JsonInputException(ILogger logger, Exception exception) 
                => JsonInputExceptionAction(logger, exception.Message, exception);

            public static void JsonInputSuccess(ILogger logger, Type modelType)
                => JsonInputSuccessAction(logger, modelType.FullName!, null);
        }
    }
}