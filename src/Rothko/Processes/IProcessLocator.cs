using System.Collections.Generic;

namespace Rothko
{
    public interface IProcessLocator
    {
        /// <summary>
        /// Returns the process specified by the processId. If retrieving the process throws an exception or the 
        /// process id is less than 0, it returns a <see cref="NullProcess"/>.
        /// </summary>
        /// <param name="processId">The ID of the process</param>
        IProcess GetProcessById(int processId);

        /// <summary>
        /// Creates an read only list of new System.Diagnostics.Process components and associates
        /// them with all the process resources on the local computer that share the
        /// specified process name.
        /// </summary>
        /// <param name="processName"></param>
        /// <returns></returns>
        IReadOnlyList<IProcess> GetProcessesByName(string processName);

        /// <summary>
        /// Returns the process associated with the currently running process.
        /// </summary>
        /// <returns></returns>
        IProcess GetCurrentProcess();
    }
}
