using System;
using System.IO;
using System.Net;
using System.Text;

namespace Rothko
{
    public class HttpListenerResponseWrapper : IHttpListenerResponse
    {
        private HttpListenerResponse inner;

        public HttpListenerResponseWrapper(HttpListenerResponse inner)
        {
            this.inner = inner;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Encoding ContentEncoding
        {
            get { return inner.ContentEncoding; }
            set { inner.ContentEncoding = value; }
        }

        public long ContentLength64
        {
            get { return inner.ContentLength64; }
            set { inner.ContentLength64 = value; }
        }

        public string ContentType
        {
            get { return inner.ContentType; }
            set { inner.ContentType = value; }
        }

        public CookieCollection Cookies
        {
            get { return inner.Cookies; }
            set { inner.Cookies = value; }
        }

        public WebHeaderCollection Headers
        {
            get { return inner.Headers; }
            set { inner.Headers = value; }
        }

        public bool KeepAlive
        {
            get { return inner.KeepAlive; }
            set { inner.KeepAlive = value; }
        }

        public Stream OutputStream => inner.OutputStream;

        public Version ProtocolVersion
        {
            get { return inner.ProtocolVersion; }
            set { inner.ProtocolVersion = value; }
        }

        public string RedirectLocation
        {
            get { return inner.RedirectLocation; }
            set { inner.RedirectLocation = value; }
        }

        public bool SendChunked
        {
            get { return inner.SendChunked; }
            set { inner.SendChunked = value; }
        }

        public int StatusCode
        {
            get { return inner.StatusCode; }
            set { inner.StatusCode = value; }
        }

        public string StatusDescription
        {
            get { return inner.StatusDescription; }
            set { inner.StatusDescription = value; }
        }

        public void Abort() => inner.Abort();

        public void AddHeader(string name, string value) => inner.AddHeader(name, value);

        public void AppendCookie(Cookie cookie) => inner.AppendCookie(cookie);

        public void AppendHeader(string name, string value) => inner.AppendHeader(name, value);

        public void Close() => inner.Close();

        public void Close(byte[] responseEntity, bool willBlock) => inner.Close(responseEntity, willBlock);

        public void CopyFrom(HttpListenerResponse templateResponse) => inner.CopyFrom(templateResponse);

        public void Redirect(string url) => inner.Redirect(url);

        public void Redirect(Uri url) => inner.Redirect(url.ToString());

        public void SetCookie(Cookie cookie) => inner.SetCookie(cookie);

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                ((IDisposable)inner).Dispose();
            }
        }
    }
}
