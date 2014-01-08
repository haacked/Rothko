namespace Rothko
{
    public interface IProcessLocator
    {
        /// <summary>
        /// Returns the process specified by the processId. If retrieving the process throws an exception or the 
        /// process id is less than 0, it returns a <see cref="NullProcess"/>.
        /// </summary>
        /// <param name="processId">The ID of the process</param>
        IProcess GetProcessById(int processId);
    }
}
