using System;
using System.Runtime.InteropServices;

namespace Rothko
{
    public interface IAssemblyFacade
    {
        _Assembly GetExecutingAssembly();
        _Assembly GetEntryAssembly();
        _Assembly GetAssembly(Type type);
    }
}