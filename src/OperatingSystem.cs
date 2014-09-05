using System;
using System.ComponentModel.Composition;
using System.Runtime.Serialization;

namespace Rothko
{
    [Export(typeof(IOperatingSystem))]
    public sealed class OperatingSystem : IOperatingSystem
    {
        readonly System.OperatingSystem operatingSystem;

        public OperatingSystem(System.OperatingSystem operatingSystem)
        {
            this.operatingSystem = operatingSystem;
        }

        public object Clone()
        {
            return operatingSystem.Clone();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            operatingSystem.GetObjectData(info, context);
        }

        public PlatformID Platform
        {
            get { return operatingSystem.Platform; }
        }

        public string ServicePack
        {
            get { return operatingSystem.ServicePack; }
        }

        public Version Version
        {
            get { return operatingSystem.Version; }
        }

        public string VersionString
        {
            get { return operatingSystem.VersionString; }
        }
    }
}
