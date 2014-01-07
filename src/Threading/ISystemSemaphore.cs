namespace Rothko
{
    /// <summary>
    /// Semaphore's come in two variants. Rather than creating an abstraction of a core semaphore, we have an 
    /// abstraction for each type of semaphore.
    /// </summary>
    /// <remarks>
    /// See http://msdn.microsoft.com/en-us/library/system.threading.semaphore(v=vs.110).aspx for more information.
    /// </remarks>
    public interface ISystemSemaphore : ISemaphore
    {
        bool AlreadyExists { get; }
    }
}
