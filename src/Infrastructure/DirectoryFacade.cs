using System;
using System.Globalization;
using System.IO;

namespace Rothko
{
    public class DirectoryFacade : IDirectoryFacade
    {
        public IDirectoryInfo GetDirectory(string path)
        {
            return new DirectoryInfo(path);
        }

        public IDirectoryInfo CreateDirectory(string path)
        {
            return new DirectoryInfo(Directory.CreateDirectory(path));
        }

        public bool Exists(string path)
        {
            return Directory.Exists(path);
        }

        public bool IsEmpty(string path)
        {
            var directory = GetDirectory(path);
            if (!directory.Exists)
            {
                throw new DirectoryNotFoundException(
                    String.Format(CultureInfo.InvariantCulture, "The directory '{0}' does not exist", path));
            }
            return directory.IsEmpty;

        }
    }
}
