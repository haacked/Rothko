using System.IO;
using System.IO.MemoryMappedFiles;

namespace Rothko
{
    public sealed class MemoryMappedFileWrapper : IMemoryMappedFile
    {
        private readonly MemoryMappedFile innerFile;

        public MemoryMappedFileWrapper(MemoryMappedFile innerFile)
        {
            this.innerFile = innerFile;
        }

        public Stream CreateViewStream()
        {
            return innerFile.CreateViewStream();
        }

        public Stream CreateViewStream(long offset, long size)
        {
            return innerFile.CreateViewStream(offset, size);
        }

        public Stream CreateViewStream(long offset, long size, MemoryMappedFileAccess access)
        {
            return innerFile.CreateViewStream(offset, size, access);
        }

        public void Dispose()
        {
            var file = innerFile;
            if (file != null)
                file.Dispose();
        }
    }
}