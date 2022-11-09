#nullable enable

using JetBrains.Annotations;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Utilities;

// ReSharper disable once CheckNamespace
namespace JetBrains.Space.Client;

/// <inheritdoc />
[PublicAPI]
public partial class UploadClient
{
    /// <summary>
    /// Upload an attachment to Space. Wrapper method over <see cref="CreateUploadAsync"/>.
    /// </summary>
    /// <remarks>
    /// Make sure the <paramref name="uploadStream"/> has its position set to 0. The Space SDK uses the stream as-is, and will not rewind or dispose the stream.
    /// </remarks>
    /// <param name="storagePrefix">Storage prefix. See <see cref="CreateUploadAsync"/> for supported values.</param>
    /// <param name="fileName">File name, e.g. 'image.png'.</param>
    /// <param name="uploadStream"><see cref="Stream"/> to upload. The stream is used as-is, and will not be rewound or disposed.</param>
    /// <param name="mediaType">Media type. See <see cref="CreateUploadAsync"/> for supported values.</param>
    /// <param name="httpClient"><see cref="HttpClient"/> instance to use for uploading the stream. Defaults to <see cref="SharedHttpClient.Instance"/>.</param>
    /// <param name="cancellationToken">Cancellation token to abort the upload.</param>
    /// <returns>The upload identifier, e.g. `yjojA0f1Jiv`. This usually can be accessed from the server at `/d/yjojA0f1Jiv`.</returns>
    /// <exception cref="ResourceException">Exception when uploading the stream fails.</exception>
    public async Task<string?> UploadAsync(
        string storagePrefix,
        string fileName,
        Stream uploadStream,
        string? mediaType = null,
        HttpClient? httpClient = null,
        CancellationToken cancellationToken = default)
    {
        return await UploadAsync(
            storagePrefix,
            fileName,
            new StreamContent(uploadStream),
            mediaType,
            httpClient,
            cancellationToken
        );
    }

    /// <summary>
    /// Upload an attachment to Space. Wrapper method over <see cref="CreateUploadAsync"/>.
    /// </summary>
    /// <remarks>
    /// Make sure the <paramref name="uploadStream"/> has its position set to 0. The Space SDK uses the stream as-is, and will not rewind or dispose the stream.
    /// </remarks>
    /// <param name="storagePrefix">Storage prefix. See <see cref="CreateUploadAsync"/> for supported values.</param>
    /// <param name="fileName">File name, e.g. 'image.png'.</param>
    /// <param name="httpContent"><see cref="HttpContent"/> to upload. The content is used as-is, and will not be rewound or disposed.</param>
    /// <param name="mediaType">Media type. See <see cref="CreateUploadAsync"/> for supported values.</param>
    /// <param name="httpClient"><see cref="HttpClient"/> instance to use for uploading the stream. Defaults to <see cref="SharedHttpClient.Instance"/>.</param>
    /// <param name="cancellationToken">Cancellation token to abort the upload.</param>
    /// <returns>The upload identifier, e.g. `yjojA0f1Jiv`. This usually can be accessed from the server at `/d/yjojA0f1Jiv`.</returns>
    /// <exception cref="ResourceException">Exception when uploading the stream fails.</exception>
    public async Task<string?> UploadAsync(
        string storagePrefix,
        string fileName,
        HttpContent httpContent,
        string? mediaType = null,
        HttpClient? httpClient = null,
        CancellationToken cancellationToken = default)
    {
        var uploadHttpClient = httpClient ?? SharedHttpClient.Instance;
            
        var uploadPath = await CreateUploadAsync(storagePrefix, mediaType, null, cancellationToken);

        var request = new HttpRequestMessage(HttpMethod.Put, _connection.ServerUrl + uploadPath.TrimStart('/') + "/" + fileName.TrimStart('/'))
        {
            Content = httpContent
        }.WithClientAndSdkHeaders(SdkInfo.Version);
            
        var response = await uploadHttpClient.SendAsync(request, cancellationToken);
        if (response.IsSuccessStatusCode)
        {
#if NET6_0_OR_GREATER
            return await response.Content.ReadAsStringAsync(cancellationToken);
#else
                return await response.Content.ReadAsStringAsync() ?? string.Empty;
#endif
        }

        throw new ResourceException("Could not upload stream.", response.StatusCode, response.ReasonPhrase);
    }
}
