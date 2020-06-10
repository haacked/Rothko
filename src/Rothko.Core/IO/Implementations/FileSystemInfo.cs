using System;
using System.Diagnostics.CodeAnalysis;
 
namespace Rothko.IO.Implementations
{
    public abstract class FileSystemInfo : IFileSystemInfo
    {
        readonly System.IO.FileSystemInfo _inner;

        protected FileSystemInfo(System.IO.FileSystemInfo inner)
        {
            _inner = inner;
        }

        [return: NotNullIfNotNull("fileSystemInfo")]
        internal static IFileSystemInfo? Wrap(System.IO.FileSystemInfo fileSystemInfo)
        {
            if (fileSystemInfo is null) return null;
            if ((fileSystemInfo.Attributes & System.IO.FileAttributes.Directory) == System.IO.FileAttributes.Directory)
            {
                return DirectoryInfo.Wrap((System.IO.DirectoryInfo)fileSystemInfo);
            }

            return FileInfo.Wrap((System.IO.FileInfo)fileSystemInfo);
        }

        public System.IO.FileAttributes Attributes
        {
            get => _inner.Attributes;
            set => _inner.Attributes = value;
        }

        public DateTime CreationTime
        {
            get => _inner.CreationTime;
            set => _inner.CreationTime = value;
        }

        public DateTime CreationTimeUtc
        {
            get => _inner.CreationTimeUtc;
            set => _inner.CreationTimeUtc = value;
        }

        public bool Exists => _inner.Exists;

        public string Extension => _inner.Extension;

        public string FullName => _inner.FullName;

        public DateTime LastAccessTime
        {
            get => _inner.LastAccessTime;
            set => _inner.LastAccessTime = value;
        }

        public DateTime LastAccessTimeUtc
        {
            get => _inner.LastAccessTimeUtc;
            set => _inner.LastAccessTimeUtc = value;
        }

        public DateTime LastWriteTime
        {
            get => _inner.LastWriteTime;
            set => _inner.LastWriteTime = value;
        }

        public DateTime LastWriteTimeUtc
        {
            get => _inner.LastWriteTimeUtc;
            set => _inner.LastWriteTimeUtc = value;
        }

        public string Name => _inner.Name;

        public void Delete()
        {
            _inner.Delete();
        }

        public void Refresh()
        {
            _inner.Refresh();
        }

        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            _inner.GetObjectData(info, context);
        }
    }
}
