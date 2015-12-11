using System;
using System.Runtime.Serialization;

namespace Rothko
{
    public interface IOperatingSystemInfo : ICloneable, ISerializable
    {
        /// <summary>
        /// Gets a <see cref="PlatformID"/> enumeration value that identifies the operating system platform.
        /// </summary>
        PlatformID Platform { get; }

        /// <summary>
        /// Gets the service pack version represented by this OperatingSystem object.
        /// </summary>
        string ServicePack { get; }

        /// <summary>
        /// Gets a <see cref="Version"/> object that identifies the operating system.
        /// </summary>
        /// <remarks>
        /// For this to work properly for Windows 8.1 and later, be sure to specify the supported operating systems
        /// https://msdn.microsoft.com/en-us/library/windows/desktop/dn481241(v=vs.85).aspx
        /// </remarks>
        Version Version { get; }

        /// <summary>
        /// Gets the concatenated string representation of the platform identifier, version, and service pack that are 
        /// currently installed on the operating system.
        /// </summary>
        string VersionString { get; }
    }
}