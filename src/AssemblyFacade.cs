using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using NullGuard;

namespace Rothko
{
    public class AssemblyFacade : IAssemblyFacade
    {
        [MethodImpl(MethodImplOptions.NoInlining), SecuritySafeCritical]
        public _Assembly GetExecutingAssembly()
        {
            return Assembly.GetCallingAssembly();
        }

        [return: AllowNull]
        public _Assembly GetEntryAssembly()
        {
            return Assembly.GetEntryAssembly();
        }

        public _Assembly GetAssembly(Type type)
        {
            return Assembly.GetAssembly(type);
        }
    }
}