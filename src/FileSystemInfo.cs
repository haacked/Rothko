using System;

namespace Rothko
{
    public class FileSystemInfo : IFileSystemInfo
    {
        readonly System.IO.FileSystemInfo inner;

        public FileSystemInfo(System.IO.FileSystemInfo inner)
        {
            this.inner = inner;
        }

        public System.IO.FileAttributes Attributes
        {
            get
            {
                return inner.Attributes;
            }
            set
            {
                inner.Attributes = value;
            }
        }

        public DateTime CreationTime
        {
            get
            {
                return inner.CreationTime;
            }
            set
            {
                inner.CreationTime = value;
            }
        }

        public DateTime CreationTimeUtc
        {
            get
            {
                return inner.CreationTimeUtc;
            }
            set
            {
                inner.CreationTimeUtc = value;
            }
        }

        public bool Exists
        {
            get { return inner.Exists; }
        }

        public string Extension
        {
            get { return inner.Extension; }
        }

        public string FullName
        {
            get { return inner.FullName; }
        }

        public DateTime LastAccessTime
        {
            get
            {
                return inner.LastAccessTime;
            }
            set
            {
                inner.LastAccessTime = value;
            }
        }

        public DateTime LastAccessTimeUtc
        {
            get
            {
                return inner.LastAccessTimeUtc;
            }
            set
            {
                inner.LastAccessTimeUtc = value;
            }
        }

        public DateTime LastWriteTime
        {
            get
            {
                return inner.LastWriteTime;
            }
            set
            {
                inner.LastWriteTime = value;
            }
        }

        public DateTime LastWriteTimeUtc
        {
            get
            {
                return inner.LastWriteTimeUtc;
            }
            set
            {
                inner.LastWriteTimeUtc = value;
            }
        }

        public string Name
        {
            get { return inner.Name; }
        }

        public void Delete()
        {
            inner.Delete();
        }

        public void Refresh()
        {
            inner.Refresh();
        }

        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            inner.GetObjectData(info, context);
        }
    }
}
