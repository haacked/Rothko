using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Linq;

namespace Rothko
{
    [Export(typeof(IProcessLocator))]
    public class ProcessLocator : IProcessLocator
    {
        static readonly IProcess nullProcess = new NullProcess();

        public static IProcess NullProcess { get { return nullProcess; } }

        /// <summary>
        /// Returns the process specified by the processId. If retrieving the process throws an exception or the 
        /// process id is less than 0, it returns a <see cref="NullProcess"/>.
        /// </summary>
        /// <param name="processId">The ID of the process</param>
        public IProcess GetProcessById(int processId)
        {
            try
            {
                var process = Process.GetProcessById(processId);
                Debug.Assert(process != null, "BCL guarantees process is not null");
                if (process.Id > 0)
                {
                    return new ProcessWrapper(process);
                }
            }
            catch (Exception e)
            {
                // Sadly, Process.GetProcessById throws an ArgumentException for a very non-exceptional
                // situation. When the processId is not an actual process id. And there's no way to 
                // "test" it.
                if (!(e is ArgumentException) && e.IsCriticalException())
                {
                    throw;
                }
            }
            return NullProcess;
        }

        public IReadOnlyList<IProcess> GetProcessesByName(string processName)
        {
            return Process.GetProcessesByName(processName).Select(proc => new ProcessWrapper(proc)).ToArray();
        }

        public IProcess GetCurrentProcess()
        {
            return new ProcessWrapper(Process.GetCurrentProcess());
        }
    }
}
