using JetBrains.Annotations;

namespace JetBrains.Space.Common;

/// <summary>
/// Represents a blob with its metadata.
/// </summary>
[PublicAPI]
public class SpaceBlob
{
    /// <summary>
    /// Gets or sets the blob etag.
    /// </summary>
    public string? Etag { get; set; }

    /// <summary>
    /// Gets or sets the blob last modified.
    /// </summary>
    public string? LastModified { get; set; }
        
    /// <summary>
    /// Gets or sets the blob content type.
    /// </summary>
    public string? ContentType { get; set; }

        
    /// <summary>
    /// Gets or sets the blob content length.
    /// </summary>
    public long? ContentLength { get; set; }

    /// <summary>
    /// Gets or sets the blob content disposition.
    /// </summary>
    public string? ContentDisposition { get; set; }

    /// <summary>
    /// Gets or sets the blob content encoding.
    /// </summary>
    public string? ContentEncoding { get; set; }

    /// <summary>
    /// Gets or sets the blob content language.
    /// </summary>
    public string? ContentLanguage { get; set; }

    /// <summary>
    /// Gets or sets the blob <see cref="Stream"/>.
    /// </summary>
    public Stream? Stream { get; set; }
}