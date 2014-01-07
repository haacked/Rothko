using System;
using System.IO;
using System.IO.MemoryMappedFiles;

namespace Rothko
{
    public interface IMemoryMappedFile : IDisposable
    {
        Stream CreateViewStream();
        Stream CreateViewStream(long offset, long size);
        Stream CreateViewStream(long offset, long size, MemoryMappedFileAccess access);
    }
}