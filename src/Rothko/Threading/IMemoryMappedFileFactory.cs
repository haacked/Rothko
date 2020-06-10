using System.IO;
using System.IO.MemoryMappedFiles;

namespace Rothko
{
    public interface IMemoryMappedFileFactory
    {
        IMemoryMappedFile OpenExisting(string mapName);
        IMemoryMappedFile OpenExisting(string mapName, MemoryMappedFileRights desiredAccessRights);
        IMemoryMappedFile OpenExisting(string mapName, MemoryMappedFileRights desiredAccessRights, HandleInheritability inheritability);

        IMemoryMappedFile CreateOrOpen(string mapName, long capacity);
        IMemoryMappedFile CreateOrOpen(string mapName, long capacity, MemoryMappedFileAccess access);
        IMemoryMappedFile CreateOrOpen(string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, MemoryMappedFileSecurity memoryMappedFileSecurity, HandleInheritability inheritability);

        IMemoryMappedFile CreateFromFile(string path);
        IMemoryMappedFile CreateFromFile(string path, FileMode mode);
        IMemoryMappedFile CreateFromFile(string path, FileMode mode, string mapName);
        IMemoryMappedFile CreateFromFile(string path, FileMode mode, string mapName, long capacity);
        IMemoryMappedFile CreateFromFile(string path, FileMode mode, string mapName, long capacity, MemoryMappedFileAccess access);
        IMemoryMappedFile CreateFromFile(FileStream fileStream, string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileSecurity memoryMappedFileSecurity, HandleInheritability inheritability, bool leaveOpen);
    }
}
