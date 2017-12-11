using System;

namespace Rothko
{
    public interface INetFactory
    {
        IHttpListener CreateHttpListener();
    }
}
