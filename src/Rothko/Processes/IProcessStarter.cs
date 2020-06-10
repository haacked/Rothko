using System.Diagnostics;

namespace Rothko
{
    // You can use this instead of calling the static Process.Start directly.
    public interface IProcessStarter
    {
        /// <summary>
        /// Start a process with the given start info.
        /// </summary>
        /// <param name="processStartInfo">Information about the process - like what arguments to pass etc</param>
        /// <returns>A <see cref="IProcess"/> instance.</returns>
        IProcess Start(ProcessStartInfo processStartInfo);

        /// <summary>
        /// Starts a process
        /// </summary>
        /// <param name="fileName">The executable path</param>
        /// <param name="arguments">The arguments to pass</param>
        /// <returns>A <see cref="IProcess"/> instance.</returns>
        IProcess Start(string fileName, string arguments);
    }
}