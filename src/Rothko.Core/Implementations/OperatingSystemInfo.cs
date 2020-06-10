using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Rothko.Implementations
{
    /// <summary>
    /// Represents information about an operating system, such as the version and platform identifier. This class
    /// cannot be inherited.
    /// </summary>
    [Serializable]
    public sealed class OperatingSystemInfo : IOperatingSystemInfo
    {
        readonly OperatingSystem _operatingSystem;

        /// <summary>
        /// Initializes a new instance of the <see cref="OperatingSystemInfo"/> class.
        /// </summary>
        public OperatingSystemInfo()
        {
            _operatingSystem = Environment.OSVersion;
        }
        
        /// <summary>
        /// Creates an <see cref="OperatingSystemInfo"/> object that is identical to this instance.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return _operatingSystem.Clone();
        }

        /// <summary>
        /// Populates a <see cref="System.Runtime.Serialization.SerializationInfo"/> object with the data necessary to
        /// deserialize this instance.
        /// </summary>
        /// <param name="info">The object to populate with serialization information.</param>
        /// <param name="context">The place to store and retrieve serialized data. Reserved for future use.</param>
        /// <exception cref="ArgumentNullException">info is null.</exception>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            _operatingSystem.GetObjectData(info, context);
        }

        /// <summary>
        /// Gets a <see cref="PlatformID"/> enumeration value that identifies the operating system platform.
        /// </summary>
        public PlatformID Platform => _operatingSystem.Platform;

        /// <summary>
        /// Gets the service pack version represented by this OperatingSystem object.
        /// </summary>
        public string ServicePack => _operatingSystem.ServicePack;

        /// <summary>
        /// Gets a <see cref="Version"/> object that identifies the operating system.
        /// </summary>
        /// <remarks>
        /// For this to work properly for Windows 8.1 and later, be sure to specify the supported operating systems
        /// https://msdn.microsoft.com/en-us/library/windows/desktop/dn481241(v=vs.85).aspx
        /// </remarks>
        public Version Version => _operatingSystem.Version;

        /// <summary>
        /// Gets the concatenated string representation of the platform identifier, version, and service pack that are 
        /// currently installed on the operating system.
        /// </summary>
        public string VersionString => _operatingSystem.VersionString;

        /// <summary>
        /// Converts the value of this <see cref="OperatingSystemInfo"/> object to its equivalent string representation.
        /// </summary>
        /// <returns>The commercial name of the running operating system.</returns>
        [SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations"
            , Justification="We're following the contract of the base implementation here for better or worse.")]
        public override string ToString()
        {
            return _operatingSystem.ToString();
        }
    }
}
