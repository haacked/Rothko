using System;
using System.Runtime.InteropServices;

namespace Rothko
{
    internal static class NativeMethods
    {
        [DllImport("advapi32")]
        internal static extern int LsaNtStatusToWinError(int ntstatus);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow(IntPtr hWnd, ShowWindowOption nCmdShow);
    }
}
