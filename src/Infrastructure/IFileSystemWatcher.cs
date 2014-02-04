using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Rothko
{
    public interface IFileSystemWatcher : IDisposable, IComponent, ISupportInitialize
    {
        bool EnableRaisingEvents { get; set; }

        string Path { get; set; }

        string Filter { get; set; }

        bool IncludeSubdirectories { get; set; }

        int InternalBufferSize { get; set; }

        ISynchronizeInvoke SynchronizingObject { get; set; }

        System.IO.NotifyFilters NotifyFilter { get; set; }

        System.IO.WaitForChangedResult WaitForChanged(System.IO.WatcherChangeTypes changeType);

        event System.IO.FileSystemEventHandler Created;

        event System.IO.FileSystemEventHandler Deleted;

        event System.IO.FileSystemEventHandler Changed;

        event System.IO.RenamedEventHandler Renamed;

        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords",
            MessageId = "Error", Justification = "It's what it's called in the original!")]
        event System.IO.ErrorEventHandler Error;
    }
}
