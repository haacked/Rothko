using System;
using System.Collections.Generic;
using System.Linq;

namespace Rothko
{
    public class DirectoryInfo : FileSystemInfo, IDirectoryInfo
    {
        readonly System.IO.DirectoryInfo inner;

        private DirectoryInfo(System.IO.DirectoryInfo inner)
            : base(inner)
        {
            this.inner = inner;
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="T:Rothko.DirectoryInfo"/> class on the specified path.
        /// </summary>
        /// <param name="path">A string specifying the path on which to create the DirectoryInfo.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path"/> is null. </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="path"/> contains invalid characters such as ", &gt;, &lt;, or |.
        /// </exception>
        /// <exception cref="T:System.IO.PathTooLongException">
        ///   The specified path, file name, or both exceed the system-defined maximum length. For example, on
        ///   Windows-based platforms, paths must be less than 248 characters, and file names must be less than
        ///   260 characters. The specified path, file name, or both are too long.
        /// </exception>
        public DirectoryInfo(string path)
            : this(new System.IO.DirectoryInfo(path))
        {
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
            return inner.EnumerateFileSystemInfos().Select(Wrap);
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
        {
            return inner.EnumerateFileSystemInfos(searchPattern).Select(Wrap);
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, System.IO.SearchOption searchOption)
        {
            return inner.EnumerateFileSystemInfos(searchPattern, searchOption).Select(Wrap);
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
