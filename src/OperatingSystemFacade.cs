namespace Rothko
{
    public class OperatingSystemFacade : IOperatingSystemFacade
    {
        public OperatingSystemFacade()
        {
            File = new FileFacade();
            Dialog = new DialogFacade();
        }

        public IFilesFacade File { get; private set; }
        public IDialogFacade Dialog { get; private set; }
    }
}
