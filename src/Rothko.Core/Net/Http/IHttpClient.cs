using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime;
using System.Threading;
using System.Threading.Tasks;

namespace Rothko.Net.Http
{
    public interface IHttpClient : IDisposable
    {
        /// <summary>
        /// Send a GET request to the specified Uri and return the response body as a string in an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<string> GetStringAsync(string requestUri);

        /// <summary>
        /// Send a GET request to the specified Uri and return the response body as a string in an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<string> GetStringAsync(Uri requestUri);

        /// <summary>
        /// Send a GET request to the specified Uri and return the response body as a byte array in an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<byte[]> GetByteArrayAsync(string requestUri);

        /// <summary>
        /// Send a GET request to the specified Uri and return the response body as a byte array in an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<byte[]> GetByteArrayAsync(Uri requestUri);

        /// <summary>
        /// Send a GET request to the specified Uri and return the response body as a stream in an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<Stream> GetStreamAsync(string requestUri);

        /// <summary>
        /// Send a GET request to the specified Uri and return the response body as a stream in an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<Stream> GetStreamAsync(Uri requestUri);

        /// <summary>
        /// Send a GET request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<HttpResponseMessage> GetAsync(string requestUri);

        /// <summary>
        /// Send a GET request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        Task<HttpResponseMessage> GetAsync(Uri requestUri);

        /// <summary>
        /// Send a GET request to the specified Uri with an HTTP completion option as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><param name="completionOption">An HTTP completion option value that indicates when the operation should be considered completed.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption);

        /// <summary>
        /// Send a GET request to the specified Uri with an HTTP completion option as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><param name="completionOption">An HTTP  completion option value that indicates when the operation should be considered completed.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption);

        /// <summary>
        /// Send a GET request to the specified Uri with a cancellation token as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken);

        /// <summary>
        /// Send a GET request to the specified Uri with a cancellation token as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken);

        /// <summary>
        /// Send a GET request to the specified Uri with an HTTP completion option and a cancellation token as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><param name="completionOption">An HTTP  completion option value that indicates when the operation should be considered completed.</param><param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken);

        /// <summary>
        /// Send a GET request to the specified Uri with an HTTP completion option and a cancellation token as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><param name="completionOption">An HTTP  completion option value that indicates when the operation should be considered completed.</param><param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken);

        /// <summary>
        /// Send a POST request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><param name="content">The HTTP request content sent to the server.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content);

        /// <summary>
        /// Send a POST request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><param name="content">The HTTP request content sent to the server.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content);

        /// <summary>
        /// Send a POST request with a cancellation token as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><param name="content">The HTTP request content sent to the server.</param><param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken);

        /// <summary>
        /// Send a POST request with a cancellation token as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><param name="content">The HTTP request content sent to the server.</param><param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken);

        /// <summary>
        /// Send a PUT request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><param name="content">The HTTP request content sent to the server.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content);

        /// <summary>
        /// Send a PUT request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><param name="content">The HTTP request content sent to the server.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content);

        /// <summary>
        /// Send a PUT request with a cancellation token as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><param name="content">The HTTP request content sent to the server.</param><param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken);

        /// <summary>
        /// Send a PUT request with a cancellation token as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><param name="content">The HTTP request content sent to the server.</param><param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken);

        /// <summary>
        /// Send a DELETE request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception><exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient"/> instance.</exception>
        Task<HttpResponseMessage> DeleteAsync(string requestUri);

        /// <summary>
        /// Send a DELETE request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception><exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient"/> instance.</exception>
        Task<HttpResponseMessage> DeleteAsync(Uri requestUri);

        /// <summary>
        /// Send a DELETE request to the specified Uri with a cancellation token as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception><exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient"/> instance.</exception>
        Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken);

        /// <summary>
        /// Send a DELETE request to the specified Uri with a cancellation token as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="requestUri">The Uri the request is sent to.</param><param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param><exception cref="T:System.ArgumentNullException">The <paramref name="requestUri"/> was null.</exception><exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient"/> instance.</exception>
        Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken);

        /// <summary>
        /// Send an HTTP request as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="request">The HTTP request message to send.</param><exception cref="T:System.ArgumentNullException">The <paramref name="request"/> was null.</exception><exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient"/> instance.</exception>
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request);

        /// <summary>
        /// Send an HTTP request as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="request">The HTTP request message to send.</param><param name="cancellationToken">The cancellation token to cancel operation.</param><exception cref="T:System.ArgumentNullException">The <paramref name="request"/> was null.</exception><exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient"/> instance.</exception>
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);

        /// <summary>
        /// Send an HTTP request as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="request">The HTTP request message to send.</param><param name="completionOption">When the operation should complete (as soon as a response is available or after reading the whole response content).</param><exception cref="T:System.ArgumentNullException">The <paramref name="request"/> was null.</exception><exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient"/> instance.</exception>
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption);

        /// <summary>
        /// Send an HTTP request as an asynchronous operation.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Threading.Tasks.Task`1"/>.The task object representing the asynchronous operation.
        /// </returns>
        /// <param name="request">The HTTP request message to send.</param><param name="completionOption">When the operation should complete (as soon as a response is available or after reading the whole response content).</param><param name="cancellationToken">The cancellation token to cancel operation.</param><exception cref="T:System.ArgumentNullException">The <paramref name="request"/> was null.</exception><exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient"/> instance.</exception>
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken);

        /// <summary>
        /// Cancel all pending requests on this instance.
        /// </summary>
        void CancelPendingRequests();

        /// <summary>
        /// Gets the headers which should be sent with each request.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Net.Http.Headers.HttpRequestHeaders"/>.The headers which should be sent with each request.
        /// </returns>
        HttpRequestHeaders DefaultRequestHeaders { get; }

        /// <summary>
        /// Gets or sets the base address of Uniform Resource Identifier (URI) of the Internet resource used when sending requests.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Uri"/>.The base address of Uniform Resource Identifier (URI) of the Internet resource used when sending requests.
        /// </returns>
        Uri BaseAddress { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; set; }

        /// <summary>
        /// Gets or sets the number of milliseconds to wait before the request times out.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.TimeSpan"/>.The number of milliseconds to wait before the request times out.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The timeout specified is less than or equal to zero and is not <see cref="F:System.Threading.Timeout.Infinite"/>.</exception><exception cref="T:System.InvalidOperationException">An operation has already been started on the current instance. </exception><exception cref="T:System.ObjectDisposedException">The current instance has been disposed.</exception>
        TimeSpan Timeout { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; set; }

        /// <summary>
        /// Gets or sets the maximum number of bytes to buffer when reading the response content.
        /// </summary>
        /// 
        /// <returns>
        /// Returns <see cref="T:System.Int32"/>.The maximum number of bytes to buffer when reading the response content. The default value for this property is 2 gigabytes.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The size specified is less than or equal to zero.</exception><exception cref="T:System.InvalidOperationException">An operation has already been started on the current instance. </exception><exception cref="T:System.ObjectDisposedException">The current instance has been disposed. </exception>
        long MaxResponseContentBufferSize { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")] get; set; }
    }
}