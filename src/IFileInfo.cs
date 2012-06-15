using System.IO;
using System.Security.AccessControl;

namespace Rothko
{
    public interface IFileInfo : IFileSystemInfo
    {
        DirectoryInfo Directory { get; }

        string DirectoryName { get; }

        bool IsReadOnly { get; set; }

        long Length { get; }

        StreamWriter AppendText();

        FileInfo CopyTo(string destFileName);

        FileInfo CopyTo(string destFileName, bool overwrite);

        FileStream Create();

        StreamWriter CreateText();

        void Decrypt();

        void Encrypt();

        FileSecurity GetAccessControl();

        FileSecurity GetAccessControl(AccessControlSections includeSections);

        void MoveTo(string destFileName);

        FileStream Open(FileMode mode);

        FileStream Open(FileMode mode, FileAccess access);

        FileStream Open(FileMode mode, FileAccess access, FileShare share);

        FileStream OpenRead();

        StreamReader OpenText();

        FileStream OpenWrite();

        FileInfo Replace(string destinationFileName, string destinationBackupFileName);

        FileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);

        void SetAccessControl(FileSecurity fileSecurity);
    }
}