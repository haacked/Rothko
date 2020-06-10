﻿using Rothko.IO;
 using Rothko.IO.Implementations;

namespace Rothko.Implementations
{
    public class OperatingSystemFacade : IOperatingSystem
    {
        public OperatingSystemFacade()
        {
            Directory = new DirectoryFacade();
            Environment = new Environment();
            File = new FileFacade();
        }

        public IDirectoryFacade Directory { get; private set; }
        public IEnvironment Environment { get; private set; }
        public IFileFacade File { get; private set; }
    }
}
