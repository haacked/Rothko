using System;
using System.IO;
using System.Runtime.Serialization;

namespace Rothko
{
    public interface IFileSystemInfo : ISerializable
    {
        FileAttributes Attributes { get; set; }

        DateTime CreationTime { get; set; }

        DateTime CreationTimeUtc { get; set; }

        bool Exists { get; }

        string Extension { get; }

        string FullName { get; }

        DateTime LastAccessTime { get; set; }

        DateTime LastAccessTimeUtc { get; set; }

        DateTime LastWriteTime { get; set; }

        DateTime LastWriteTimeUtc { get; set; }

        string Name { get; }

        void Delete();

        void Refresh();
    }
}