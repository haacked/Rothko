using System;
using System.Net;
using System.Net.WebSockets;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Rothko
{
    public class HttpListenerContextWrapper : IHttpListenerContext, IDisposable
    {
        readonly HttpListenerContext inner;

        public HttpListenerContextWrapper(HttpListenerContext inner)
        {
            this.inner = inner;
            Request = new HttpListenerRequestWrapper(inner.Request);
            Response = new HttpListenerResponseWrapper(inner.Response);
        }

        public IHttpListenerRequest Request { get; }

        public IHttpListenerResponse Response { get; }

        public IPrincipal User => inner.User;

        public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol)
        {
            return inner.AcceptWebSocketAsync(subProtocol);
        }

        public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, TimeSpan keepAliveInterval)
        {
            return inner.AcceptWebSocketAsync(subProtocol, keepAliveInterval);
        }

        public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, TimeSpan keepAliveInterval)
        {
            return inner.AcceptWebSocketAsync(subProtocol, receiveBufferSize, keepAliveInterval);
        }

        public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, TimeSpan keepAliveInterval,
            ArraySegment<byte> internalBuffer)
        {
            return inner.AcceptWebSocketAsync(subProtocol, receiveBufferSize, keepAliveInterval, internalBuffer);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Response.Dispose();
            }
        }
    }
}
