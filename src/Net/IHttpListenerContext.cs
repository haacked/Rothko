using System;
using System.ComponentModel;
using System.Net.WebSockets;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Rothko
{
    /// <summary>
    /// Provides access to the request and response objects used by the <see cref="IHttpListener"/> interface.
    /// </summary>
    public interface IHttpListenerContext
    {
        /// <summary>
        /// Gets the <see cref="IHttpListenerRequest"/> that represents a client's request for
        /// a resource.
        /// </summary>
        /// <returns>
        /// An <see cref="IHttpListenerRequest"/> object that represents the client request.
        /// </returns>
        IHttpListenerRequest Request { get; }

        /// <summary>
        /// Gets the <see cref="IHttpListenerResponse"/> object that will be sent to the client
        /// in response to the client's request.
        /// </summary>
        /// <returns>
        /// An <see cref="IHttpListenerResponse"/> object used to send a response back to the client.
        /// </returns>
        IHttpListenerResponse Response { get; }

        /// <summary>
        /// Gets an object used to obtain identity, authentication information, and security
        /// roles for the client whose request is represented by this System.Net.HttpListenerContext
        /// object.
        /// </summary>
        /// <returns>
        /// An <see cref="IPrincipal"/> object that describes the client, or null if the
        /// <see cref="HttpListener"/> that supplied this <see cref="IHttpListenerContext"/>
        /// does not require authentication.
        /// </returns>
        IPrincipal User { get; }

        /// <summary>
        /// Accept a WebSocket connection as an asynchronous operation.
        /// </summary>
        /// <param name="subProtocol">
        /// The supported WebSocket sub-protocol.
        /// </param>
        /// <returns>
        /// Returns System.Threading.Tasks.Task`1.The task object representing the asynchronous
        /// operation. The System.Threading.Tasks.Task`1.Result property on the task object
        /// returns an System.Net.WebSockets.HttpListenerWebSocketContext object.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// <paramref name="subProtocol"/> is an empty string-or- <paramref name="subProtocol"/>
        /// contains illegal characters.
        /// </exception>
        /// <exception cref="WebSocketException">
        /// An error occurred when sending the response to complete the WebSocket handshake.
        /// </exception>
        Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol);

        /// <summary>
        /// Accept a WebSocket connection specifying the supported WebSocket sub-protocol
        /// and WebSocket keep-alive interval as an asynchronous operation.
        /// </summary>
        /// <param name="subProtocol">
        /// The supported WebSocket sub-protocol.
        /// </param>
        /// <param name="keepAliveInterval">
        /// The WebSocket protocol keep-alive interval in milliseconds.
        /// </param>
        /// <returns>
        /// Returns System.Threading.Tasks.Task`1.The task object representing the asynchronous
        /// operation. The System.Threading.Tasks.Task`1.Result property on the task object
        /// returns an System.Net.WebSockets.HttpListenerWebSocketContext object.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// <paramref name="subProtocol"/> is an empty string-or- <paramref name="subProtocol"/>
        /// contains illegal characters.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="keepAliveInterval"/> is too small.
        /// </exception>
        /// <exception cref="WebSocketException">
        /// An error occurred when sending the response to complete the WebSocket handshake.
        /// </exception>
        Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, TimeSpan keepAliveInterval);

        /// <summary>
        /// Accept a WebSocket connection specifying the supported WebSocket sub-protocol,
        /// receive buffer size, and WebSocket keep-alive interval as an asynchronous operation.
        /// </summary>
        /// <param name="subProtocol">
        /// The supported WebSocket sub-protocol.
        /// </param>
        /// <param name="receiveBufferSize">
        /// The receive buffer size in bytes.
        /// </param>
        /// <param name="keepAliveInterval">
        /// The WebSocket protocol keep-alive interval in milliseconds.
        /// </param>
        /// <returns>
        /// Returns System.Threading.Tasks.Task`1.The task object representing the asynchronous
        /// operation. The System.Threading.Tasks.Task`1.Result property on the task object
        /// returns an System.Net.WebSockets.HttpListenerWebSocketContext object.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// <paramref name="subProtocol"/> is an empty string-or- <paramref name="subProtocol"/>
        /// contains illegal characters.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="keepAliveInterval"/> is too small.-or- receiveBufferSize is less than 16 bytes-or-
        /// <paramref name="receiveBufferSize"/> is greater than 64K bytes.
        /// </exception>
        /// <exception cref="WebSocketException">
        /// An error occurred when sending the response to complete the WebSocket handshake.
        /// </exception>
        Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, TimeSpan keepAliveInterval);

        /// <summary>
        /// Accept a WebSocket connection specifying the supported WebSocket sub-protocol,
        /// receive buffer size, WebSocket keep-alive interval, and the internal buffer as
        /// an asynchronous operation.
        /// </summary>
        /// <param name="subProtocol">
        /// The supported WebSocket sub-protocol.
        /// </param>
        /// <param name="receiveBufferSize">
        /// The receive buffer size in bytes.
        /// </param>
        /// <param name="keepAliveInterval">
        /// The WebSocket protocol keep-alive interval in milliseconds.
        /// </param>
        /// <param name="internalBuffer">
        /// An internal buffer to use for this operation.
        /// </param>
        /// <returns>
        /// Returns System.Threading.Tasks.Task`1.The task object representing the asynchronous
        /// operation. The System.Threading.Tasks.Task`1.Result property on the task object
        /// returns an System.Net.WebSockets.HttpListenerWebSocketContext object.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// <paramref name="subProtocol"/> is an empty string-or- <paramref name="subProtocol"/>
        /// contains illegal characters.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="keepAliveInterval"/> is too small.-or- receiveBufferSize is less than 16 bytes-or-
        /// <paramref name="receiveBufferSize"/> is greater than 64K bytes.
        /// </exception>
        /// <exception cref="WebSocketException">
        /// An error occurred when sending the response to complete the WebSocket handshake.
        /// </exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, TimeSpan keepAliveInterval, ArraySegment<byte> internalBuffer);
    }
}
