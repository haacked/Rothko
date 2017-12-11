using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Rothko
{
    /// <summary>
    /// Describes an incoming HTTP request to an System.Net.HttpListener object.
    /// </summary> 
    public interface IHttpListenerRequest
    {
        /// <summary>
        /// Gets the MIME types accepted by the client.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> array that contains the type names specified in the request's
        /// Accept header or null if the client request did not include an Accept header.
        /// </returns>
        IEnumerable<string> AcceptTypes { get; }

        /// <summary>
        /// Gets an error code that identifies a problem with the <see cref="X509Certificate"/>
        /// provided by the client.
        /// </summary>
        /// <returns>
        /// An System.Int32 value that contains a Windows error code.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// The client certificate has not been initialized yet by a call to the <see cref="BeginGetClientCertificate(AsyncCallback, object)"/>
        /// or <see cref="GetClientCertificate"/> methods -or - The operation
        /// is still in progress.
        /// </exception>
        int ClientCertificateError { get; }

        /// <summary>
        /// Gets the content encoding that can be used with data sent with the request
        /// </summary>
        /// <returns>
        /// An <see cref="Encoding"/> object suitable for use with the data in the
        /// <see cref="InputStream"/> property.
        /// </returns>
        Encoding ContentEncoding { get; }

        /// <summary>
        /// Gets the length of the body data included in the request.
        /// </summary>
        /// <returns>
        /// The value from the request's Content-Length header. This value is -1 if the content
        /// length is not known.
        /// </returns>
        long ContentLength64 { get; }

        /// <summary>
        /// Gets the MIME type of the body data included in the request.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that contains the text of the request's Content-Type header.
        /// </returns>
        string ContentType { get; }

        /// <summary>
        /// Gets the cookies sent with the request.
        /// </summary>
        /// <returns>
        /// A <see cref="CookieCollection"/> that contains cookies that accompany the request.
        /// This property returns an empty collection if the request does not contain cookies.
        /// </returns>
        CookieCollection Cookies { get; }

        /// <summary>
        /// Gets a <see cref="bool"/> value that indicates whether the request has associated
        /// body data.
        /// </summary>
        /// <returns>
        /// true if the request has associated body data; otherwise, false.
        /// </returns>
        bool HasEntityBody { get; }

        /// <summary>
        /// Gets the collection of header name/value pairs sent in the request.
        /// </summary>
        /// <returns>
        /// A <see cref="WebHeaderCollection"/> that contains the HTTP headers included in the
        /// request.
        /// </returns>
        NameValueCollection Headers { get; }

        /// <summary>
        /// Gets the HTTP method specified by the client.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that contains the method used in the request.
        /// </returns>
        string HttpMethod { get; }

        /// <summary>
        /// Gets a stream that contains the body data sent by the client.
        /// </summary>
        /// <returns>
        /// A readable <see cref="Stream"/> object that contains the bytes sent by the client
        /// in the body of the request. This property returns <see cref="Stream.Null"/> if no
        /// data is sent with the request.
        /// </returns>
        Stream InputStream { get; }

        /// <summary>
        /// Gets a <see cref="bool"/> value that indicates whether the client sending this request
        /// is authenticated.
        /// </summary>
        /// <returns>
        /// true if the client was authenticated; otherwise, false.
        /// </returns>
        bool IsAuthenticated { get; }

        /// <summary>
        /// Gets a <see cref="bool"/> value that indicates whether the request is sent from the
        /// local computer.
        /// </summary>
        /// <returns>
        /// true if the request originated on the same computer as the <see cref="IHttpListener"/>
        /// object that provided the request; otherwise, false.
        /// </returns>
        bool IsLocal { get; }

        /// <summary>
        /// Gets a <see cref="bool"/> value that indicates whether the TCP connection used to
        /// send the request is using the Secure Sockets Layer (SSL) protocol.
        /// </summary>
        /// <returns>
        /// true if the TCP connection is using SSL; otherwise, false.
        /// </returns>
        bool IsSecureConnection { get; }

        /// <summary>
        /// Gets a <see cref="bool"/> value that indicates whether the TCP connection was a WebSocket
        /// request.
        /// </summary>
        /// <returns>
        /// Returns true if the TCP connection is a WebSocket request; otherwise, false.
        /// </returns>
        bool IsWebSocketRequest { get; }

        /// <summary>
        /// Gets a <see cref="bool"/> value that indicates whether the client requests a persistent
        /// connection.
        /// </summary>
        /// <returns>
        /// true if the connection should be kept open; otherwise, false.
        /// </returns>
        bool KeepAlive { get; }

        /// <summary>
        /// Get the server IP address and port number to which the request is directed.
        /// </summary>
        /// <returns>
        /// An <see cref="IPEndPoint"/> that represents the IP address that the request is sent
        /// to.
        /// </returns>
        IPEndPoint LocalEndPoint { get; }

        /// <summary>
        /// Gets the HTTP version used by the requesting client.
        /// </summary>
        /// <returns>
        /// A <see cref="Version"/> that identifies the client's version of HTTP.
        /// </returns>
        Version ProtocolVersion { get; }

        /// <summary>
        /// Gets the query string included in the request.
        /// </summary>
        /// <returns>
        /// A <see cref="NameValueCollection"/> object that contains the query data included in
        /// the request <see cref="Url"/>.
        /// </returns>
        NameValueCollection QueryString { get; }

        /// <summary>
        /// Gets the URL information (without the host and port) requested by the client.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that contains the raw URL for this request.
        /// </returns>
        string RawUrl { get; }

        /// <summary>
        /// Gets the client IP address and port number from which the request originated.
        /// </summary>
        /// <returns>
        /// An <see cref="IPEndPoint"/> that represents the IP address and port number from
        /// which the request originated.
        /// </returns>
        IPEndPoint RemoteEndPoint { get; }

        /// <summary>
        /// Gets the request identifier of the incoming HTTP request.
        /// </summary>
        /// <returns>
        /// A <see cref="Guid"/> object that contains the identifier of the HTTP request.
        /// </returns>
        Guid RequestTraceIdentifier { get; }

        /// <summary>
        /// Gets the Service Provider Name (SPN) that the client sent on the request.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that contains the SPN the client sent on the request.
        /// </returns>
        string ServiceName { get; }

        /// <summary>
        /// Gets the <see cref="TransportContext"/> for the client request.
        /// </summary>
        /// <returns>
        /// A <see cref="TransportContext"/> object for the client request.
        /// </returns>
        TransportContext TransportContext { get; }

        /// <summary>
        /// Gets the <see cref="Uri"/> object requested by the client.
        /// </summary>
        /// <returns>
        /// A <see cref="Uri"/> object that identifies the resource requested by the client.
        /// </returns>
        Uri Url { get; }

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the resource that referred the
        /// client to the server.
        /// </summary>
        /// <returns>
        /// A <see cref="Uri"/> object that contains the text of the request's <see cref="HttpRequestHeader.Referer"/>
        /// header, or null if the header was not included in the request.
        /// </returns>
        Uri UrlReferrer { get; }

        /// <summary>
        /// Gets the user agent presented by the client.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> object that contains the text of the request's User-Agent header.
        /// </returns>
        string UserAgent { get; }

        /// <summary>
        /// Gets the server IP address and port number to which the request is directed.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that contains the host address information.
        /// </returns>
        string UserHostAddress { get; }

        /// <summary>
        /// Gets the DNS name and, if provided, the port number specified by the client.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> value that contains the text of the request's Host header.
        /// </returns>
        string UserHostName { get; }

        /// <summary>
        /// Gets the natural languages that are preferred for the response.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> array that contains the languages specified in the request's
        /// <see cref="HttpRequestHeader.AcceptLanguage"/> header or null if the client request
        /// did not include an <see cref="HttpRequestHeader.AcceptLanguage"/> header.
        /// </returns>
        IEnumerable<string> UserLanguages { get; }

        /// <summary>
        /// Begins an asynchronous request for the client's X.509 v.3 certificate.
        /// </summary>
        /// <param name="requestCallback">
        /// An <see cref="AsyncCallback"/> delegate that references the method to invoke when the
        /// operation is complete.
        /// </param>
        /// <param name="state">
        /// A user-defined object that contains information about the operation. This object
        /// is passed to the callback delegate when the operation completes.
        /// </param>
        /// <returns>
        /// An <see cref="IAsyncResult"/> that indicates the status of the operation.
        /// </returns>
        IAsyncResult BeginGetClientCertificate(AsyncCallback requestCallback, object state);

        /// <summary>
        /// Ends an asynchronous request for the client's X.509 v.3 certificate.
        /// </summary>
        /// <param name="asyncResult">
        /// The pending request for the certificate.
        /// </param>
        /// <returns>
        /// The System.IAsyncResult object that is returned when the operation started.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// asyncResult is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// asyncResult was not obtained by calling <see cref="BeginGetClientCertificate(AsyncCallback,object)"/>.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// This method was already called for the operation identified by asyncResult.
        /// </exception>
        X509Certificate2 EndGetClientCertificate(IAsyncResult asyncResult);

        /// <summary>
        /// Retrieves the client's X.509 v.3 certificate.
        /// </summary>
        /// <returns>
        /// A <see cref="X509Certificate2"/> object that contains the client's X.509 v.3 certificate.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// A call to this method to retrieve the client's X.509 v.3 certificate is in progress
        /// and therefore another call to this method cannot be made.
        /// </exception>
        X509Certificate2 GetClientCertificate();

        /// <summary>
        /// Retrieves the client's X.509 v.3 certificate as an asynchronous operation.
        /// </summary>
        /// <returns>
        /// The task object representing the asynchronous operation. The <see cref="Task{TResult}.Result"/> property
        /// on the task object returns a <see cref="X509Certificate2"/> object that containsthe client's X.509 v.3
        /// certificate.
        /// </returns>
        Task<X509Certificate2> GetClientCertificateAsync();
    }
}
