using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using Rothko.Implementations;

namespace Rothko.IO.Implementations
{
    public class DirectoryInfo : FileSystemInfo, IDirectoryInfo
    {
        readonly System.IO.DirectoryInfo _inner;

        protected internal DirectoryInfo(System.IO.DirectoryInfo inner)
            : base(inner)
        {
            _inner = inner;
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

        [return: NotNullIfNotNull("dir")]
        internal static IDirectoryInfo? Wrap(System.IO.DirectoryInfo dir)
        {
            return dir != null ? new DirectoryInfo(dir) : null;
        }

        public IDirectoryInfo? Parent => Wrap(_inner.Parent);

        public IDirectoryInfo? Root => Wrap(_inner.Root);

        public void Create()
        {
            _inner.Create();
        }
        
        public IDirectoryInfo CreateSubdirectory(string path)
        {
            return Wrap(_inner.CreateSubdirectory(path))!;
        }
        
        public void Delete(bool recursive)
        {
            try
            {
                // Let's use the built in approach first.
                _inner.Delete(recursive);
            }
            catch (UnauthorizedAccessException)
            {
                // If it fails, we'll try our more expansive approach.
                DeleteReadonly(recursive);
            }
        }

        private void DeleteReadonly(bool recursive)
        {
            if (recursive)
            {
                // Adapted from http://stackoverflow.com/questions/329355/cannot-delete-directory-with-directory-deletepath-true/329502#329502
                var files = EnumerateFiles();
                var dirs = EnumerateDirectories();

                foreach (var file in files)
                {
                    // Make sure the file is not readonly.
                    file.Attributes = FileAttributes.Normal;
                    file.Delete();
                }

                foreach (var dir in dirs)
                {
                    dir.Delete(true);
                }
            }

            // Make sure the directory is not readonly
            _inner.Attributes = FileAttributes.Normal;
            _inner.Delete(recursive);
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories()
        {
            return _inner.EnumerateDirectories().Select(Wrap).WhereNotNull();
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern)
        {
            return _inner.EnumerateDirectories(searchPattern).Select(Wrap).WhereNotNull();
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
        {
            return _inner.EnumerateDirectories(searchPattern, searchOption).Select(Wrap).WhereNotNull();
        }

        public IEnumerable<IFileInfo> EnumerateFiles()
        {
            return _inner.EnumerateFiles().Select(FileInfo.Wrap).WhereNotNull();
        }

        public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern)
        {
            return _inner.EnumerateFiles(searchPattern).Select(FileInfo.Wrap).WhereNotNull();
        }

        public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
        {
            return _inner.EnumerateFiles(searchPattern, searchOption).Select(FileInfo.Wrap).WhereNotNull();
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos()
        {
            return _inner.EnumerateFileSystemInfos().Select(Wrap).WhereNotNull();
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
        {
            return _inner.EnumerateFileSystemInfos(searchPattern).Select(Wrap).WhereNotNull();
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return _inner.EnumerateFileSystemInfos(searchPattern, searchOption).Select(Wrap).WhereNotNull();
        }
        
        public void MoveTo(string destDirName)
        {
            _inner.MoveTo(destDirName);
        }

        [SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations"
            , Justification = "Better to throw an exception than give bad info here")]
        public bool IsEmpty
        {
            get
            {
                if (!Exists) throw new DirectoryNotFoundException(
                    String.Format(CultureInfo.InvariantCulture, "The directory '{0}' does not exist", _inner.FullName));
                return !_inner.EnumerateDirectories().Any() && !_inner.EnumerateFiles().Any();

            }
        }
    }
}
