using System.Runtime.InteropServices;

namespace Rothko.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    internal class OsVersionInfoEx
    {
        public OsVersionInfoEx()
        {
            OSVersionInfoSize = Marshal.SizeOf(this);
        }

        /// <summary>
        /// The size of this data structure, in bytes. Set this member to sizeof(OSVERSIONINFO).
        /// </summary>
        public int OSVersionInfoSize = 0;

        /// <summary>
        /// The major version number of the operating system.
        /// </summary>
        public int MajorVersion = 0;

        /// <summary>
        /// The minor version number of the operating system.
        /// </summary>
        public int MinorVersion = 0;

        /// <summary>
        /// The build number of the operating system.
        /// </summary>
        public int BuildNumber = 0;

        /// <summary>
        /// The operating system platform. This member can be VER_PLATFORM_WIN32_NT (2).
        /// </summary>
        public int PlatformId = 0;

        /// <summary>
        /// A null-terminated string, such as "Service Pack 3", that indicates the latest Service Pack installed on the system. 
        /// If no Service Pack has been installed, the string is empty.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string CSDVersion = null;

        /// <summary>
        /// The major version number of the latest Service Pack installed on the system. 
        /// For example, for Service Pack 3, the major version number is 3. If no Service Pack has been installed, the value is zero.
        /// </summary>
        public ushort ServicePackMajor = 0;

        /// <summary>
        /// The minor version number of the latest Service Pack installed on the system. 
        /// For example, for Service Pack 3, the minor version number is 0.
        /// </summary>
        public ushort ServicePackMinor = 0;

        /// <summary>
        /// A bit mask that identifies the product suites available on the system.
        /// </summary>
        public short SuiteMask = 0;

        /// <summary>
        /// Any additional information about the system. 
        /// </summary>
        public byte ProductType = 0;

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public byte Reserved = 0;
    }
}
