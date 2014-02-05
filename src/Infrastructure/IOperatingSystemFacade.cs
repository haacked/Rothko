namespace Rothko
{
    public interface IOperatingSystemFacade
    {
        IAssemblyFacade Assembly { get; }
        IDialogFacade Dialog { get; }
        IEnvironment Environment { get; }
        IFileFacade File { get; }
        IMemoryMappedFileFactory MemoryMappedFiles { get; }
        IProcessLocator ProcessLocator { get; }
        IProcessStarter ProcessStarter { get; }
        IRegistry Registry { get; }
    }
}
