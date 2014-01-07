using System;
using System.Runtime.Serialization;

namespace Rothko
{
    public class OperatingSystem : IOperatingSystem
    {
        readonly System.OperatingSystem _operatingSystem;

        public OperatingSystem(System.OperatingSystem operatingSystem)
        {
            _operatingSystem = operatingSystem;
        }

        public object Clone()
        {
            return _operatingSystem.Clone();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            _operatingSystem.GetObjectData(info, context);
        }

        public PlatformID Platform
        {
            get { return _operatingSystem.Platform; }
        }

        public string ServicePack
        {
            get { return _operatingSystem.ServicePack; }
        }

        public Version Version
        {
            get { return _operatingSystem.Version; }
        }

        public string VersionString
        {
            get { return _operatingSystem.VersionString; }
        }
    }
}
