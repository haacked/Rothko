using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Rothko
{
    /// <summary>
    /// This class suppresses stack walks for unmanaged code permission. 
    /// (System.Security.SuppressUnmanagedCodeSecurityAttribute is applied to this class.) 
    /// This class is for methods that are safe for anyone to call. Callers of these methods 
    /// are not required to do a full security review to ensure that the usage is secure 
    /// because the methods are harmless 
    /// </summary>
    /// <remarks>
    /// Methods that simply query for information or state that isn't sensitive can be moved 
    /// here.
    /// </remarks>
    [SuppressUnmanagedCodeSecurity]
    internal static class SafeNativeMethods
    {
    }
}
