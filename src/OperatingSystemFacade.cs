namespace Rothko
{
    public class OperatingSystemFacade : IOperatingSystemFacade
    {
        public OperatingSystemFacade()
        {
            File = new FileFacade();
        }

        public IFilesFacade File { get; private set; }
    }
}
