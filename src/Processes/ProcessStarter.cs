using System;
using System.Diagnostics;

namespace Rothko
{
    public class ProcessStarter : IProcessStarter
    {
        public IProcess Start(ProcessStartInfo processStartInfo)
        {
            return new ProcessWrapper(processStartInfo, startImmediately: true);
        }

        public IProcess Start(string fileName, string arguments)
        {
            // NB: If we invoke a non-EXE string, we will internally use 
            // ShellExecute, which may not *need* to create a separate process
            // to invoke its action (i.e. it pings an out-of-process COM object).
            // In these cases, Process.Start returns 'null'
            var start = Process.Start(fileName, arguments);

            if (start == null &&
                (fileName.EndsWith(".exe", StringComparison.OrdinalIgnoreCase) || !String.IsNullOrEmpty(arguments)))
            {
                throw new InvalidOperationException("Failed to start executable");
            }

            return start != null ?
                new ProcessWrapper(start) :
                (IProcess)new NullProcess();
        }
    }
}
