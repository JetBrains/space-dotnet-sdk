using JetBrains.Annotations;

namespace JetBrains.Space.Common.Utilities;

/// <summary>
/// Extensions for <see cref="HttpRequestMessage"/>.
/// </summary>
[PublicAPI]
public static class HttpRequestMessageExtensions
{
    private const string ClientHeaderName = "X-Client-Type";
    private const string ClientHeaderValue = "DotNetSdk";
    private const string SdkVersionHeaderName = "X-SDK-Version";

    /// <summary>
    /// Appends the X-Client-Type and X-SDK-Version to the <see cref="HttpRequestMessage"/>.
    /// </summary>
    /// <param name="request">The <see cref="HttpRequestMessage"/> to append headers to.</param>
    /// <param name="sdkVersion">The version of the SDK being used.</param>
    /// <returns>The <see cref="HttpRequestMessage"/> with headers appended.</returns>
    public static HttpRequestMessage WithClientAndSdkHeaders(this HttpRequestMessage request, string sdkVersion)
    {
        if (!request.Headers.Contains(ClientHeaderName))
            request.Headers.Add(ClientHeaderName, ClientHeaderValue);
        
        if (!request.Headers.Contains(SdkVersionHeaderName)) 
            request.Headers.Add(SdkVersionHeaderName, sdkVersion);
        
        return request;
    }

    /// <summary>
    /// Try to append the HTTP request headers specified in <paramref name="requestHeaders"/> to the <see cref="HttpRequestMessage"/>.
    /// </summary>
    /// <param name="request">The <see cref="HttpRequestMessage"/> to append headers to.</param>
    /// <param name="requestHeaders">The headers to append.</param>
    /// <returns>The <see cref="HttpRequestMessage"/> with headers appended.</returns>
    public static HttpRequestMessage WithHeaders(this HttpRequestMessage request, Dictionary<string, string>? requestHeaders)
    {
        if (requestHeaders != null)
        {
            foreach (var (key, value) in requestHeaders)
            {
                request.Headers.TryAddWithoutValidation(key, value);
            }
        }
        
        return request;
    }
}