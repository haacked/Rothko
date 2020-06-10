using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Rothko.IO.Implementations
{
    /// <summary>
    ///   Listens to the file system change notifications and raises events when a directory, or file in a
    ///   directory, changes.
    /// </summary>
    /// <filterpriority>2</filterpriority>
    public class FileSystemWatcher : MarshalByRefObject, IFileSystemWatcher
    {
        readonly System.IO.FileSystemWatcher _inner;

        /// <summary>
        ///   Initializes a new instance of the <see cref="T:Rothko.FileSystemWatcher"/> class.
        /// </summary>
        public FileSystemWatcher() : this(null, null, true)
        {
        }

        public FileSystemWatcher(string path) : this(path,null, true)
        {
        }
        
        FileSystemWatcher(string? path, string? filter, bool _)
        {
            _inner = path is null
                ? new System.IO.FileSystemWatcher()
                : filter is null
                    ? new System.IO.FileSystemWatcher(path)
                    : new System.IO.FileSystemWatcher(path, filter);
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="T:Rothko.FileSystemWatcher"/> class, given the
        ///   specified directory and type of files to monitor.
        /// </summary>
        /// <param name="path">
        ///   The directory to monitor, in standard or Universal Naming Convention (UNC) notation.
        /// </param>
        /// <param name="filter">
        ///   The type of files to watch. For example, "*.txt" watches for changes to all text files.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   The <paramref name="path"/> parameter is null.
        ///   -or- The <paramref name="filter"/> parameter is null.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        ///   The <paramref name="path"/> parameter is an empty string ("").
        ///   -or- The path specified through the <paramref name="path"/> parameter does not exist.
        /// </exception>
        /// <exception cref="T:System.IO.PathTooLongException"><paramref name="path"/> is too long.</exception>
        public FileSystemWatcher(string path, string filter) : this(path, filter, true)
        {
        }

        /// <summary>Gets or sets a value indicating whether the watcher is enabled.</summary>
        /// <returns>
        ///   true if the watcher is enabled; otherwise, false. The default is false. If you are using the
        ///   watcher on a designer in Visual Studio 2005, the default is true.
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
        public bool EnableRaisingEvents
        {
            get => _inner.EnableRaisingEvents;
            set => _inner.EnableRaisingEvents = value;
        }

        /// <summary>Gets or sets the path of the directory to watch.</summary>
        /// <returns>The path to monitor. The default is an empty string ("").</returns>
        /// <exception cref="T:System.ArgumentException">
        ///   The specified path does not exist or could not be found.
        ///   -or- The specified path contains wildcard characters.
        ///   -or- The specified path contains invalid path characters.
        /// </exception>
        /// <filterpriority>2</filterpriority>
        public string Path
        {
            get => _inner.Path;
            set => _inner.Path = value;
        }

        /// <summary>
        ///   Gets or sets the filter string used to determine what files are monitored in a directory.
        /// </summary>
        /// <returns>The filter string. The default is "*.*" (Watches all files.) </returns>
        /// <filterpriority>2</filterpriority>
        public string Filter
        {
            get => _inner.Filter;
            set => _inner.Filter = value;
        }

        /// <summary>
        ///   Gets or sets a value indicating whether subdirectories within the specified path should be
        ///   monitored.
        /// </summary>
        /// <returns>
        ///   true if you want to monitor subdirectories; otherwise, false. The default is false.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public bool IncludeSubdirectories
        {
            get => _inner.IncludeSubdirectories;
            set => _inner.IncludeSubdirectories = value;
        }

        /// <summary>Gets or sets the size (in bytes) of the internal buffer.</summary>
        /// <returns>The internal buffer size in bytes. The default is 8192 (8 KB).</returns>
        /// <filterpriority>2</filterpriority>
        public int InternalBufferSize
        {
            get => _inner.InternalBufferSize;
            set => _inner.InternalBufferSize = value;
        }

        /// <summary>
        ///   Gets or sets the object used to marshal the event handler calls issued as a result of a directory
        ///   change.
        /// </summary>
        /// <returns>
        ///   The <see cref="T:System.ComponentModel.ISynchronizeInvoke"/> that represents the object used to
        ///   marshal the event handler calls issued as a result of a directory change. The default is null.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public ISynchronizeInvoke? SynchronizingObject
        {
            get => _inner.SynchronizingObject;
            set => _inner.SynchronizingObject = value;
        }


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
        public System.IO.NotifyFilters NotifyFilter
        {
            get => _inner.NotifyFilter;
            set => _inner.NotifyFilter = value;
        }

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
        public System.IO.WaitForChangedResult WaitForChanged(System.IO.WatcherChangeTypes changeType)
        {
            return _inner.WaitForChanged(changeType);
        }

        /// <summary>
        ///   Determines whether the specified <see cref="T:System.Object"/> is equal to the current
        ///   <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>true if the specified object  is equal to the current object; otherwise, false.</returns>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <filterpriority>2</filterpriority>
        [SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations",
            Justification = "It doesn't!")]
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            if (!(obj is FileSystemWatcher other))
                return false;

            return _inner.Equals(other._inner);
        }

        /// <summary>Serves as a hash function for a particular type.</summary>
        /// <returns>A hash code for the current <see cref="T:System.Object"/>.</returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            return _inner.GetHashCode();
        }
        
        /// <summary>
        ///   Releases all resources used by the <see cref="T:Rothko.FileSystemWatcher"/>.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///   Releases the unmanaged resources used by the <see cref="T:Rothko.FileSystemWatcher"/> and
        ///   optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        ///   true to release both managed and unmanaged resources; false to release only unmanaged resources.
        /// </param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _inner?.Dispose();
            }
        }
        
        /// <summary>
        ///   Occurs when a file or directory in the specified <see cref="P:Rothko.FileSystemWatcher.Path"/> is
        ///   created.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public event System.IO.FileSystemEventHandler Created
        {
            add => _inner.Created += value;
            remove => _inner.Created -= value;
        }

        /// <summary>
        ///   Occurs when a file or directory in the specified <see cref="P:Rothko.FileSystemWatcher.Path"/> is
        ///   deleted.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public event System.IO.FileSystemEventHandler Deleted
        {
            add => _inner.Deleted += value;
            remove => _inner.Deleted -= value;
        }

        /// <summary>
        ///   Occurs when a file or directory in the specified <see cref="P:Rothko.FileSystemWatcher.Path"/> is
        ///   changed.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public event System.IO.FileSystemEventHandler Changed
        {
            add => _inner.Changed += value;
            remove => _inner.Changed -= value;
        }

        /// <summary>
        ///   Occurs when the instance of <see cref="T:Rothko.FileSystemWatcher"/> is unable to continue
        ///   monitoring changes or when the internal buffer overflows.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public event System.IO.RenamedEventHandler Renamed
        {
            add => _inner.Renamed += value;
            remove => _inner.Renamed -= value;
        }

        /// <summary>
        ///   Occurs when the instance of <see cref="T:Rothko.FileSystemWatcher"/> is unable to continue
        ///   monitoring changes or when the internal buffer overflows.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public event System.IO.ErrorEventHandler Error
        {
            add => _inner.Error += value;
            remove => _inner.Error -= value;
        }

        /// <summary>
        ///   Occurs when the watcher is disposed by a call to the <see cref="M:Rothko.FileSystemWatcher.Dispose"/>
        ///   method.
        /// </summary>
        public event EventHandler Disposed
        {
            add => _inner.Disposed += value;
            remove => _inner.Disposed -= value;
        }
    }
}
