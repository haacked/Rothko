using NullGuard;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Rothko
{
    /// <summary>
    ///   Listens to the file system change notifications and raises events when a directory, or file in a
    ///   directory, changes.
    /// </summary>
    /// <filterpriority>2</filterpriority>
    public class FileSystemWatcher : MarshalByRefObject, IFileSystemWatcher
    {
        readonly System.IO.FileSystemWatcher inner;

        /// <summary>
        ///   Initializes a new instance of the <see cref="T:Rothko.FileSystemWatcher"/> class.
        /// </summary>
        public FileSystemWatcher()
        {
            inner = new System.IO.FileSystemWatcher();
            HookEvents();
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="T:Rothko.FileSystemWatcher"/> class, given the
        ///   specified directory to monitor.
        /// </summary>
        /// <param name="path">
        ///   The directory to monitor, in standard or Universal Naming Convention (UNC) notation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   The <paramref name="path"/> parameter is null.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        ///   The <paramref name="path"/> parameter is an empty string ("").
        ///   -or- The path specified through the <paramref name="path"/> parameter does not exist.
        /// </exception>
        /// <exception cref="T:System.IO.PathTooLongException"><paramref name="path"/> is too long.</exception>
        public FileSystemWatcher(string path)
        {
            inner = new System.IO.FileSystemWatcher(path);
            HookEvents();
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
        public FileSystemWatcher(string path, string filter)
        {
            inner = new System.IO.FileSystemWatcher(path, filter);
            HookEvents();
        }

        /// <summary>Gets or sets a value indicating whether the component is enabled.</summary>
        /// <returns>
        ///   true if the component is enabled; otherwise, false. The default is false. If you are using the
        ///   component on a designer in Visual Studio 2005, the default is true.
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
            get { return inner.EnableRaisingEvents; }
            set { inner.EnableRaisingEvents = value; }
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
            get { return inner.Path; }
            set { inner.Path = value; }
        }

        /// <summary>
        ///   Gets or sets the filter string used to determine what files are monitored in a directory.
        /// </summary>
        /// <returns>The filter string. The default is "*.*" (Watches all files.) </returns>
        /// <filterpriority>2</filterpriority>
        public string Filter
        {
            get { return inner.Filter; }
            set { inner.Filter = value; }
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
            get { return inner.IncludeSubdirectories; }
            set { inner.IncludeSubdirectories = value; }
        }

        /// <summary>Gets or sets the size (in bytes) of the internal buffer.</summary>
        /// <returns>The internal buffer size in bytes. The default is 8192 (8 KB).</returns>
        /// <filterpriority>2</filterpriority>
        public int InternalBufferSize
        {
            get { return inner.InternalBufferSize; }
            set { inner.InternalBufferSize = value; }
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
        [AllowNull]
        public ISynchronizeInvoke SynchronizingObject
        {
            get { return inner.SynchronizingObject; }
            set { inner.SynchronizingObject = value; }
        }

        /// <summary>
        ///   Gets or sets an <see cref="T:System.ComponentModel.ISite"/> for the <see cref="T:Rothko.FileSystemWatcher"/>.
        /// </summary>
        /// <returns>
        ///   An <see cref="T:System.ComponentModel.ISite"/> for the <see cref="T:Rothko.FileSystemWatcher"/>.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        [AllowNull]
        public ISite Site
        {
            get { return inner.Site; }
            set { inner.Site = value; }
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
            get { return inner.NotifyFilter; }
            set { inner.NotifyFilter = value; }
        }

        /// <summary>
        ///   Begins the initialization of a <see cref="T:Rothko.FileSystemWatcher"/> used on a form or used by
        ///   another component. The initialization occurs at run time.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public void BeginInit()
        {
            inner.BeginInit();
        }

        /// <summary>
        ///   Ends the initialization of a <see cref="T:Rothko.FileSystemWatcher"/> used on a form or used by
        ///   another component. The initialization occurs at run time.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public void EndInit()
        {
            inner.EndInit();
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
            return inner.WaitForChanged(changeType);
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
        public override bool Equals([AllowNull] object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (Object.ReferenceEquals(null, obj))
                return false;

            var other = obj as FileSystemWatcher;
            if (other == null)
                return false;

            return inner.Equals(other.inner);
        }

        /// <summary>Serves as a hash function for a particular type.</summary>
        /// <returns>A hash code for the current <see cref="T:System.Object"/>.</returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            return inner.GetHashCode();
        }
        
        /// <summary>
        ///   Releases all resources used by the <see cref="T:System.ComponentModel.Component"/>.
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
                if (inner != null)
                {
                    UnhookEvents();
                    inner.Dispose();
                }

                var handler = Disposed;
                if (handler != null)
                    handler(this, new EventArgs());
            }
        }

        private void HookEvents()
        {
            inner.Created += CreatedHandler;
            inner.Deleted += DeletedHandler;
            inner.Changed += ChangedHandler;
            inner.Renamed += RenamedHandler;
            inner.Error += ErrorHandler;
        }

        private void UnhookEvents()
        {
            inner.Created -= CreatedHandler;
            inner.Deleted -= DeletedHandler;
            inner.Changed -= ChangedHandler;
            inner.Renamed -= RenamedHandler;
            inner.Error -= ErrorHandler;
        }

        private void CreatedHandler(object sender, System.IO.FileSystemEventArgs e)
        {
            var handler = Created;
            if (handler != null)
                handler(this, e);
        }

        private void DeletedHandler(object sender, System.IO.FileSystemEventArgs e)
        {
            var handler = Deleted;
            if (handler != null)
                handler(this, e);
        }

        private void ChangedHandler(object sender, System.IO.FileSystemEventArgs e)
        {
            var handler = Changed;
            if (handler != null)
                handler(this, e);
        }

        private void RenamedHandler(object sender, System.IO.RenamedEventArgs e)
        {
            var handler = Renamed;
            if (handler != null)
                handler(this, e);
        }

        private void ErrorHandler(object sender, System.IO.ErrorEventArgs e)
        {
            var handler = Error;
            if (handler != null)
                handler(this, e);
        }

        /// <summary>
        ///   Occurs when a file or directory in the specified <see cref="P:Rothko.FileSystemWatcher.Path"/> is
        ///   created.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public event System.IO.FileSystemEventHandler Created;

        /// <summary>
        ///   Occurs when a file or directory in the specified <see cref="P:Rothko.FileSystemWatcher.Path"/> is
        ///   deleted.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public event System.IO.FileSystemEventHandler Deleted;

        /// <summary>
        ///   Occurs when a file or directory in the specified <see cref="P:Rothko.FileSystemWatcher.Path"/> is
        ///   changed.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public event System.IO.FileSystemEventHandler Changed;

        /// <summary>
        ///   Occurs when the instance of <see cref="T:Rothko.FileSystemWatcher"/> is unable to continue
        ///   monitoring changes or when the internal buffer overflows.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public event System.IO.RenamedEventHandler Renamed;

        /// <summary>
        ///   Occurs when the instance of <see cref="T:Rothko.FileSystemWatcher"/> is unable to continue
        ///   monitoring changes or when the internal buffer overflows.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public event System.IO.ErrorEventHandler Error;

        /// <summary>
        ///   Occurs when the component is disposed by a call to the <see cref="M:System.ComponentModel.Component.Dispose"/>
        ///   method.
        /// </summary>
        public event EventHandler Disposed;
    }
}
