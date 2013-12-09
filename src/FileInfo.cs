
namespace Rothko
{
    public class FileInfo : FileSystemInfo, IFileInfo
    {
        readonly System.IO.FileInfo inner;

        private FileInfo(System.IO.FileInfo inner)
            : base(inner as System.IO.FileSystemInfo)
        {
            this.inner = inner;
        }

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
