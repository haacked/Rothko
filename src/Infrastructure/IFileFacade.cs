using System.Collections.Generic;
using System.Security;
using System.Text;

namespace Rothko
{
    public interface IFileFacade
    {
        /// <summary>Determines whether the specified file exists.</summary>
        /// <param name="path">The file to check.</param>
        /// <return>
        ///   true if the caller has the required permissions and path contains the name
        ///   of an existing file; otherwise, false. This method also returns false if
        ///   path is null, an invalid path, or a zero-length string. If the caller does
        ///   not have sufficient permissions to read the specified file, no exception
        ///   is thrown and the method returns false regardless of the existence of path.
        /// </return>
        bool Exists(string path);

        /// <summary>Gets a <see cref="T:Rothko.IFileInfo"/> representing the specified path.</summary>
        /// <param name="path">The path of the file to get.</param>
        /// <returns>An object that represents the file for the specified path.</returns>
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
        IFileInfo GetFile(string path);

        /// <summary>
        ///   Gets a <see cref="T:Rothko.IFileInfo"/> representing the specified path.
        /// </summary>
        /// <param name="path">The path of the file to get.</param>
        /// <param name="contents">The string to write to the file.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path"/> is null or <paramref name="contents"/> is null. </exception>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="path"/> contains invalid characters such as ", &gt;, &lt;, or |.
        /// </exception>
        /// <exception cref="T:System.DirectoryNotFoundException">
        ///   The specified <paramref name="path"/> is invalid (for example, it is on an unmapped drive).
        /// </exception>
        /// <exception cref="T:System.IO.PathTooLongException">
        ///   The specified <paramref name="path"/>, file name, or both exceed the system-defined maximum length. For example, on
        ///   Windows-based platforms, paths must be less than 248 characters, and file names must be less than
        ///   260 characters. The specified path, file name, or both are too long.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        ///   An I/O error occurred while opening the file.
        /// </exception>
        /// <exception cref="T:System.UnauthorizedAccessException">
        ///   <paramref name="path"/> specified a file that is read-only.-or- This operation is not supported
        ///   on the current platform.-or- path specified a directory.-or- The caller does
        ///   not have the required permission.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///   The caller does not have the required permission.
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        void WriteAllText(string path, string contents);

        /// <summary>
        ///     Copies an existing file to a new file. Overwriting a file of the same name
        ///     is allowed.
        /// </summary>
        /// <param name="sourceFileName">The file to copy.</param>
        /// <param name="destFileName">The name of the destination file. This cannot be a directory.</param>
        /// <param name="overwrite">true if the destination file can be overwritten; otherwise, false.</param>
        /// <exception cref="T:System.UnauthorizedAccessException">
        ///   The caller does not have the required permission. -or-destFileName is read-only.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is a zero-length string,
        ///   contains only white space, or contains one or more invalid characters as defined by
        ///   System.IO.Path.InvalidPathChars.-or- sourceFileName or destFileName specifies a directory.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="sourceFileName" /> or <paramref name="destFileName" /> sourceFileName or destFileName is null.
        /// </exception>
        /// <exception cref="T:System.IO.PathTooLongException">
        ///   The path specified in <paramref name="sourceFileName" /> or <paramref name="destFileName" />, file name,
        ///   or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be
        ///   less than 248 characters, and file names must be less than 260 characters. The specified path, file
        ///   name, or both are too long.
        /// </exception>
        /// <exception cref="T:System.DirectoryNotFoundException">
        ///   The path specified in <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is invalid
        ///   (for example, it is on an unmapped drive).
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        ///   <paramref name="sourceFileName" /> was not found.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        ///   <paramref name="destFileName" /> exists and overwrite is false.-or- An I/O error has occurred.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///   The caller does not have the required permission.
        /// </exception>
        void Copy(string sourceFileName, string destFileName, bool overwrite);


        /// <summary>
        ///   Moves a specified file to a new location, providing the option to specify
        ///   a new file name.
        /// </summary>
        /// <param name="sourceFileName">The file to copy.</param>
        /// <param name="destFileName">The name of the destination file. This cannot be a directory.</param>
        /// <exception cref="T:System.UnauthorizedAccessException">
        ///   The caller does not have the required permission. -or-destFileName is read-only.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is a zero-length string,
        ///   contains only white space, or contains one or more invalid characters as defined by
        ///   System.IO.Path.InvalidPathChars.-or- sourceFileName or destFileName specifies a directory.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="sourceFileName" /> or <paramref name="destFileName" /> sourceFileName or destFileName is null.
        /// </exception>
        /// <exception cref="T:System.IO.PathTooLongException">
        ///   The path specified in <paramref name="sourceFileName" /> or <paramref name="destFileName" />, file name,
        ///   or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be
        ///   less than 248 characters, and file names must be less than 260 characters. The specified path, file
        ///   name, or both are too long.
        /// </exception>
        /// <exception cref="T:System.DirectoryNotFoundException">
        ///   The path specified in <paramref name="sourceFileName" /> or <paramref name="destFileName" /> is invalid
        ///   (for example, it is on an unmapped drive).
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        ///   <paramref name="sourceFileName" /> was not found.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        ///   <paramref name="destFileName" /> exists and overwrite is false.-or- An I/O error has occurred.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///   The caller does not have the required permission.
        /// </exception>
        void Move(string sourceFileName, string destFileName);

        /// <summary>
        ///   Read the lines of a file that has a specified encoding.
        /// </summary>
        /// <param name="path">The file to check.</param>
        /// <param name="encoding">The encoding that is applied to the contents of the file.</param>
        /// <returns>
        ///   All the lines of the file, or the lines that are the result of a query.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="path"/> is a zero-length string, contains only white space, or contains one
        ///     or more invalid characters as defined by the System.IO.Path.GetInvalidPathChars()
        ///     method.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path"/> is null. </exception>
        /// <exception cref="T:System.DirectoryNotFoundException">
        ///   The specified <paramref name="path"/> is invalid (for example, it is on an unmapped drive).
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        ///   <paramref name="path" /> was not found.
        /// </exception>
        /// <exception cref="T:System.IO.PathTooLongException">
        ///   The specified <paramref name="path"/>, file name, or both exceed the system-defined maximum length. For example, on
        ///   Windows-based platforms, paths must be less than 248 characters, and file names must be less than
        ///   260 characters. The specified path, file name, or both are too long.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        ///   An I/O error occurred while opening the file.
        /// </exception>
        /// <exception cref="T:System.UnauthorizedAccessException">
        ///   <paramref name="path"/> specified a file that is read-only.-or- This operation is not supported
        ///   on the current platform.-or- path specified a directory.-or- The caller does
        ///   not have the required permission.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///   The caller does not have the required permission.
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        IEnumerable<string> ReadLines(string path, Encoding encoding);

        /// <summary>
        ///   Opens a file, reads all lines of the file with the specified encoding, and
        ///   then closes the file.
        /// </summary>
        /// <param name="path">The file to check.</param>
        /// <param name="encoding">The encoding that is applied to the contents of the file.</param>
        /// <returns>
        ///   All the lines of the file, or the lines that are the result of a query.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="path"/> is a zero-length string, contains only white space, or contains one
        ///     or more invalid characters as defined by the System.IO.Path.GetInvalidPathChars()
        ///     method.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path"/> is null. </exception>
        /// <exception cref="T:System.DirectoryNotFoundException">
        ///   The specified <paramref name="path"/> is invalid (for example, it is on an unmapped drive).
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        ///   <paramref name="path" /> was not found.
        /// </exception>
        /// <exception cref="T:System.IO.PathTooLongException">
        ///   The specified <paramref name="path"/>, file name, or both exceed the system-defined maximum length. For example, on
        ///   Windows-based platforms, paths must be less than 248 characters, and file names must be less than
        ///   260 characters. The specified path, file name, or both are too long.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        ///   An I/O error occurred while opening the file.
        /// </exception>
        /// <exception cref="T:System.UnauthorizedAccessException">
        ///   <paramref name="path"/> specified a file that is read-only.-or- This operation is not supported
        ///   on the current platform.-or- path specified a directory.-or- The caller does
        ///   not have the required permission.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///   The caller does not have the required permission.
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        string ReadAllText(string path, Encoding encoding);

        /// <summary>
        /// Deletes the specified file.
        /// </summary>
        /// <param name="path">The file to check.</param>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="path"/> is a zero-length string, contains only white space, or contains one
        ///     or more invalid characters as defined by the System.IO.Path.GetInvalidPathChars()
        ///     method.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="path"/> is null. </exception>
        /// <exception cref="T:System.DirectoryNotFoundException">
        ///   The specified <paramref name="path"/> is invalid (for example, it is on an unmapped drive).
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        ///   <paramref name="path" /> was not found.
        /// </exception>
        /// <exception cref="T:System.IO.PathTooLongException">
        ///   The specified <paramref name="path"/>, file name, or both exceed the system-defined maximum length. For example, on
        ///   Windows-based platforms, paths must be less than 248 characters, and file names must be less than
        ///   260 characters. The specified path, file name, or both are too long.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        /// The specified file is in use. -or-There is an open handle on the file, and
        /// the operating system is Windows XP or earlier. This open handle can result
        /// from enumerating directories and files. For more information, see How to:
        /// Enumerate Directories and Files.
        /// </exception>
        /// <exception cref="T:System.UnauthorizedAccessException">
        //  The caller does not have the required permission.-or- <paramref name="path"/> is a directory.-or-
        //  path specified a read-only file.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        /// <paramref name="path"/> is in an invalid format.
        /// </exception>
        /// <exception cref="T:System.Security.SecurityException">
        ///   The caller does not have the required permission.
        /// </exception>
        void Delete(string path);
    }
}
