using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Logging;

namespace SpaceDotNet.AspNetCore.WebHooks.Formatters
{
    /// <summary>
    /// Space payload input formatter.
    /// 
    /// Inspired on <see cref="SystemTextJsonInputFormatter"/>, plus validates Space signature.
    /// </summary>
    public class SpaceActionPayloadInputFormatter 
        : TextInputFormatter, IInputFormatterExceptionPolicy
    {
        private const string HeaderSpaceSignature = "X-Space-Signature";
        private const string HeaderSpaceTimestamp = "X-Space-Timestamp";
        
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
        /// <param name="logger">The <see cref="ILogger"/>.</param>
        public SpaceActionPayloadInputFormatter(ILogger<SpaceActionPayloadInputFormatter> logger)
        {
            _logger = logger;
            
            SupportedEncodings.Add(UTF8EncodingWithoutBOM);
            SupportedEncodings.Add(UTF16EncodingLittleEndian);
            
            // TODO WEBHOOK
            SupportedMediaTypes.Add("application/json");
            SupportedMediaTypes.Add("text/json");
            SupportedMediaTypes.Add("text/plain");
            SupportedMediaTypes.Add("text/plain; charset=UTF-8");
        }

        /// <inheritdoc />
        InputFormatterExceptionPolicy IInputFormatterExceptionPolicy.ExceptionPolicy => InputFormatterExceptionPolicy.MalformedInputExceptions;

        public override bool CanRead(InputFormatterContext context)
        {
            return context.HttpContext.Request.Headers.ContainsKey(HeaderSpaceSignature) && 
                   context.HttpContext.Request.Headers.ContainsKey(HeaderSpaceTimestamp);
        }

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

            object model;
            try
            {
                using var inputStreamReader = new StreamReader(inputStream);
                
                var inputJsonString = await inputStreamReader.ReadToEndAsync();
                    
                var secret = Encoding.ASCII.GetBytes("b3570907db12e831e231c440691fb01022fae94cf72429519ca474cef5241c54"); // TODO WEBHOOK PARAMETER
                    
                var signatureBytes = Encoding.UTF8.GetBytes(context.HttpContext.Request.Headers[HeaderSpaceTimestamp] + ":" + inputJsonString);
                using (var hmSha1 = new HMACSHA256(secret))
                {
                    var signatureHash = hmSha1.ComputeHash(signatureBytes);
                    var signatureString = ToHexString(signatureHash);
                    if (!signatureString.Equals(context.HttpContext.Request.Headers[HeaderSpaceSignature]))
                    {
                        throw new Exception("BROKEN SIG"); // TODO WEBHOOK
                    }
                }
                    
                model = JsonSerializer.Deserialize(inputJsonString, context.ModelType, _jsonSerializerOptions);
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
            else
            {
                Log.JsonInputSuccess(_logger, context.ModelType);
                
                return await InputFormatterResult.SuccessAsync(model);
            }
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