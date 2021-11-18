using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;

namespace JetBrains.Space.Common.Types;

/// <summary>
/// Represents an inline error from the Space API (HA_InlineError).
/// </summary>
[PublicAPI]
[JsonConverter(typeof(ClassNameDtoTypeConverter))]
public abstract class ApiInlineError
    : IClassNameConvertible
{
    /// <inheritdoc />
    [JsonPropertyName("className")]
    public virtual string? ClassName => "HA_InlineError";
    
    /// <summary>
    /// Creates a new <see cref="ApiInlineErrorInaccessibleFields"/>.
    /// </summary>
    /// <param name="fields">Field name(s) containing an error.</param>
    /// <param name="message">Error message for the field(s).</param>
    public static ApiInlineErrorInaccessibleFields InaccessibleFields(HashSet<string> fields, string message)
        => new(fields: fields, message: message);
}

/// <summary>
/// Represents an inline error from the Space API when a field is inaccessible (HA_InlineError.InaccessibleFields).
/// </summary>
[PublicAPI]
public sealed class ApiInlineErrorInaccessibleFields
    : ApiInlineError, IClassNameConvertible
{
    /// <inheritdoc />
    [JsonPropertyName("className")]
    public override string? ClassName => "HA_InlineError.InaccessibleFields";
    
    /// <summary>
    /// Creates a new <see cref="ApiInlineErrorInaccessibleFields"/>.
    /// </summary>
    public ApiInlineErrorInaccessibleFields() { }

    /// <summary>
    /// Creates a new <see cref="ApiInlineErrorInaccessibleFields"/>.
    /// </summary>
    /// <param name="fields">Field name(s) containing an error.</param>
    /// <param name="message">Error message for the field(s).</param>
    public ApiInlineErrorInaccessibleFields(HashSet<string> fields, string message)
    {
        Fields = fields;
        Message = message;
    }
    
    /// <summary>
    /// Field name(s) containing an error.
    /// </summary>
    [Required]
    [JsonPropertyName("fields")]
    public HashSet<string> Fields { get; set; } = new();

    /// <summary>
    /// Error message for the field(s).
    /// </summary>
    [Required]
    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;
}