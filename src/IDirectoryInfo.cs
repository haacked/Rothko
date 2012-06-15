using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;

namespace Rothko
{
    public interface IDirectoryInfo
    {
        IDirectoryInfo Parent { get; }

        IDirectoryInfo Root { get; }

        void Create();

        void Create(DirectorySecurity directorySecurity);

        IDirectoryInfo CreateSubdirectory(string path);

        IDirectoryInfo CreateSubdirectory(string path, DirectorySecurity directorySecurity);

        void Delete(bool recursive);

        IEnumerable<IDirectoryInfo> EnumerateDirectories();

        IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern);

        IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption);

        IEnumerable<IFileInfo> EnumerateFiles();

        IEnumerable<IFileInfo> EnumerateFiles(string searchPattern);

        IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption);

        IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos();

        IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern);

        IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption);

        DirectorySecurity GetAccessControl();

        DirectorySecurity GetAccessControl(AccessControlSections includeSections);

        void MoveTo(string destDirName);

        void SetAccessControl(DirectorySecurity directorySecurity);
    }
}