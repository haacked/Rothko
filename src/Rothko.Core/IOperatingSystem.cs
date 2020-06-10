using Rothko.IO;

namespace Rothko
{
    public interface IOperatingSystem
    {
        IDirectoryFacade Directory { get; }
        IEnvironment Environment { get; }
        IFileFacade File { get; }
    }
}
