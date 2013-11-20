namespace Rothko
{
    public interface IOperatingSystemFacade
    {
        IFilesFacade File { get; }
        IDialogFacade Dialog { get; }
    }
}
