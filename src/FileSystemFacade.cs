using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Rothko
{
    [Export(typeof(IFileSystemFacade))]
    public class FileSystemFacade : IFileSystemFacade
    {
        public IDirectoryInfo CreateDirectory(string path)
        {
            return DirectoryInfo.Wrap(System.IO.Directory.CreateDirectory(path));
        }

        public void DeleteDirectory(string path)
        {
            System.IO.Directory.Delete(path);
        }

        public void DeleteDirectory(string path, bool recursive)
        {
            System.IO.Directory.Delete(path, recursive);
        }

        public bool DirectoryExists(string path)
        {
            return System.IO.Directory.Exists(path);
        }

        public IDirectoryInfo GetDirectory(string path)
        {
            return new DirectoryInfo(path);
        }

        public string GetCurrentDirectory()
        {
            return System.IO.Directory.GetCurrentDirectory();
        }

        public IEnumerable<string> EnumerateFiles(string path)
        {
            return EnumerateFiles(path, "*.*");
        }

        public IEnumerable<string> EnumerateFiles(string path, string searchPattern)
        {
            return EnumerateFiles(path, searchPattern, System.IO.SearchOption.TopDirectoryOnly);
        }

        public IEnumerable<string> EnumerateFiles(string path, string searchPattern, System.IO.SearchOption searchOption)
        {
            return System.IO.Directory.EnumerateFiles(path, searchPattern, searchOption);
        }
    }
}