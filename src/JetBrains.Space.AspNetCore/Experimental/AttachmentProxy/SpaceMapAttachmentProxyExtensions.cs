using JetBrains.Annotations;
using JetBrains.Space.AspNetCore.Experimental.AttachmentProxy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Routing;

// ReSharper disable once CheckNamespace
namespace Microsoft.AspNetCore.Builder;

/// <summary>
/// Extension methods to map Space attachment proxy middleware on an <see cref="IEndpointRouteBuilder"/>.
/// </summary>
/// <remarks>
/// Attachment proxy is always registered with an authorization policy.
/// Anonymous access to attachments in a Space organization is discouraged.
/// </remarks>
[PublicAPI]
public static class SpaceMapAttachmentProxyExtensions
{
    /// <summary>
    /// Map the <see cref="SpaceAttachmentProxyMiddleware"/>  to an endpoint <paramref name="path"/>,
    /// and adds the default authorization policy to the endpoint.
    /// </summary>
    /// <param name="endpoints">The <see cref="IEndpointRouteBuilder"/> input.</param>
    /// <param name="path">The URL path to register the <see cref="SpaceAttachmentProxyMiddleware"/> on.</param>
    /// <returns>A reference to this instance after the operation has completed.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="path"/> is null or empty.</exception>
    public static IEndpointConventionBuilder MapSpaceAttachmentProxy(this IEndpointRouteBuilder endpoints, string path) 
        => MapSpaceAttachmentProxy(endpoints, path, new AuthorizeAttribute());

    /// <summary>
    /// Map the <see cref="SpaceAttachmentProxyMiddleware"/>  to an endpoint <paramref name="path"/>,
    /// and adds the specified <see cref="IAuthorizeData"/> to the endpoint.
    /// </summary>
    /// <param name="endpoints">The <see cref="IEndpointRouteBuilder"/> input.</param>
    /// <param name="path">The URL path to register the <see cref="SpaceAttachmentProxyMiddleware"/> on.</param>
    /// <param name="policyNames">A collection of policy names. If empty, the default authorization policy will be used.</param>
    /// <returns>A reference to this instance after the operation has completed.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="path"/> is null or empty; or when <paramref name="policyNames"/> is null or empty.</exception>
    public static IEndpointConventionBuilder MapSpaceAttachmentProxy(
        this IEndpointRouteBuilder endpoints,
        string path, 
        params string[] policyNames)
    {
        if (endpoints == null)
        {
            throw new ArgumentNullException(nameof(endpoints));
        }

        if (policyNames == null)
        {
            throw new ArgumentNullException(nameof(policyNames));
        }

        // ReSharper disable once CoVariantArrayConversion
        return MapSpaceAttachmentProxy(endpoints, path, 
            policyNames.Select(n => new AuthorizeAttribute(n)).ToArray());
    }

    /// <summary>
    /// Map the <see cref="SpaceAttachmentProxyMiddleware"/>  to an endpoint <paramref name="path"/>,
    /// and adds the specified <see cref="IAuthorizeData"/> to the endpoint.
    /// </summary>
    /// <param name="endpoints">The <see cref="IEndpointRouteBuilder"/> input.</param>
    /// <param name="path">The URL path to register the <see cref="SpaceAttachmentProxyMiddleware"/> on.</param>
    /// <param name="authorizeData">A collection of <paramref name="authorizeData"/>. If empty, the default authorization policy will be used.</param>
    /// <returns>A reference to this instance after the operation has completed.</returns>
    /// <exception cref="ArgumentNullException">When <paramref name="path"/> is null or empty; or when <paramref name="authorizeData"/> is null or empty.</exception>
    public static IEndpointConventionBuilder MapSpaceAttachmentProxy(
        this IEndpointRouteBuilder endpoints,
        string path, 
        params IAuthorizeData[] authorizeData)
    {
        if (string.IsNullOrEmpty(path))
        {
            throw new ArgumentNullException(nameof(path));
        }

        if (authorizeData == null)
        {
            throw new ArgumentNullException(nameof(authorizeData));
        }

        return endpoints.MapGet(path + "/{resourceId}", endpoints
                .CreateApplicationBuilder()
                .UseMiddleware<SpaceAttachmentProxyMiddleware>()
                .Build())
            .RequireAuthorization(authorizeData);
    }
}