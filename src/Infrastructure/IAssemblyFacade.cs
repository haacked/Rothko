using System.Runtime.InteropServices;

namespace Rothko
{
    public interface IAssemblyFacade
    {
        _Assembly GetExecutingAssembly();
    }
}