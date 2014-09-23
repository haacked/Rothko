using System.IO;

namespace Rothko
{
    public interface IDirectoryFacade
    {
        /// <summary>
        /// Returns a <see cref="IDirectoryInfo"/> representing the directory at the specified path.
        /// </summary>
        /// <param name="path">Path to the directory</param>
        /// <returns>A <see cref="IDirectoryInfo" /> instance.</returns>
        IDirectoryInfo GetDirectory(string path);

        /// <summary>
        /// Creates all directories and subdirectories in the specified path.
        /// </summary>
        /// <remarks>
        /// If the directory already exists, it just returns the directory.
        /// </remarks>
        /// <param name="path">Path to the directory</param>
        /// <returns>A <see cref="IDirectoryInfo" /> instance.</returns>
        IDirectoryInfo CreateDirectory(string path);

        /// <summary>
        /// Returns true if the directory exists at the specified path.
        /// </summary>
        /// <param name="path">Path to the directory</param>
        /// <returns>True if the directory exists, otherwise false.</returns>
        bool Exists(string path);
        
        /// <summary>
        /// Returns true if the directory is empty
        /// </summary>
        /// <param name="path"></param>
        /// <exception cref="DirectoryNotFoundException">Thrown if the directory doesn't exist</exception>
        /// <returns></returns>
        bool IsEmpty(string path);
    }
}
