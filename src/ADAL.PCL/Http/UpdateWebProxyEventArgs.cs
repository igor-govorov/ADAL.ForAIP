using System;
using System.Net.Http;

namespace Microsoft.IdentityModel.Clients.ActiveDirectory.Http
{
    public class UpdateWebProxyEventArgs : EventArgs
    {
        public HttpClientHandler HttpClient { get; }

        public Uri ProxyUrl { get; }

        public UpdateWebProxyEventArgs(HttpClientHandler httpClientHandler, Uri proxyUrl)
        {
            HttpClient = httpClientHandler;
            ProxyUrl = proxyUrl;
        }
    }
}
