using System.Diagnostics;

namespace Rothko
{
    // You can use this instead of calling the static Process.Start directly.
    public interface IProcessStarter
    {
        IProcess Start(ProcessStartInfo processStartInfo);
        IProcess Start(string fileName, string arguments);
    }
}