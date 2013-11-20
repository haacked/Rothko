using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rothko
{
    public interface IFilesFacade
    {
        void WriteAllText(string path, string contents);
    }
}
