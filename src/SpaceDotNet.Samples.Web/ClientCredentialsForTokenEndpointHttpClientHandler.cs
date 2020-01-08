using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceDotNet.Samples.Web
{
    public class ClientCredentialsForTokenEndpointHttpClientHandler : HttpClientHandler
    {
        private readonly string _clientId;
        private readonly string _clientSecret;

        public ClientCredentialsForTokenEndpointHttpClientHandler(string clientId, string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
        }
        
        /// <inheritdoc />
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.RequestUri.PathAndQuery.StartsWith("/oauth/token"))
            {
                request.Headers.Authorization = AuthenticationHeaderValue.Parse(
                    "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_clientId}:{_clientSecret}")));
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}