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
            throw new System.NotImplementedException();
        }

        public Stream CreateViewStream(long offset, long size, MemoryMappedFileAccess access)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            var file = innerFile;
            if (file != null)
                file.Dispose();
        }
    }
}