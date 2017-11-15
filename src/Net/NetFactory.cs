using System.Net;

namespace Rothko
{
    public class NetFactory : INetFactory
    {
        public IHttpListener CreateHttpListener()
        {
            return new HttpListenerWrapper(new HttpListener());
        }
    }
}
