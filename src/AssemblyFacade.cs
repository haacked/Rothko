using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace Rothko
{
    public class AssemblyFacade : IAssemblyFacade
    {
        [MethodImpl(MethodImplOptions.NoInlining), SecuritySafeCritical]
        public _Assembly GetExecutingAssembly()
        {
            return Assembly.GetCallingAssembly();
        }
    }
}