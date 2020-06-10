namespace Rothko
{
    public interface IOperatingSystem
    {
        IAssemblyFacade Assembly { get; }
        IDialogFacade Dialog { get; }
        IDirectoryFacade Directory { get; }
        IEnvironment Environment { get; }
        IFileFacade File { get; }
        IMemoryMappedFileFactory MemoryMappedFiles { get; }
        INetFactory Net { get; }
        IProcessLocator ProcessLocator { get; }
        IProcessStarter ProcessStarter { get; }
        IRegistry Registry { get; }
        IBrowser Browser { get; }
    }
}
