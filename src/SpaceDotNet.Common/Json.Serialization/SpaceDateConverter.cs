using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Internal;

namespace SpaceDotNet.Common.Json.Serialization
{
    /// <summary>
    /// A <see cref="JsonConverterFactory"/> that can (de)serialize a Space Date.
    /// </summary>
    public class SpaceDateConverter : JsonConverterFactory
    {
        /// <summary>
        /// Format string used to parse <see cref="DateTime"/> from JSON.
        /// </summary>
        public const string FormatString = "yyyy-MM-dd";

        /// <inheritdoc />
        public override bool CanConvert(Type typeToConvert) =>
            typeToConvert == typeof(DateTime) || typeToConvert == typeof(DateTime?);

        /// <inheritdoc />
        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            if (typeToConvert == typeof(DateTime?))
            {
                return new NullableDateTimeConverter(FormatString);
            } 
            else if (typeToConvert == typeof(DateTime))
            {
                return new NonNullableDateTimeConverter(new NullableDateTimeConverter(FormatString));
            }

            throw new JsonException();
        }
    }
}