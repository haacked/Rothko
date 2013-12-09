using System;
using System.Collections.Generic;
using System.Linq;

namespace Rothko
{
    public class DirectoryInfo : IDirectoryInfo
    {
        readonly System.IO.DirectoryInfo inner;

        private DirectoryInfo(System.IO.DirectoryInfo inner)
        {
            this.inner = inner;
        }

        internal static IDirectoryInfo Wrap(System.IO.DirectoryInfo dir)
        {
            return new DirectoryInfo(dir);
        }

        public IDirectoryInfo Parent
        {
            get { return Wrap(inner.Parent); }
        }

        public IDirectoryInfo Root
        {
            get { return Wrap(inner.Root); }
        }

        public void Create()
        {
            inner.Create();
        }

        public void Create(System.Security.AccessControl.DirectorySecurity directorySecurity)
        {
            inner.Create(directorySecurity);
        }

        public IDirectoryInfo CreateSubdirectory(string path)
        {
            return Wrap(inner.CreateSubdirectory(path));
        }

        public IDirectoryInfo CreateSubdirectory(string path, System.Security.AccessControl.DirectorySecurity directorySecurity)
        {
            return Wrap(inner.CreateSubdirectory(path, directorySecurity));
        }

        public void Delete(bool recursive)
        {
            inner.Delete(recursive);
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories()
        {
            return inner.EnumerateDirectories().Select(Wrap);
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern)
        {
            return inner.EnumerateDirectories(searchPattern).Select(Wrap);
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, System.IO.SearchOption searchOption)
        {
            return inner.EnumerateDirectories(searchPattern, searchOption).Select(Wrap);
        }

        public IEnumerable<IFileInfo> EnumerateFiles()
        {
            return inner.EnumerateFiles().Select(FileInfo.Wrap);
        }

        public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern)
        {
            return inner.EnumerateFiles(searchPattern).Select(FileInfo.Wrap);
        }

        public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, System.IO.SearchOption searchOption)
        {
            return inner.EnumerateFiles(searchPattern, searchOption).Select(FileInfo.Wrap);
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, System.IO.SearchOption searchOption)
        {
            throw new NotImplementedException();
        }

        public System.Security.AccessControl.DirectorySecurity GetAccessControl()
        {
            return inner.GetAccessControl();
        }

        public System.Security.AccessControl.DirectorySecurity GetAccessControl(System.Security.AccessControl.AccessControlSections includeSections)
        {
            return inner.GetAccessControl(includeSections);
        }

        public void MoveTo(string destDirName)
        {
            inner.MoveTo(destDirName);
        }

        public void SetAccessControl(System.Security.AccessControl.DirectorySecurity directorySecurity)
        {
            inner.SetAccessControl(directorySecurity);
        }
    }
}
