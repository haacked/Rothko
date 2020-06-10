using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Rothko.IO
{
    /// <summary>
    ///   Exposes instance methods for creating, moving, and enumerating through directories and subdirectories.
    /// </summary>
    /// <filterpriority>1</filterpriority>
    public interface IDirectoryInfo : IFileSystemInfo
    {
        /// <summary>Gets the parent directory of a specified subdirectory.</summary>
        /// <returns>
        ///   The parent directory, or null if the path is null or if the file path denotes a root (such as "\",
        ///   "C:", or * "\\server\share").
        /// </returns>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        /// <filterpriority>1</filterpriority>
        /// <PermissionSet>
        /// <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/>
        /// </PermissionSet>
        IDirectoryInfo? Parent { get; }

        /// <summary>Gets the root portion of a path.</summary>
        /// <returns>
        ///   A <see cref="T:Rothko.IDirectoryInfo"/> object representing the root of a path.
        /// </returns>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        /// <filterpriority>1</filterpriority>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/>
        /// </PermissionSet>
        IDirectoryInfo? Root { get; }

        /// <summary>Creates a directory.</summary>
        /// <exception cref="T:System.IO.IOException">The directory cannot be created. </exception>
        /// <filterpriority>1</filterpriority>
        /// <PermissionSet>
        /// <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/>
        /// </PermissionSet>
        void Create();
        
        /// <summary>
        ///   Creates a subdirectory or subdirectories on the specified path. The specified path can be relative
        ///   to this instance of the <see cref="T:Rothko.IDirectoryInfo"/> class.
        /// </summary>
        /// <returns>The last directory specified in <paramref name="path"/>.</returns>
        /// <param name="path">
        ///   The specified path. This cannot be a different disk volume or Universal Naming Convention (UNC) name.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="path"/> does not specify a valid file path or contains invalid DirectoryInfo characters.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path"/> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        ///   The specified path is invalid, such as being on an unmapped drive.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        ///   The subdirectory cannot be created. -or- A file or directory already has the name specified by <paramref name="path"/>.
        /// </exception>
        /// <exception cref="T:System.IO.PathTooLongException">
        ///   The specified path, file name, or both exceed the system-defined maximum length. For example, on
        ///   Windows-based platforms, paths must be less than 248 characters, and file names must be less than
        ///   260 characters. The specified path, file name, or both are too long.
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have code access permission to create the directory.-or-The caller does not
        ///   have code access permission to read the directory described by the returned <see cref="T:Rothko.IDirectoryInfo"/>
        ///   object.  This can occur when the <paramref name="path"/> parameter describes an existing directory.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///   <paramref name="path"/> contains a colon character (:) that is not part of a drive label ("C:\").
        /// </exception>
        /// <filterpriority>2</filterpriority>
        /// <PermissionSet>
        /// <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/>
        /// </PermissionSet>
        IDirectoryInfo CreateSubdirectory(string path);
        
        /// <summary>
        ///   Deletes this instance of a <see cref="T:Rothko.IDirectoryInfo"/>, specifying whether to delete
        ///   subdirectories and files.
        /// </summary>
        /// <param name="recursive">
        ///   true to delete this directory, its subdirectories, and all files; otherwise, false.
        /// </param>
        /// <exception cref="T:System.UnauthorizedAccessException">
        ///   The directory contains a read-only file.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        ///   The directory described by this <see cref="T:Rothko.IDirectoryInfo"/> object does not exist or
        ///   could not be found.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        ///   The directory is read-only.-or- The directory contains one or more files or subdirectories and
        ///   <paramref name="recursive"/> is false.-or-The directory is the application's current working
        ///   directory. -or-There is an open handle on the directory or on one of its files, and the operating
        ///   system is Windows XP or earlier. This open handle can result from enumerating directories and
        ///   files. For more information, see How to: Enumerate Directories and Files.
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        /// <filterpriority>1</filterpriority>
        /// <PermissionSet>
        /// <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/>
        /// </PermissionSet>
        void Delete(bool recursive);

        /// <summary>Returns an enumerable collection of directory information in the current directory.</summary>
        /// <returns>An enumerable collection of directories in the current directory.</returns>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        ///   The path encapsulated in the <see cref="T:Rothko.IDirectoryInfo"/> object is invalid (for example,
        ///   it is on an unmapped drive).
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        IEnumerable<IDirectoryInfo> EnumerateDirectories();

        /// <summary>
        ///   Returns an enumerable collection of directory information that matches a specified search pattern.
        /// </summary>
        /// <returns>
        ///   An enumerable collection of directories that matches <paramref name="searchPattern"/>.
        /// </returns>
        /// <param name="searchPattern">
        ///   The search string. The default pattern is "*", which returns all directories.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern"/> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        ///   The path encapsulated in the <see cref="T:Rothko.IDirectoryInfo"/> object is invalid (for example,
        ///   it is on an unmapped drive).
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern);

        /// <summary>
        ///   Returns an enumerable collection of directory information that matches a specified search pattern
        ///   and search subdirectory option.
        /// </summary>
        /// <returns>
        ///   An enumerable collection of directories that matches <paramref name="searchPattern"/> and <paramref name="searchOption"/>.
        /// </returns>
        /// <param name="searchPattern">
        ///   The search string. The default pattern is "*", which returns all directories.
        /// </param>
        /// <param name="searchOption">
        ///   One of the enumeration values that specifies whether the search operation should include only the
        ///   current directory or all subdirectories. The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly"/>.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern"/> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="searchOption"/> is not a valid <see cref="T:System.IO.SearchOption"/> value.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        ///   The path encapsulated in the <see cref="T:Rothko.IDirectoryInfo"/> object is invalid (for example,
        ///   it is on an unmapped drive).
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption);

        /// <summary>Returns an enumerable collection of file information in the current directory.</summary>
        /// <returns>An enumerable collection of the files in the current directory.</returns>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        ///   The path encapsulated in the <see cref="T:Rothko.IDirectoryInfo"/> object is invalid (for example,
        ///   it is on an unmapped drive).
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        IEnumerable<IFileInfo> EnumerateFiles();

        /// <summary>Returns an enumerable collection of file information that matches a search pattern.</summary>
        /// <returns>An enumerable collection of files that matches <paramref name="searchPattern"/>.</returns>
        /// <param name="searchPattern">
        ///   The search string. The default pattern is "*", which returns all files.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern"/> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        ///   The path encapsulated in the <see cref="T:Rothko.IDirectoryInfo"/> object is invalid, (for example,
        ///   it is on an unmapped drive).
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        IEnumerable<IFileInfo> EnumerateFiles(string searchPattern);

        /// <summary>
        ///   Returns an enumerable collection of file information that matches a specified search pattern and
        ///   search subdirectory option.
        /// </summary>
        /// <returns>
        ///   An enumerable collection of files that matches <paramref name="searchPattern"/> and <paramref name="searchOption"/>.
        /// </returns>
        /// <param name="searchPattern">
        ///   The search string. The default pattern is "*", which returns all files.
        /// </param>
        /// <param name="searchOption">
        ///   One of the enumeration values that specifies whether the search operation should include only the
        ///   current directory or all subdirectories. The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly"/>.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern"/> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="searchOption"/> is not a valid <see cref="T:System.IO.SearchOption"/> value.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        ///   The path encapsulated in the <see cref="T:Rothko.IDirectoryInfo"/> object is invalid (for example,
        ///   it is on an unmapped drive).
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption);

        /// <summary>Returns an enumerable collection of file system information in the current directory.</summary>
        /// <returns>An enumerable collection of file system information in the current directory.</returns>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        ///   The path encapsulated in the <see cref="T:Rothko.IDirectoryInfo"/> object is invalid (for example,
        ///   it is on an unmapped drive).
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos",
            Justification = "Matches original API")]
        IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos();

        /// <summary>
        ///   Returns an enumerable collection of file system information that matches a specified search pattern.
        /// </summary>
        /// <returns>
        ///   An enumerable collection of file system information objects that matches <paramref name="searchPattern"/>.
        /// </returns>
        /// <param name="searchPattern">
        ///   The search string. The default pattern is "*", which returns all files and directories.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern"/> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// The path encapsulated in the <see cref="T:Rothko.IDirectoryInfo"/> object is invalid (for example,
        /// it is on an unmapped drive).
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern);

        /// <summary>
        ///   Returns an enumerable collection of file system information that matches a specified search pattern
        ///   and search subdirectory option.
        /// </summary>
        /// <returns>
        ///   An enumerable collection of file system information objects that matches <paramref name="searchPattern"/>
        ///   and <paramref name="searchOption"/>.
        /// </returns>
        /// <param name="searchPattern">
        ///   The search string. The default pattern is "*", which returns all files or directories.
        /// </param>
        /// <param name="searchOption">
        ///   One of the enumeration values that specifies whether the search operation should include only the
        ///   current directory or all subdirectories. The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly"/>.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="searchPattern"/> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="searchOption"/> is not a valid <see cref="T:System.IO.SearchOption"/> value.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        ///   The path encapsulated in the <see cref="T:Rothko.IDirectoryInfo"/> object is invalid (for example,
        ///   it is on an unmapped drive).
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption);

        /// <summary>
        ///   Moves a <see cref="T:Rothko.IDirectoryInfo"/> instance and its contents to a new path.
        /// </summary>
        /// <param name="destDirName">
        ///   The name and path to which to move this directory. The destination cannot be another disk volume
        ///   or a directory with the identical name. It can be an existing directory to which you want to add
        ///   this directory as a subdirectory.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="destDirName"/> is null.</exception>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="destDirName"/> is an empty string (''").
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        ///   An attempt was made to move a directory to a different volume. -or-<paramref name="destDirName"/>
        ///   already exists.-or-You are not authorized to access this path.-or- The directory being moved and the
        ///   destination directory have the same name.
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        ///   The destination directory cannot be found.
        /// </exception>
        /// <filterpriority>1</filterpriority>
        /// <PermissionSet>
        /// <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/>
        /// </PermissionSet>
        void MoveTo(string destDirName);

        /// <summary>
        /// Returns true if the directory is empty, otherwise false.
        /// </summary>
        bool IsEmpty { get; }
    }
}