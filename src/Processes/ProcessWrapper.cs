using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace Rothko
{
    /// <summary>
    /// Wraps the .NET <see cref="System.Diagnostics.Process"/> class in a manner that allows us to 
    /// test usages of the process class.
    /// </summary>
    public class ProcessWrapper : IProcess
    {
        readonly Process process;

        public ProcessWrapper(ProcessStartInfo startInfo)
            : this(startInfo, false)
        {
        }

        [SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
        public ProcessWrapper(ProcessStartInfo startInfo, bool startImmediately)
            : this(CreateProcess(startInfo), startImmediately)
        {
        }

        public ProcessWrapper(Process process)
            : this(process, false)
        {
        }

        [SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0",
            Justification = "Code analysis is smoking some crack. I did validate it.")]
        protected ProcessWrapper(Process process, bool startImmediately)
        {
            if (process == null) throw new ArgumentNullException("process");

            this.process = process;
            process.OutputDataReceived += OnOutputDataReceived;
            process.ErrorDataReceived += OnErrorDataReceived;

            if (startImmediately)
            {
                process.Start();
            }
        }

        public event DataReceivedEventHandler OutputDataReceived;

        public event DataReceivedEventHandler ErrorDataReceived;

        static Process CreateProcess(ProcessStartInfo startInfo)
        {
            Process process = null;
            try
            {
// ReSharper disable once UseObjectOrCollectionInitializer
                process = new Process();
                process.StartInfo = startInfo;
                process.EnableRaisingEvents = true;
                return process;
            }
            catch (Exception)
            {
                if (process != null)
                    process.Dispose();
                throw;
            }
        }

        void OnOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            OnDataReceived(OutputDataReceived, e);
        }

        void OnErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            OnDataReceived(ErrorDataReceived, e);
        }

        void OnDataReceived(DataReceivedEventHandler handler, DataReceivedEventArgs e)
        {
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public int Id
        {
            get { return process.Id; }
        }

        public ProcessStartInfo StartInfo
        {
            get { return process.StartInfo; }
            set { process.StartInfo = value; }
        }

        public StreamWriter StandardInput
        {
            get { return process.StandardInput; }
        }

        public StreamReader StandardOutput { get { return process.StandardOutput; } }
        public StreamReader StandardError { get { return process.StandardOutput; } }

        public int ExitCode
        {
            get { return process.ExitCode; }
        }

        public IntPtr MainWindowHandle
        {
            get { return process.MainWindowHandle; }
        }

        public string ProcessName
        {
            get { return process.ProcessName; }
        }

        public void BeginOutputReadLine()
        {
            process.BeginOutputReadLine();
        }

        public void BeginErrorReadLine()
        {
            process.BeginErrorReadLine();
        }

        public bool Start()
        {
            return process.Start();
        }

        public bool WaitForExit(int milliseconds)
        {
            // Workaround for a bug in which some data may still be processed AFTER this method returns true, thus losing the data.
            // http://connect.microsoft.com/VisualStudio/feedback/details/272125/waitforexit-and-waitforexit-int32-provide-different-and-undocumented-implementations
            bool waitSucceeded = process.WaitForExit(milliseconds);
            if (waitSucceeded)
            {
                process.WaitForExit();
            }
            return waitSucceeded;
        }

        public void Close()
        {
            process.Close();
        }

        public void Kill()
        {
            process.Kill();
        }

        public void KillProcessTree()
        {
            KillProcessTree(process);
        }

        public bool Show()
        {
            return NativeMethods.SetForegroundWindow(MainWindowHandle)
                && NativeMethods.ShowWindow(MainWindowHandle, ShowWindowOption.Restore);
        }

        [SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "processDisposer", Justification = "SafeDispose does call dispose on it.")]
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                var proc = process;
                if (proc != null)
                    proc.Dispose();
            }
        }

        static void KillProcessTree(Process process)
        {
            // Note: We could probably make this a little more efficient by getting the list of processes 
            // once, but then any new child processes would not be included. This has a better chance of 
            // catching them all.
            foreach (var child in GetChildProcesses(process.Id))
            {
                KillProcessTree(child);
            }
            process.Kill();
        }

        static IEnumerable<Process> GetChildProcesses(int processId)
        {
                return from process in Process.GetProcesses()
                       let parent = GetParentProcess(process)
                       where parent != null && parent.Id == processId
                       select process;
        }

        /// <summary>
        /// Gets the parent process of a specified process.
        /// </summary>
        /// <param name="process">The child process.</param>
        /// <returns>An instance of the Process class.</returns>
        static Process GetParentProcess(Process process)
        {
            try
            {
                return GetParentProcess(process.Handle);
            }
            catch (Win32Exception ex)
            {
                const int ERROR_ACCESS_DENIED = 5;
                if (ex.NativeErrorCode == ERROR_ACCESS_DENIED)
                {
                    // This process is probably owned by another user.
                    return null;
                }
                throw;
            }
        }

        /// <summary>
        /// Gets the parent process of a specified process.
        /// </summary>
        /// <param name="handle">The process handle.</param>
        /// <returns>An instance of the Process class.</returns>
        static Process GetParentProcess(IntPtr handle)
        {
            var processInfo = new PROCESS_BASIC_INFORMATION();
            int returnLength;
            int status = NativeMethods.LsaNtStatusToWinError(
                UnsafeNativeMethods.NtQueryInformationProcess(
                    handle, 0, ref processInfo, Marshal.SizeOf(processInfo), out returnLength));
            if (status != 0)
            {
                throw new Win32Exception(status);
            }
            try
            {
                return Process.GetProcessById(processInfo.InheritedFromUniqueProcessId.ToInt32());
            }
            catch (ArgumentException)
            {
                // not found
                return null;
            }
        }
    }
}
