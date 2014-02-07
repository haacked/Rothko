using System.IO;

namespace Rothko
{
    public class FileFacade : IFileFacade
    {
        public void WriteAllText(string path, string contents)
        {
            File.WriteAllText(path, contents);
        }
    }
}
