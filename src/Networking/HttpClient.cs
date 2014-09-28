using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Rothko
{
    /// <summary>
    /// Provides a base class for sending HTTP requests and receiving HTTP responses from a resource identified by a URI.
    /// </summary>
    public class HttpClient : IHttpClient
    {
        private readonly System.Net.Http.HttpClient innerHttpClient;

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
            Guard.NotNull(httpClient, "httpClient");

            innerHttpClient = httpClient;
        }

        public Task<string> GetStringAsync(string requestUri)
        {
            return innerHttpClient.GetStringAsync(requestUri);
        }

        public Task<string> GetStringAsync(Uri requestUri)
        {
            return innerHttpClient.GetStringAsync(requestUri);
        }

        public Task<byte[]> GetByteArrayAsync(string requestUri)
        {
            return innerHttpClient.GetByteArrayAsync(requestUri);
        }

        public Task<byte[]> GetByteArrayAsync(Uri requestUri)
        {
            return innerHttpClient.GetByteArrayAsync(requestUri);
        }

        public Task<Stream> GetStreamAsync(string requestUri)
        {
            return innerHttpClient.GetStreamAsync(requestUri);
        }

        public Task<Stream> GetStreamAsync(Uri requestUri)
        {
            return innerHttpClient.GetStreamAsync(requestUri);
        }

        public Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            return innerHttpClient.GetAsync(requestUri);
        }

        public Task<HttpResponseMessage> GetAsync(Uri requestUri)
        {
            return innerHttpClient.GetAsync(requestUri);
        }

        public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption)
        {
            return innerHttpClient.GetAsync(requestUri, completionOption);
        }

        public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
        {
            return innerHttpClient.GetAsync(requestUri, completionOption);
        }

        public Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken)
        {
            return innerHttpClient.GetAsync(requestUri, cancellationToken);
        }

        public Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            return innerHttpClient.GetAsync(requestUri, cancellationToken);
        }

        public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return innerHttpClient.GetAsync(requestUri, completionOption, cancellationToken);
        }

        public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return innerHttpClient.GetAsync(requestUri, completionOption, cancellationToken);
        }

        public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content)
        {
            return innerHttpClient.PostAsync(requestUri, content);
        }

        public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
        {
            return innerHttpClient.PostAsync(requestUri, content);
        }

        public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return innerHttpClient.PostAsync(requestUri, content, cancellationToken);
        }

        public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return innerHttpClient.PostAsync(requestUri, content, cancellationToken);
        }

        public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content)
        {
            return innerHttpClient.PutAsync(requestUri, content);
        }

        public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
        {
            return innerHttpClient.PutAsync(requestUri, content);
        }

        public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return innerHttpClient.PutAsync(requestUri, content, cancellationToken);
        }

        public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return innerHttpClient.PutAsync(requestUri, content, cancellationToken);
        }

        public Task<HttpResponseMessage> DeleteAsync(string requestUri)
        {
            return innerHttpClient.DeleteAsync(requestUri);
        }

        public Task<HttpResponseMessage> DeleteAsync(Uri requestUri)
        {
            return innerHttpClient.DeleteAsync(requestUri);
        }

        public Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken)
        {
            return innerHttpClient.DeleteAsync(requestUri, cancellationToken);
        }

        public Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            return innerHttpClient.DeleteAsync(requestUri, cancellationToken);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            return innerHttpClient.SendAsync(request);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return innerHttpClient.SendAsync(request, cancellationToken);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
        {
            return innerHttpClient.SendAsync(request, completionOption);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return innerHttpClient.SendAsync(request, completionOption, cancellationToken);
        }

        public void CancelPendingRequests()
        {
            innerHttpClient.CancelPendingRequests();
        }

        public HttpRequestHeaders DefaultRequestHeaders
        {
            get { return innerHttpClient.DefaultRequestHeaders; }
        }

        public Uri BaseAddress
        {
            get { return innerHttpClient.BaseAddress; }
            set { innerHttpClient.BaseAddress = value; }
        }

        public TimeSpan Timeout
        {
            get { return innerHttpClient.Timeout; }
            set { innerHttpClient.Timeout = value; }
        }

        public long MaxResponseContentBufferSize
        {
            get { return innerHttpClient.MaxResponseContentBufferSize; }
            set { innerHttpClient.MaxResponseContentBufferSize = value; }
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
                System.Net.Http.HttpClient httpClient = innerHttpClient;
                if (httpClient != null)
                {
                    httpClient.Dispose();
                }
            }
        }
    }
}
