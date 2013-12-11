
namespace Rothko
{
    public class FileInfo : FileSystemInfo, IFileInfo
    {
        readonly System.IO.FileInfo inner;

        private FileInfo(System.IO.FileInfo inner)
            : base(inner)
        {
            this.inner = inner;
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

        internal static IFileInfo Wrap(System.IO.FileInfo file)
        {
            return new FileInfo(file);
        }

        public IDirectoryInfo Directory
        {
            get { return DirectoryInfo.Wrap(inner.Directory); }
        }

        public string DirectoryName
        {
            get { return inner.DirectoryName; }
        }

        public bool IsReadOnly
        {
            get
            {
                return inner.IsReadOnly;
            }
            set
            {
                inner.IsReadOnly = value;
            }
        }

        public long Length
        {
            get { return inner.Length; }
        }

        public System.IO.StreamWriter AppendText()
        {
            return inner.AppendText();
        }

        public IFileInfo CopyTo(string destFileName)
        {
            return Wrap(inner.CopyTo(destFileName));
        }

        public IFileInfo CopyTo(string destFileName, bool overwrite)
        {
            return Wrap(inner.CopyTo(destFileName, overwrite));
        }

        public System.IO.FileStream Create()
        {
            return inner.Create();
        }

        public System.IO.StreamWriter CreateText()
        {
            return inner.CreateText();
        }

        public void Decrypt()
        {
            inner.Decrypt();
        }

        public void Encrypt()
        {
            inner.Encrypt();
        }

        public System.Security.AccessControl.FileSecurity GetAccessControl()
        {
            return inner.GetAccessControl();
        }

        public System.Security.AccessControl.FileSecurity GetAccessControl(System.Security.AccessControl.AccessControlSections includeSections)
        {
            return inner.GetAccessControl(includeSections);
        }

        public void MoveTo(string destFileName)
        {
            inner.MoveTo(destFileName);
        }

        public System.IO.FileStream Open(System.IO.FileMode mode)
        {
            return inner.Open(mode);
        }

        public System.IO.FileStream Open(System.IO.FileMode mode, System.IO.FileAccess access)
        {
            return inner.Open(mode, access);
        }

        public System.IO.FileStream Open(System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share)
        {
            return inner.Open(mode, access, share);
        }

        public System.IO.FileStream OpenRead()
        {
            return inner.OpenRead();
        }

        public System.IO.StreamReader OpenText()
        {
            return inner.OpenText();
        }

        public System.IO.FileStream OpenWrite()
        {
            return inner.OpenWrite();
        }

        public IFileInfo Replace(string destinationFileName, string destinationBackupFileName)
        {
            return Wrap(inner.Replace(destinationFileName, destinationBackupFileName));
        }

        public IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            return Wrap(inner.Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors));
        }

        public void SetAccessControl(System.Security.AccessControl.FileSecurity fileSecurity)
        {
            inner.SetAccessControl(fileSecurity);
        }
    }
}
