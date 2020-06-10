using System.IO;
using System.IO.MemoryMappedFiles;

namespace Rothko
{
    public class MemoryMappedFileFactory : IMemoryMappedFileFactory
    {
        public IMemoryMappedFile OpenExisting(string mapName)
        {
            return new MemoryMappedFileWrapper(MemoryMappedFile.OpenExisting(mapName));
        }

        public IMemoryMappedFile OpenExisting(string mapName, MemoryMappedFileRights desiredAccessRights)
        {
            return new MemoryMappedFileWrapper(MemoryMappedFile.OpenExisting(mapName, desiredAccessRights));
        }

        public IMemoryMappedFile OpenExisting(
            string mapName,
            MemoryMappedFileRights desiredAccessRights,
            HandleInheritability inheritability)
        {
            return new MemoryMappedFileWrapper(
                MemoryMappedFile.OpenExisting(mapName, desiredAccessRights, inheritability));
        }

        public IMemoryMappedFile CreateOrOpen(string mapName, long capacity)
        {
            return new MemoryMappedFileWrapper(MemoryMappedFile.CreateOrOpen(mapName, capacity));
        }

        public IMemoryMappedFile CreateOrOpen(string mapName, long capacity, MemoryMappedFileAccess access)
        {
            return new MemoryMappedFileWrapper(MemoryMappedFile.CreateOrOpen(mapName, capacity, access));
        }

        public IMemoryMappedFile CreateOrOpen(
            string mapName,
            long capacity,
            MemoryMappedFileAccess access,
            MemoryMappedFileOptions options,
            MemoryMappedFileSecurity memoryMappedFileSecurity,
            HandleInheritability inheritability)
        {
            return new MemoryMappedFileWrapper(MemoryMappedFile.CreateOrOpen(
                mapName, capacity, access, options, memoryMappedFileSecurity, inheritability));
        }

        public IMemoryMappedFile CreateFromFile(string path)
        {
            return new MemoryMappedFileWrapper(MemoryMappedFile.CreateFromFile(path));
        }

        public IMemoryMappedFile CreateFromFile(string path, FileMode mode)
        {
            return new MemoryMappedFileWrapper(MemoryMappedFile.CreateFromFile(path, mode));
        }

        public IMemoryMappedFile CreateFromFile(string path, FileMode mode, string mapName)
        {
            return new MemoryMappedFileWrapper(MemoryMappedFile.CreateFromFile(path, mode, mapName));
        }

        public IMemoryMappedFile CreateFromFile(string path, FileMode mode, string mapName, long capacity)
        {
            return new MemoryMappedFileWrapper(MemoryMappedFile.CreateFromFile(path, mode, mapName, capacity));
        }

        public IMemoryMappedFile CreateFromFile(
            string path,
            FileMode mode,
            string mapName,
            long capacity,
            MemoryMappedFileAccess access)
        {
            return new MemoryMappedFileWrapper(MemoryMappedFile.CreateFromFile(path, mode, mapName, capacity, access));
        }

        public IMemoryMappedFile CreateFromFile(
            FileStream fileStream,
            string mapName,
            long capacity,
            MemoryMappedFileAccess access,
            MemoryMappedFileSecurity memoryMappedFileSecurity,
            HandleInheritability inheritability,
            bool leaveOpen)
        {
            return new MemoryMappedFileWrapper(MemoryMappedFile.CreateFromFile(
                fileStream,
                mapName,
                capacity,
                access,
                memoryMappedFileSecurity,
                inheritability,
                leaveOpen));
        }
    }
}