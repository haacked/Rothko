using System.Collections.Generic;
using System.IO;

namespace Rothko
{
    public interface IDirectoryFacade
    {
        /// <summary>Creates all directories and subdirectories in the specified path.</summary>
        /// <param name="path">The directory path to create. </param>
        /// <returns>An object that represents the directory for the specified path.</returns>
        /// <exception cref="T:System.IO.IOException">
        ///   The directory specified by <paramref name="path"/> is a file.
        ///   -or-The network name is not known.
        /// </exception>
        /// <exception cref="T:System.UnauthorizedAccessException">
        ///   The caller does not have the required permission.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="path"/> is a zero-length string, contains only white space, or contains one or
        ///   more invalid characters as defined by <see cref="F:System.IO.Path.GetInvalidFileNameChars"/>.
        ///   -or-<paramref name="path"/> is prefixed with, or contains only a colon character (:).
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path"/> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">
        ///   The specified path, file name, or both exceed the system-defined maximum length. For example, on
        ///   Windows-based platforms, paths must be less than 248 characters and file names must be less than
        ///   260 characters.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        ///   The specified path is invalid (for example, it is on an unmapped drive).
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///   <paramref name="path"/> contains a colon character (:) that is not part of a drive label ("C:\").
        /// </exception>
        /// <filterpriority>1</filterpriority>
        /// <PermissionSet>
        /// <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/>
        /// </PermissionSet>
        IDirectoryInfo CreateDirectory(string path);

        /// <summary>Deletes an empty directory from a specified path.</summary>
        /// <param name="path">
        ///   The name of the empty directory to remove. This directory must be writable or empty.
        /// </param>
        /// <exception cref="T:System.IO.IOException">
        ///   A file with the same name and location specified by <paramref name="path"/> exists.
        ///   -or-The directory is the application's current working directory.
        ///   -or-The directory specified by <paramref name="path"/> is not empty.
        ///   -or-The directory is read-only or contains a read-only file.
        ///   -or-The directory is being used by another process.
        ///   -or-There is an open handle on the directory, and the operating system is Windows XP or earlier.
        ///   This open handle can result from directories. For more information, see How to: Enumerate
        ///   Directories and Files.
        /// </exception>
        /// <exception cref="T:System.UnauthorizedAccessException">
        ///   The caller does not have the required permission.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="path"/> is a zero-length string, contains only white space, or contains one
        ///   or more invalid characters as defined by <see cref="F:System.IO.Path.GetInvalidFileNameChars"/>.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path"/> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">
        ///   The specified path, file name, or both exceed the system-defined maximum length. For example, on
        ///   Windows-based platforms, paths must be less than 248 characters and file names must be less than
        ///   260 characters.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        ///   <paramref name="path"/> does not exist or could not be found.
        ///   -or-<paramref name="path"/> refers to a file instead of a directory.
        ///   -or-The specified path is invalid (for example, it is on an unmapped drive).
        /// </exception>
        /// <filterpriority>1</filterpriority>
        /// <PermissionSet>
        /// <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/>
        /// </PermissionSet>
        void DeleteDirectory(string path);

        /// <summary>
        /// Returns true if the directory exists at the specified path.
        /// </summary>
        /// <param name="path">Path to the directory</param>
        /// <returns>True if the directory exists, otherwise false.</returns>
        bool Exists(string path);

        /// <summary>
        /// Returns true if the directory is empty
        /// </summary>
        /// <param name="path"></param>
        /// <exception cref="DirectoryNotFoundException">Thrown if the directory doesn't exist</exception>
        /// <returns></returns>
        bool IsEmpty(string path);

        /// <summary>Deletes an empty directory from a specified path.</summary>
        /// <param name="path">The name of the directory to remove.</param>
        /// <param name="recursive">
        ///   true to remove directories, subdirectories, and files in <paramref name="path"/>;
        ///   otherwise, false.
        /// </param>
        /// <exception cref="T:System.IO.IOException">
        ///   A file with the same name and location specified by <paramref name="path"/> exists.
        ///   -or-The directory specified by <paramref name="path"/> is read-only, or
        ///   <paramref name="recursive"/> is false and <paramref name="path"/> is not an empty directory.
        ///   -or-The directory is the application's current working directory.
        ///   -or-The directory contains a read-only file.
        ///   -or-The directory is being used by another process.There is an open handle on the directory or
        ///   on one of its files, and the operating system is Windows XP or earlier. This open handle can
        ///   result from enumerating directories and files. For more information, see How to: Enumerate
        ///   Directories and Files.
        /// </exception>
        /// <exception cref="T:System.UnauthorizedAccessException">
        ///   The caller does not have the required permission.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="path"/> is a zero-length string, contains only white space, or contains one or
        ///   more invalid characters as defined by <see cref="F:System.IO.Path.GetInvalidFileNameChars"/>.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path"/> is null.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">
        ///   The specified path, file name, or both exceed the system-defined maximum length. For example, on
        ///   Windows-based platforms, paths must be less than 248 characters and file names must be less than
        ///   260 characters.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        ///   <paramref name="path"/> does not exist or could not be found.
        ///   -or-<paramref name="path"/> refers to a file instead of a directory.
        ///   -or-The specified path is invalid (for example, it is on an unmapped drive).
        /// </exception>
        /// <filterpriority>1</filterpriority>
        /// <PermissionSet>
        /// <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/>
        /// </PermissionSet>
        void DeleteDirectory(string path, bool recursive);

        /// <summary>Determines whether the given path refers to an existing directory on disk.</summary>
        /// <returns>true if <paramref name="path"/> refers to an existing directory; otherwise, false.</returns>
        /// <param name="path">The path to test.</param>
        /// <filterpriority>1</filterpriority>
        /// <PermissionSet>
        /// <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/>
        /// </PermissionSet>
        bool DirectoryExists(string path);

        /// <summary>Gets a <see cref="T:Rothko.IDirectoryInfo"/> representing the specified path.</summary>
        /// <param name="path">The path of the directory to get.</param>
        /// <returns>An object that represents the directory for the specified path.</returns>
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
        IDirectoryInfo GetDirectory(string path);

        /// <summary>Gets the current working directory of the application.</summary>
        /// <returns>
        ///   A string that contains the path of the current working directory, and does not end with a
        ///   backslash (\).
        /// </returns>
        /// <exception cref="T:System.UnauthorizedAccessException">
        ///   The caller does not have the required permission.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///   The operating system is Windows CE, which does not have current directory functionality.This
        ///   method is available in the .NET Compact Framework, but is not currently supported.
        /// </exception>
        /// <filterpriority>1</filterpriority>
        /// <PermissionSet>
        /// <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/>
        /// </PermissionSet>
        string GetCurrentDirectory();

        /// <summary>Returns an enumerable collection of file names in a specified path.</summary>
        /// <param name="path">The directory to search.</param>
        /// <returns>
        ///   An enumerable collection of the full names (including paths) for the files in the directory
        ///   specified by <paramref name="path"/>.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="path"/> is a zero-length string, contains only white space, or contains invalid
        ///   characters as defined by <see cref="M:System.IO.Path.GetInvalidPathChars"/>.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path"/> is null.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        ///   <paramref name="path"/> is invalid, such as referring to an unmapped drive.
        /// </exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path"/> is a file name.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">
        ///   The specified path, file name, or combined exceed the system-defined maximum length. For example,
        ///   on Windows-based platforms, paths must be less than 248 characters and file names must be less
        ///   than 260 characters.
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        /// <exception cref="T:System.UnauthorizedAccessException">
        ///   The caller does not have the required permission.
        /// </exception>
        IEnumerable<string> EnumerateFiles(string path);

        /// <summary>
        ///   Returns an enumerable collection of file names that match a search pattern in a specified path.
        /// </summary>
        /// <param name="path">The directory to search.</param>
        /// <param name="searchPattern">
        ///   The search string to match against the names of directories in <paramref name="path"/>.
        /// </param>
        /// <returns>
        ///   An enumerable collection of the full names (including paths) for the files in the directory
        ///   specified by <paramref name="path"/> and that match the specified search pattern.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="path "/>is a zero-length string, contains only white space, or contains invalid
        ///   characters as defined by <see cref="M:System.IO.Path.GetInvalidPathChars"/>.
        ///   -or-<paramref name="searchPattern"/> does not contain a valid pattern.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="path"/> is null.
        ///   -or-<paramref name="searchPattern"/> is null.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        ///   <paramref name="path"/> is invalid, such as referring to an unmapped drive.
        /// </exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path"/> is a file name.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">
        ///   The specified path, file name, or combined exceed the system-defined maximum length. For example,
        ///   on Windows-based platforms, paths must be less than 248 characters and file names must be less
        ///   than 260 characters.
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        /// <exception cref="T:System.UnauthorizedAccessException">
        ///   The caller does not have the required permission.
        /// </exception>
        IEnumerable<string> EnumerateFiles(string path, string searchPattern);

        /// <summary>
        ///   Returns an enumerable collection of file names that match a search pattern in a specified path,
        ///   and optionally searches subdirectories.
        /// </summary>
        /// <param name="path">The directory to search.</param>
        /// <param name="searchPattern">
        ///   The search string to match against the names of directories in <paramref name="path"/>.
        /// </param>
        /// <param name="searchOption">
        ///   One of the enumeration values that specifies whether the search operation should include only the
        ///   current directory or should include all subdirectories.The default value is
        ///   <see cref="F:System.IO.SearchOption.TopDirectoryOnly"/>.
        /// </param>
        /// <returns>
        ///   An enumerable collection of the full names (including paths) for the files in the directory
        ///   specified by <paramref name="path"/> and that match the specified search pattern and option.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="path "/>is a zero-length string, contains only white space, or contains invalid
        ///   characters as defined by <see cref="M:System.IO.Path.GetInvalidPathChars"/>.
        ///   -or-<paramref name="searchPattern"/> does not contain a valid pattern.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="path"/> is null.
        ///   -or-<paramref name="searchPattern"/> is null.
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="searchOption"/> is not a valid <see cref="T:System.IO.SearchOption"/> value.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        ///   <paramref name="path"/> is invalid, such as referring to an unmapped drive. 
        /// </exception>
        /// <exception cref="T:System.IO.IOException"><paramref name="path"/> is a file name.</exception>
        /// <exception cref="T:System.IO.PathTooLongException">
        ///   The specified path, file name, or combined exceed the system-defined maximum length. For example,
        ///   on Windows-based platforms, paths must be less than 248 characters and file names must be less
        ///   than 260 characters.
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        /// <exception cref="T:System.UnauthorizedAccessException">
        ///   The caller does not have the required permission.
        /// </exception>
        IEnumerable<string> EnumerateFiles(string path, string searchPattern, System.IO.SearchOption searchOption);

        /// <summary>
        /// Move a directory from <paramref name="source"/> to <paramref name="target"/>
        /// </summary>
        /// <param name="source">Source directory path</param>
        /// <param name="target">Target directory path</param>
        void Move(string source, string target);
    }
}
