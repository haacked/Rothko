using System;

namespace Rothko
{
    public interface ISemaphore : IDisposable
    {
        bool WaitOne();

        void Release();
    }
}
