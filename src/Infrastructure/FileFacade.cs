using System.ComponentModel.Composition;
using System.IO;

namespace Rothko
{
    [Export(typeof(IFileFacade))]
    public class FileFacade : IFileFacade
    {
        public void WriteAllText(string path, string contents)
        {
            File.WriteAllText(path, contents);
        }
    }
}
