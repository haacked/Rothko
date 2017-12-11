using System;
using System.IO;
using System.Net;
using System.Text;

namespace Rothko
{
    /// <summary>
    /// Represents a response to a request being handled by an <see cref="IHttpListener"/>.
    /// </summary>
    public interface IHttpListenerResponse : IDisposable
    {
        /// <summary>
        /// Gets or sets the <see cref="Encoding"/> for this response's <see cref="OutputStream"/>.
        /// </summary>
        /// <returns>
        /// An <see cref="Encoding"/> object suitable for use with the data in the <see cref="OutputStream"/>
        /// property, or null if no encoding is specified.
        /// </returns>
        Encoding ContentEncoding { get; set; }

        /// <summary>
        /// Gets or sets the number of bytes in the body data included in the response.
        /// </summary>
        /// <returns>
        /// The value of the response's Content-Length header.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The value specified for a set operation is less than zero.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// The response is already being sent.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// This object is closed.
        /// </exception>
        long ContentLength64 { get; set; }

        /// <summary>
        /// Gets or sets the MIME type of the content returned.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> instance that contains the text of the response's Content-Type
        /// header.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// The value specified for a set operation is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The value specified for a set operation is an empty string ("").
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// This object is closed.
        /// </exception>
        string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the collection of cookies returned with the response.
        /// </summary>
        /// <returns>
        /// A <see cref="CookieCollection"/> that contains cookies to accompany the response.
        /// The collection is empty if no cookies have been added to the response.
        /// </returns>
        CookieCollection Cookies { get; set; }

        /// <summary>
        /// Gets or sets the collection of header name/value pairs returned by the server.
        /// </summary>
        /// <returns>
        /// A <see cref="WebHeaderCollection"/> instance that contains all the explicitly set
        /// HTTP headers to be included in the response.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// The <see cref="WebHeaderCollection"/> instance specified for a set operation is
        /// not valid for a response.
        /// </exception>
        WebHeaderCollection Headers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the server requests a persistent connection.
        /// </summary>
        /// <returns>
        /// true if the server requests a persistent connection; otherwise, false. The default
        /// is true.
        /// </returns>
        /// <exception cref="ObjectDisposedException">
        /// This object is closed.
        /// </exception>
        bool KeepAlive { get; set; }

        /// <summary>
        /// Gets a System.IO.Stream object to which a response can be written.
        /// </summary>
        /// <returns>
        /// A System.IO.Stream object to which a response can be written.
        /// </returns>
        /// <exception cref="ObjectDisposedException">
        /// This object is closed.
        /// </exception>
        Stream OutputStream { get; }

        /// <summary>
        /// Gets or sets the HTTP version used for the response.
        /// </summary>
        /// <returns>
        /// A <see cref="Version"/> object indicating the version of HTTP used when responding to
        /// the client. Note that this property is now obsolete.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// The value specified for a set operation is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The value specified for a set operation does not have its <see cref="Version.Major"/>
        /// property set to 1 or does not have its <see cref="Version.Minor"/> property set to either
        /// 0 or 1.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// This object is closed.
        /// </exception>
        Version ProtocolVersion { get; set; }

        /// <summary>
        /// Gets or sets the value of the HTTP Location header in this response.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that contains the absolute URL to be sent to the client in the
        /// Location header.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// The value specified for a set operation is an empty string ("").
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// This object is closed.
        /// </exception>
        string RedirectLocation { get; set; }

        /// <summary>
        /// Gets or sets whether the response uses chunked transfer encoding.
        /// </summary>
        /// <returns>
        /// true if the response is set to use chunked transfer encoding; otherwise, false.
        /// The default is false.
        /// </returns>
        bool SendChunked { get; set; }

        /// <summary>
        /// Gets or sets the HTTP status code to be returned to the client.
        /// </summary>
        /// <returns>
        /// An <see cref="int"/> value that specifies the HTTP status code for the requested resource.
        /// The default is <see cref="HttpStatusCode.OK"/>, indicating that the server successfully
        /// processed the client's request and included the requested resource in the response
        /// body.
        /// </returns>
        /// <exception cref="ObjectDisposedException">
        /// This object is closed.
        /// </exception>
        ///<exception cref="ProtocolViolationException">
        /// The value specified for a set operation is not valid. Valid values are between
        /// 100 and 999 inclusive.
        ///</exception>
        int StatusCode { get; set; }

        /// <summary>
        /// Gets or sets a text description of the HTTP status code returned to the client.
        /// </summary>
        /// <returns>
        /// The text description of the HTTP status code returned to the client. The default
        /// is the RFC 2616 description for the System.Net.HttpListenerResponse.StatusCode
        /// property value, or an empty string ("") if an RFC 2616 description does not exist.
        /// </returns>
        /// Exceptions:
        /// <exception cref="ArgumentNullException">
        /// The value specified for a set operation is null.
        /// </exception>
        ///<exception cref="ArgumentException">
        /// The value specified for a set operation contains non-printable characters.
        ///</exception>
        string StatusDescription { get; set; }

        /// <summary>
        /// Closes the connection to the client without sending a response.
        /// </summary>
        void Abort();

        /// <summary>
        /// Adds the specified header and value to the HTTP headers for this response.
        /// </summary>
        /// <param name="name">
        /// The name of the HTTP header to set.
        /// </param>
        /// <param name="value">
        /// The value for the name header.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// name is null or an empty string ("").
        /// </exception>
        /// <exception cref="ArgumentException">
        /// You are not allowed to specify a value for the specified header.-or-name or value
        /// contains invalid characters.
        /// </exception>
        ///<exception cref="ArgumentOutOfRangeException">
        /// The length of value is greater than 65,535 characters.
        ///</exception>
        void AddHeader(string name, string value);

        /// <summary>
        /// Adds the specified System.Net.Cookie to the collection of cookies for this response.
        /// </summary>
        /// <param name="cookie">
        /// The System.Net.Cookie to add to the collection to be sent with this response
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// cookie is null.
        /// </exception>
        void AppendCookie(Cookie cookie);

        /// <summary>
        /// Appends a value to the specified HTTP header to be sent with this response.
        /// </summary>
        /// <param name="name">
        /// The name of the HTTP header to append value to.
        /// </param>
        /// <param name="value">
        /// The value to append to the name header.
        /// </param>
        /// <exception cref="ArgumentException">
        /// name is null or an empty string ("").-or-You are not allowed to specify a value
        /// for the specified header.-or-name or value contains invalid characters.
        /// </exception>
        /// <exception cref=ArgumentOutOfRangeException">
        /// The length of value is greater than 65,535 characters.
        /// </exception>
        void AppendHeader(string name, string value);

        /// <summary>
        /// Sends the response to the client and releases the resources held by this System.Net.HttpListenerResponse
        /// instance.
        /// </summary>
        void Close();

        /// <summary>
        /// Returns the specified byte array to the client and releases the resources held
        /// by this System.Net.HttpListenerResponse instance.
        /// </summary>
        /// <param name="responseEntity">
        /// A <see cref="byte"/> array that contains the response to send to the client.
        /// </param>
        /// <param name="willBlock">
        /// true to block execution while flushing the stream to the client; otherwise, false.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// responseEntity is null.
        /// </exception>
        /// <exception cref="ObjectDisposedException">
        /// This object is closed.
        /// </exception>
        void Close(byte[] responseEntity, bool willBlock);

        /// <summary>
        /// Copies properties from the specified System.Net.HttpListenerResponse to this
        /// response.
        /// </summary>
        /// <param name="templateResponse">
        /// The System.Net.HttpListenerResponse instance to copy.
        /// </param>
        void CopyFrom(HttpListenerResponse templateResponse);

        /// <summary>
        /// Configures the response to redirect the client to the specified URL.
        /// </summary>
        /// <param name="url">
        /// The URL that the client should use to locate the requested resource.
        /// </param>
        void Redirect(string url);

        /// <summary>
        /// Configures the response to redirect the client to the specified URL.
        /// </summary>
        /// <param name="url">
        /// The URL that the client should use to locate the requested resource.
        /// </param>
        void Redirect(Uri url);

        /// <summary>
        /// Adds or updates a System.Net.Cookie in the collection of cookies sent with this
        /// response.
        /// </summary>
        /// <param name="cookie">
        /// A <see cref="Cookie"/> for this response.
        /// </param>
        /// <exception cref=ArgumentNullException" >
        /// cookie is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The cookie already exists in the collection and could not be replaced.
        /// </exception>
        void SetCookie(Cookie cookie);
    }
}
