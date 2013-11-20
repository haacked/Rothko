using System.IO;

namespace Rothko
{
    public class FileFacade : IFilesFacade
    {
        public void WriteAllText(string path, string contents)
        {
            File.WriteAllText(path, contents);
        }
    }
}
