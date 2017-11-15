using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Rothko
{
    public class HttpListenerRequestWrapper : IHttpListenerRequest
    {
        readonly HttpListenerRequest inner;

        public HttpListenerRequestWrapper(HttpListenerRequest inner)
        {
            this.inner = inner;
        }

        public string[] AcceptTypes => inner.AcceptTypes;

        public int ClientCertificateError => inner.ClientCertificateError;

        public Encoding ContentEncoding => inner.ContentEncoding;

        public long ContentLength64 => inner.ContentLength64;

        public string ContentType => inner.ContentType;

        public CookieCollection Cookies => inner.Cookies;

        public bool HasEntityBody => inner.HasEntityBody;

        public NameValueCollection Headers => inner.Headers;

        public string HttpMethod => inner.HttpMethod;

        public Stream InputStream => inner.InputStream;

        public bool IsAuthenticated => inner.IsAuthenticated;

        public bool IsLocal => inner.IsLocal;

        public bool IsSecureConnection => inner.IsSecureConnection;

        public bool IsWebSocketRequest => inner.IsWebSocketRequest;

        public bool KeepAlive => inner.KeepAlive;

        public IPEndPoint LocalEndPoint => inner.LocalEndPoint;

        public Version ProtocolVersion => inner.ProtocolVersion;

        public NameValueCollection QueryString => inner.QueryString;

        public string RawUrl => inner.RawUrl;

        public IPEndPoint RemoteEndPoint => inner.RemoteEndPoint;

        public Guid RequestTraceIdentifier => inner.RequestTraceIdentifier;

        public string ServiceName => inner.ServiceName;

        public TransportContext TransportContext => inner.TransportContext;

        public Uri Url => inner.Url;

        public Uri UrlReferrer => inner.UrlReferrer;

        public string UserAgent => inner.UserAgent;

        public string UserHostAddress => inner.UserHostAddress;

        public string UserHostName => inner.UserHostName;

        public string[] UserLanguages => inner.UserLanguages;

        public IAsyncResult BeginGetClientCertificate(AsyncCallback requestCallback, object state)
        {
            return inner.BeginGetClientCertificate(requestCallback, state);
        }

        public X509Certificate2 EndGetClientCertificate(IAsyncResult asyncResult)
        {
            return inner.EndGetClientCertificate(asyncResult);
        }

        public X509Certificate2 GetClientCertificate()
        {
            return inner.GetClientCertificate();
        }

        public Task<X509Certificate2> GetClientCertificateAsync()
        {
            return inner.GetClientCertificateAsync();
        }
    }
}
