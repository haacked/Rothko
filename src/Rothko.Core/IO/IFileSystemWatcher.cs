﻿using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Rothko.IO
{
    /// <summary>
    ///   Listens to the file system change notifications and raises events when a directory, or file in a
    ///   directory, changes.
    /// </summary>
    /// <filterpriority>2</filterpriority>
    public interface IFileSystemWatcher : IDisposable
    {
        /// <summary>Gets or sets a value indicating whether the watcher is enabled.</summary>
        /// <returns>
        ///   true if the watcher is enabled; otherwise, false. The default is false.
        /// </returns>
        /// <exception cref="T:System.ObjectDisposedException">
        ///   The <see cref="T:Rothko.FileSystemWatcher"/> object has been disposed.
        /// </exception>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///   The current operating system is not Microsoft Windows NT or later.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        ///   The directory specified in <see cref="P:Rothko.FileSystemWatcher.Path"/> could not be found.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        ///   <see cref="P:Rothko.FileSystemWatcher.Path"/> has not been set or is invalid.
        /// </exception>
        /// <filterpriority>2</filterpriority>
        bool EnableRaisingEvents { get; set; }

        /// <summary>Gets or sets the path of the directory to watch.</summary>
        /// <returns>The path to monitor. The default is an empty string ("").</returns>
        /// <exception cref="T:System.ArgumentException">
        ///   The specified path does not exist or could not be found.
        ///   -or- The specified path contains wildcard characters.
        ///   -or- The specified path contains invalid path characters.
        /// </exception>
        /// <filterpriority>2</filterpriority>
        string Path { get; set; }

        /// <summary>
        ///   Gets or sets the filter string used to determine what files are monitored in a directory.
        /// </summary>
        /// <returns>The filter string. The default is "*.*" (Watches all files.) </returns>
        /// <filterpriority>2</filterpriority>
        string Filter { get; set; }

        /// <summary>
        ///   Gets or sets a value indicating whether subdirectories within the specified path should be
        ///   monitored.
        /// </summary>
        /// <returns>
        ///   true if you want to monitor subdirectories; otherwise, false. The default is false.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        bool IncludeSubdirectories { get; set; }

        /// <summary>Gets or sets the size (in bytes) of the internal buffer.</summary>
        /// <returns>The internal buffer size in bytes. The default is 8192 (8 KB).</returns>
        /// <filterpriority>2</filterpriority>
        int InternalBufferSize { get; set; }

        /// <summary>
        ///   Gets or sets the object used to marshal the event handler calls issued as a result of a directory
        ///   change.
        /// </summary>
        /// <returns>
        ///   The <see cref="T:System.ComponentModel.ISynchronizeInvoke"/> that represents the object used to
        ///   marshal the event handler calls issued as a result of a directory change. The default is null.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        ISynchronizeInvoke? SynchronizingObject { get; set; }

        /// <summary>Gets or sets the type of changes to watch for.</summary>
        /// <returns>
        ///   One of the <see cref="T:System.IO.NotifyFilters"/> values. The default is the bitwise OR
        ///   combination of LastWrite, FileName, and DirectoryName.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///   The value is not a valid bitwise OR combination of the <see cref="T:System.IO.NotifyFilters"/>
        ///   values.
        /// </exception>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        ///   The value that is being set is not valid.
        /// </exception>
        /// <filterpriority>2</filterpriority>
        System.IO.NotifyFilters NotifyFilter { get; set; }

        /// <summary>
        ///   A synchronous method that returns a structure that contains specific information on the change
        ///   that occurred, given the type of change you want to monitor.
        /// </summary>
        /// <returns>
        ///   A <see cref="T:System.IO.WaitForChangedResult"/> that contains specific information on the
        ///   change that occurred.
        /// </returns>
        /// <param name="changeType">The <see cref="T:System.IO.WatcherChangeTypes"/> to watch for.</param>
        /// <filterpriority>2</filterpriority>
        System.IO.WaitForChangedResult WaitForChanged(System.IO.WatcherChangeTypes changeType);

        /// <summary>
        ///   Occurs when a file or directory in the specified <see cref="P:Rothko.FileSystemWatcher.Path"/> is
        ///   created.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        event System.IO.FileSystemEventHandler Created;

        /// <summary>
        ///   Occurs when a file or directory in the specified <see cref="P:Rothko.FileSystemWatcher.Path"/> is
        ///   deleted.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        event System.IO.FileSystemEventHandler Deleted;

        /// <summary>
        ///   Occurs when a file or directory in the specified <see cref="P:Rothko.FileSystemWatcher.Path"/> is
        ///   changed.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        event System.IO.FileSystemEventHandler Changed;

        /// <summary>
        ///   Occurs when a file or directory in the specified <see cref="P:Rothko.FileSystemWatcher.Path"/> is
        ///   renamed.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        event System.IO.RenamedEventHandler Renamed;

        /// <summary>
        ///   Occurs when the instance of <see cref="T:Rothko.FileSystemWatcher"/> is unable to continue
        ///   monitoring changes or when the internal buffer overflows.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords",
            MessageId = "Error", Justification = "It's what it's called in the original!")]
        event System.IO.ErrorEventHandler Error;
    }
}
