using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Rothko
{
    public class FileSystemWatcher : MarshalByRefObject, IFileSystemWatcher
    {
        readonly System.IO.FileSystemWatcher inner;

        public FileSystemWatcher()
        {
            inner = new System.IO.FileSystemWatcher();
            HookEvents();
        }

        public FileSystemWatcher(string path)
        {
            inner = new System.IO.FileSystemWatcher(path);
            HookEvents();
        }

        public FileSystemWatcher(string path, string filter)
        {
            inner = new System.IO.FileSystemWatcher(path, filter);
            HookEvents();
        }

        public bool EnableRaisingEvents
        {
            get { return inner.EnableRaisingEvents; }
            set { inner.EnableRaisingEvents = value; }
        }

        public string Path
        {
            get { return inner.Path; }
            set { inner.Path = value; }
        }

        public string Filter
        {
            get { return inner.Filter; }
            set { inner.Filter = value; }
        }

        public bool IncludeSubdirectories
        {
            get { return inner.IncludeSubdirectories; }
            set { inner.IncludeSubdirectories = value; }
        }

        public int InternalBufferSize
        {
            get { return inner.InternalBufferSize; }
            set { inner.InternalBufferSize = value; }
        }

        public ISynchronizeInvoke SynchronizingObject
        {
            get { return inner.SynchronizingObject; }
            set { inner.SynchronizingObject = value; }
        }

        public ISite Site
        {
            get { return inner.Site; }
            set { inner.Site = value; }
        }

        public System.IO.NotifyFilters NotifyFilter
        {
            get { return inner.NotifyFilter; }
            set { inner.NotifyFilter = value; }
        }

        public void BeginInit()
        {
            inner.BeginInit();
        }

        public void EndInit()
        {
            inner.EndInit();
        }

        public System.IO.WaitForChangedResult WaitForChanged(System.IO.WatcherChangeTypes changeType)
        {
            return inner.WaitForChanged(changeType);
        }

        [SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations",
            Justification = "It doesn't!")]
        public override bool Equals(object obj)
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

        public override int GetHashCode()
        {
            return inner.GetHashCode();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (inner != null)
                {
                    UnhookEvents();
                    inner.Dispose();
                }
            }

            var handler = Disposed;
                if (handler != null)
                    handler(this, new EventArgs());
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

        public event System.IO.FileSystemEventHandler Created;

        public event System.IO.FileSystemEventHandler Deleted;

        public event System.IO.FileSystemEventHandler Changed;

        public event System.IO.RenamedEventHandler Renamed;

        public event System.IO.ErrorEventHandler Error;

        public event EventHandler Disposed;
    }
}
