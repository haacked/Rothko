using System.Threading;

namespace Rothko
{
    public sealed class SystemSemaphore : ISystemSemaphore
    {
        readonly Semaphore innerSemaphore;

        public SystemSemaphore(int initialCount, int maximumCount, string name)
        {
            bool createdNewSemaphore;
            innerSemaphore = new Semaphore(initialCount, maximumCount, name, out createdNewSemaphore);
            AlreadyExists = !createdNewSemaphore;
        }

        public bool AlreadyExists { get; private set; }

        public bool WaitOne()
        {
            return innerSemaphore.WaitOne();
        }

        public void Release()
        {
            innerSemaphore.Release();
        }

        public void Dispose()
        {
            var semaphore = innerSemaphore;
            if (semaphore != null)
            {
                semaphore.Dispose();
            }
        }
    }
}
