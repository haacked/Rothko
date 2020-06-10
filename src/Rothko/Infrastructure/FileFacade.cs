using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Text;

namespace Rothko
{
    public class FileFacade : IFileFacade
    {
        public FileStream Create(string path)
        {
            return File.Create(path);
        }

        public FileStream Create(string path, int bufferSize)
        {
            return File.Create(path, bufferSize);
        }

        public FileStream Create(string path, int bufferSize, FileOptions options)
        {
            return File.Create(path, bufferSize, options);
        }

        public FileStream Create(string path, int bufferSize, FileOptions options, FileSecurity fileSecurity)
        {
            return File.Create(path, bufferSize, options, fileSecurity);
        }

        public bool Exists(string path)
        {
            return File.Exists(path);
        }

        public IFileInfo GetFile(string path)
        {
            return FileInfo.Wrap(new System.IO.FileInfo(path));
        }

        public void WriteAllText(string path, string contents)
        {
            File.WriteAllText(path, contents);
        }

        public void WriteAllText(string path, string contents, Encoding encoding)
        {
            File.WriteAllText(path, contents, encoding);
        }

        public void Copy(string sourceFileName, string destFileName, bool overwrite)
        {
            File.Copy(sourceFileName, destFileName, overwrite);
        }

        public void Move(string sourceFileName, string destFileName)
        {
            File.Move(sourceFileName, destFileName);
        }

        public IEnumerable<string> ReadLines(string path, Encoding encoding)
        {
            return File.ReadLines(path, encoding);
        }

        public string ReadAllText(string path, Encoding encoding)
        {
            return File.ReadAllText(path, encoding);
        }

        public void Delete(string path)
        {
            File.Delete(path);
        }
    }
}
