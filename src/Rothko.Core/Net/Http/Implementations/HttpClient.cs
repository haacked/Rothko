using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Rothko.Net.Http.Implementations
{
    /// <summary>
    /// Provides a base class for sending HTTP requests and receiving HTTP responses from a resource identified by a URI.
    /// </summary>
    public class HttpClient : IHttpClient
    {
        readonly System.Net.Http.HttpClient _inner;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Rothko.HttpClient"/> class.
        /// </summary>
        public HttpClient()
            : this(new System.Net.Http.HttpClient())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Rothko.HttpClient"/> class with a specific handler.
        /// </summary>
        /// <param name="handler">The HTTP handler stack to use for sending requests. </param>
        public HttpClient(HttpMessageHandler handler)
            : this(new System.Net.Http.HttpClient(handler))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Rothko.HttpClient"/> class with a specific handler.
        /// </summary>
        /// <param name="handler">The <see cref="T:System.Net.Http.HttpMessageHandler"/> responsible for processing the HTTP response messages.</param>
        /// <param name="disposeHandler">true if the inner handler should be disposed of by Dispose(),false if you intend to reuse the inner handler.</param>
        public HttpClient(HttpMessageHandler handler, bool disposeHandler)
            : this(new System.Net.Http.HttpClient(handler, disposeHandler))
        {
        }

        protected HttpClient(System.Net.Http.HttpClient httpClient)
        {
            _inner = httpClient;
        }

        public Task<string> GetStringAsync(string requestUri)
        {
            return _inner.GetStringAsync(requestUri);
        }

        public Task<string> GetStringAsync(Uri requestUri)
        {
            return _inner.GetStringAsync(requestUri);
        }

        public Task<byte[]> GetByteArrayAsync(string requestUri)
        {
            return _inner.GetByteArrayAsync(requestUri);
        }

        public Task<byte[]> GetByteArrayAsync(Uri requestUri)
        {
            return _inner.GetByteArrayAsync(requestUri);
        }

        public Task<Stream> GetStreamAsync(string requestUri)
        {
            return _inner.GetStreamAsync(requestUri);
        }

        public Task<Stream> GetStreamAsync(Uri requestUri)
        {
            return _inner.GetStreamAsync(requestUri);
        }

        public Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            return _inner.GetAsync(requestUri);
        }

        public Task<HttpResponseMessage> GetAsync(Uri requestUri)
        {
            return _inner.GetAsync(requestUri);
        }

        public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption)
        {
            return _inner.GetAsync(requestUri, completionOption);
        }

        public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
        {
            return _inner.GetAsync(requestUri, completionOption);
        }

        public Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken)
        {
            return _inner.GetAsync(requestUri, cancellationToken);
        }

        public Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            return _inner.GetAsync(requestUri, cancellationToken);
        }

        public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return _inner.GetAsync(requestUri, completionOption, cancellationToken);
        }

        public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return _inner.GetAsync(requestUri, completionOption, cancellationToken);
        }

        public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content)
        {
            return _inner.PostAsync(requestUri, content);
        }

        public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
        {
            return _inner.PostAsync(requestUri, content);
        }

        public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return _inner.PostAsync(requestUri, content, cancellationToken);
        }

        public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return _inner.PostAsync(requestUri, content, cancellationToken);
        }

        public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content)
        {
            return _inner.PutAsync(requestUri, content);
        }

        public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
        {
            return _inner.PutAsync(requestUri, content);
        }

        public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return _inner.PutAsync(requestUri, content, cancellationToken);
        }

        public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return _inner.PutAsync(requestUri, content, cancellationToken);
        }

        public Task<HttpResponseMessage> DeleteAsync(string requestUri)
        {
            return _inner.DeleteAsync(requestUri);
        }

        public Task<HttpResponseMessage> DeleteAsync(Uri requestUri)
        {
            return _inner.DeleteAsync(requestUri);
        }

        public Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken)
        {
            return _inner.DeleteAsync(requestUri, cancellationToken);
        }

        public Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            return _inner.DeleteAsync(requestUri, cancellationToken);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            return _inner.SendAsync(request);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return _inner.SendAsync(request, cancellationToken);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
        {
            return _inner.SendAsync(request, completionOption);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return _inner.SendAsync(request, completionOption, cancellationToken);
        }

        public void CancelPendingRequests()
        {
            _inner.CancelPendingRequests();
        }

        public HttpRequestHeaders DefaultRequestHeaders => _inner.DefaultRequestHeaders;

        public Uri BaseAddress
        {
            get => _inner.BaseAddress;
            set => _inner.BaseAddress = value;
        }

        public TimeSpan Timeout
        {
            get => _inner.Timeout;
            set => _inner.Timeout = value;
        }

        public long MaxResponseContentBufferSize
        {
            get => _inner.MaxResponseContentBufferSize;
            set => _inner.MaxResponseContentBufferSize = value;
        }

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="T:Rothko.HttpClient"/> and optionally disposes of the managed resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                System.Net.Http.HttpClient httpClient = _inner;
                httpClient?.Dispose();
            }
        }
    }
}
