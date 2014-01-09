namespace Rothko
{
    public class OperatingSystemFacade : IOperatingSystemFacade
    {
        public OperatingSystemFacade()
        {
            Assembly = new AssemblyFacade();
            Dialog = new DialogFacade();
            Environment = new Environment();
            File = new FileFacade();
            MemoryMappedFiles = new MemoryMappedFileFactory();
            ProcessLocator = new ProcessLocator();
            ProcessStarter = new ProcessStarter();
            Registry = new Registry();
        }

        public IAssemblyFacade Assembly { get; private set; }
        public IDialogFacade Dialog { get; private set; }
        public IEnvironment Environment { get; private set; }
        public IFilesFacade File { get; private set; }
        public IMemoryMappedFileFactory MemoryMappedFiles { get; private set; }
        public IProcessLocator ProcessLocator { get; private set; }
        public IProcessStarter ProcessStarter { get; private set; }
        public IRegistry Registry { get; private set; }
    }
}
