using System.Diagnostics.CodeAnalysis;

namespace Rothko.IO.Implementations
{
    public class FileInfo : FileSystemInfo, IFileInfo
    {
        readonly System.IO.FileInfo _inner;

        FileInfo(System.IO.FileInfo inner)
            : base(inner)
        {
            _inner = inner;
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="T:System.IO.FileInfo"/> class, which acts as a wrapper
        ///   for a file path.
        /// </summary>
        /// <param name="fileName">
        ///   The fully qualified name of the new file, or the relative file name. Do not end the path with the
        ///   directory separator character.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="fileName"/> is null.</exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        ///   The file name is empty, contains only white spaces, or contains invalid characters.
        /// </exception>
        /// <exception cref="T:System.UnauthorizedAccessException">
        ///   Access to <paramref name="fileName"/> is denied.
        /// </exception>
        /// <exception cref="T:System.IO.PathTooLongException">
        ///   The specified path, file name, or both exceed the system-defined maximum length. For example, on
        ///   Windows-based platforms, paths must be less than 248 characters, and file names must be less than
        ///   260 characters.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        /// <paramref name="fileName"/> contains a colon (:) in the middle of the string.</exception>
        public FileInfo(string fileName)
            : this(new System.IO.FileInfo(fileName))
        {
        }

        [return: NotNullIfNotNull("file")]
        internal static IFileInfo? Wrap(System.IO.FileInfo file)
        {
            return file != null ? new FileInfo(file) : null;
        }

        public IDirectoryInfo? Directory => DirectoryInfo.Wrap(_inner.Directory);

        public string DirectoryName => _inner.DirectoryName;

        public bool IsReadOnly
        {
            get => _inner.IsReadOnly;
            set => _inner.IsReadOnly = value;
        }

        public long Length => _inner.Length;

        public System.IO.StreamWriter AppendText()
        {
            return _inner.AppendText();
        }

        public IFileInfo CopyTo(string destFileName)
        {
            return Wrap(_inner.CopyTo(destFileName))!;
        }

        public IFileInfo CopyTo(string destFileName, bool overwrite)
        {
            return Wrap(_inner.CopyTo(destFileName, overwrite))!;
        }

        public System.IO.FileStream Create()
        {
            return _inner.Create();
        }

        public System.IO.StreamWriter CreateText()
        {
            return _inner.CreateText();
        }

        public void Decrypt()
        {
            _inner.Decrypt();
        }

        public void Encrypt()
        {
            _inner.Encrypt();
        }

        public void MoveTo(string destFileName)
        {
            _inner.MoveTo(destFileName);
        }

        public System.IO.FileStream Open(System.IO.FileMode mode)
        {
            return _inner.Open(mode);
        }

        public System.IO.FileStream Open(System.IO.FileMode mode, System.IO.FileAccess access)
        {
            return _inner.Open(mode, access);
        }

        public System.IO.FileStream Open(System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share)
        {
            return _inner.Open(mode, access, share);
        }

        public System.IO.FileStream OpenRead()
        {
            return _inner.OpenRead();
        }

        public System.IO.StreamReader OpenText()
        {
            return _inner.OpenText();
        }

        public System.IO.FileStream OpenWrite()
        {
            return _inner.OpenWrite();
        }

        public IFileInfo Replace(string destinationFileName, string destinationBackupFileName)
        {
            return Wrap(_inner.Replace(destinationFileName, destinationBackupFileName))!;
        }

        public IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            return Wrap(_inner.Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors))!;
        }
    }
}
