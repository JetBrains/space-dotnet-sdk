#nullable enable

using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using JetBrains.Space.Common;

// ReSharper disable once CheckNamespace
namespace JetBrains.Space.Client
{
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
        /// <returns>String path where the upload is available.</returns>
        /// <exception cref="ResourceException">Exception when uploading the stream fails.</exception>
        public async Task<string?> UploadAsync(
            string storagePrefix,
            string fileName,
            Stream uploadStream,
            string? mediaType = null,
            HttpClient? httpClient = null,
            CancellationToken cancellationToken = default)
        {
            var uploadHttpClient = httpClient ?? SharedHttpClient.Instance;
            
            var uploadPath = await CreateUploadAsync(storagePrefix, mediaType, cancellationToken);

            var request = new HttpRequestMessage(HttpMethod.Put, _connection.ServerUrl + uploadPath.TrimStart('/') + "/" + fileName.TrimStart('/'))
            {
                Content = new StreamContent(uploadStream)
            };
            
            var response = await uploadHttpClient.SendAsync(request, cancellationToken);
            if (response.IsSuccessStatusCode)
            {
                var downloadPath = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(downloadPath) && !downloadPath.StartsWith("/", StringComparison.OrdinalIgnoreCase))
                {
                    downloadPath = $"/d/{downloadPath}";
                }

                return downloadPath;
            }

            throw new ResourceException("Could not upload stream.", response.StatusCode, response.ReasonPhrase);
        }
    }
}