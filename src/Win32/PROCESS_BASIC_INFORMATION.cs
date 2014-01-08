using System;
using System.Runtime.CompilerServices;

namespace Rothko
{
    
    [CompilerGenerated] // We're following Win32 conventions here so ignore code analysis.
    public struct PROCESS_BASIC_INFORMATION
    {
        public readonly IntPtr ExitStatus;
        public readonly IntPtr PebBaseAddress;
        public readonly IntPtr AffinityMask;
        public readonly IntPtr BasePriority;
        public readonly UIntPtr UniqueProcessId;
        public readonly IntPtr InheritedFromUniqueProcessId;
    }
}
