using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using Rothko.Win32;

namespace Rothko
{
    /// <summary>
    /// Represents information about an operating system, such as the version and platform identifier. This class cannot be inherited.
    /// </summary>
    public sealed class OperatingSystemInfo : IOperatingSystemInfo
    {
        #region PRODUCT
        private const int PRODUCT_UNDEFINED = 0x00000000;
        private const int PRODUCT_ULTIMATE = 0x00000001;
        private const int PRODUCT_HOME_BASIC = 0x00000002;
        private const int PRODUCT_HOME_PREMIUM = 0x00000003;
        private const int PRODUCT_ENTERPRISE = 0x00000004;
        private const int PRODUCT_HOME_BASIC_N = 0x00000005;
        private const int PRODUCT_BUSINESS = 0x00000006;
        private const int PRODUCT_STANDARD_SERVER = 0x00000007;
        private const int PRODUCT_DATACENTER_SERVER = 0x00000008;
        private const int PRODUCT_SMALLBUSINESS_SERVER = 0x00000009;
        private const int PRODUCT_ENTERPRISE_SERVER = 0x0000000A;
        private const int PRODUCT_STARTER = 0x0000000B;
        private const int PRODUCT_DATACENTER_SERVER_CORE = 0x0000000C;
        private const int PRODUCT_STANDARD_SERVER_CORE = 0x0000000D;
        private const int PRODUCT_ENTERPRISE_SERVER_CORE = 0x0000000E;
        private const int PRODUCT_ENTERPRISE_SERVER_IA64 = 0x0000000F;
        private const int PRODUCT_BUSINESS_N = 0x00000010;
        private const int PRODUCT_WEB_SERVER = 0x00000011;
        private const int PRODUCT_CLUSTER_SERVER = 0x00000012;
        private const int PRODUCT_STORAGE_EXPRESS_SERVER = 0x00000014;
        private const int PRODUCT_STORAGE_STANDARD_SERVER = 0x00000015;
        private const int PRODUCT_STORAGE_WORKGROUP_SERVER = 0x00000016;
        private const int PRODUCT_STORAGE_ENTERPRISE_SERVER = 0x00000017;
        private const int PRODUCT_SERVER_FOR_SMALLBUSINESS = 0x00000018;
        private const int PRODUCT_SMALLBUSINESS_SERVER_PREMIUM = 0x00000019;
        private const int PRODUCT_HOME_PREMIUM_N = 0x0000001A;
        private const int PRODUCT_ENTERPRISE_N = 0x0000001B;
        private const int PRODUCT_ULTIMATE_N = 0x0000001C;
        private const int PRODUCT_WEB_SERVER_CORE = 0x0000001D;
        private const int PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT = 0x0000001E;
        private const int PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY = 0x0000001F;
        private const int PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING = 0x00000020;
        private const int PRODUCT_SERVER_FOUNDATION = 0x00000021;
        private const int PRODUCT_HOME_PREMIUM_SERVER = 0x00000022;
        private const int PRODUCT_SERVER_FOR_SMALLBUSINESS_V = 0x00000023;
        private const int PRODUCT_STANDARD_SERVER_V = 0x00000024;
        private const int PRODUCT_DATACENTER_SERVER_V = 0x00000025;
        private const int PRODUCT_ENTERPRISE_SERVER_V = 0x00000026;
        private const int PRODUCT_DATACENTER_SERVER_CORE_V = 0x00000027;
        private const int PRODUCT_STANDARD_SERVER_CORE_V = 0x00000028;
        private const int PRODUCT_ENTERPRISE_SERVER_CORE_V = 0x00000029;
        private const int PRODUCT_HYPERV = 0x0000002A;
        private const int PRODUCT_STORAGE_EXPRESS_SERVER_CORE = 0x0000002B;
        private const int PRODUCT_STORAGE_STANDARD_SERVER_CORE = 0x0000002C;
        private const int PRODUCT_STORAGE_WORKGROUP_SERVER_CORE = 0x0000002D;
        private const int PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE = 0x0000002E;
        private const int PRODUCT_STARTER_N = 0x0000002F;
        private const int PRODUCT_PROFESSIONAL = 0x00000030;
        private const int PRODUCT_PROFESSIONAL_N = 0x00000031;
        private const int PRODUCT_SB_SOLUTION_SERVER = 0x00000032;
        private const int PRODUCT_SERVER_FOR_SB_SOLUTIONS = 0x00000033;
        private const int PRODUCT_STANDARD_SERVER_SOLUTIONS = 0x00000034;
        private const int PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE = 0x00000035;
        private const int PRODUCT_SB_SOLUTION_SERVER_EM = 0x00000036;
        private const int PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM = 0x00000037;
        private const int PRODUCT_SOLUTION_EMBEDDEDSERVER = 0x00000038;
        private const int PRODUCT_SOLUTION_EMBEDDEDSERVER_CORE = 0x00000039;
        private const int PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT = 0x0000003B;
        private const int PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL = 0x0000003C;
        private const int PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC = 0x0000003D;
        private const int PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC = 0x0000003E;
        private const int PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE = 0x0000003F;
        private const int PRODUCT_CLUSTER_SERVER_V = 0x00000040;
        private const int PRODUCT_EMBEDDED = 0x00000041;
        private const int PRODUCT_STARTER_E = 0x00000042;
        private const int PRODUCT_HOME_BASIC_E = 0x00000043;
        private const int PRODUCT_HOME_PREMIUM_E = 0x00000044;
        private const int PRODUCT_PROFESSIONAL_E = 0x00000045;
        private const int PRODUCT_ENTERPRISE_E = 0x00000046;
        private const int PRODUCT_ULTIMATE_E = 0x00000047;
        #endregion PRODUCT

        #region VERSIONS
        private const int VER_NT_WORKSTATION = 1;
        private const int VER_NT_SERVER = 3;
        private const int VER_SUITE_ENTERPRISE = 2;
        private const int VER_SUITE_DATACENTER = 128;
        private const int VER_SUITE_PERSONAL = 512;
        private const int VER_SUITE_BLADE = 1024;
        #endregion VERSIONS

        readonly OperatingSystem _operatingSystem;
        private string _edition;
        private string _name;

        /// <summary>
        /// Initializes a new instance of the <see cref="OperatingSystemInfo"/> class.
        /// </summary>
        public OperatingSystemInfo()
        {
            _operatingSystem = System.Environment.OSVersion;
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
        /// Populates a <see cref="System.Runtime.Serialization.SerializationInfo"/> object with the data necessary to deserialize this instance.
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
        public PlatformID Platform
        {
            get { return _operatingSystem.Platform; }
        }

        /// <summary>
        /// Gets the service pack version represented by this OperatingSystem object.
        /// </summary>
        public string ServicePack
        {
            get { return _operatingSystem.ServicePack; }
        }

        /// <summary>
        /// Gets a <see cref="Version"/> object that identifies the operating system.
        /// </summary>
        public Version Version
        {
            get { return _operatingSystem.Version; }
        }

        /// <summary>
        /// Gets the concatenated string representation of the platform identifier, version, and service pack that are currently installed on the operating system.
        /// </summary>
        public string VersionString
        {
            get { return _operatingSystem.VersionString; }
        }

        /// <summary>
        /// Gets the edition of the operating system running on this computer.
        /// </summary>
        public string Edition
        {
            get
            {
                if (_edition != null)
                    return _edition;

                string edition = String.Empty;
                OsVersionInfoEx osVersion = new OsVersionInfoEx();

                if (NativeMethods.GetVersionEx(osVersion))
                {
                    switch (osVersion.MajorVersion)
                    {
                        case 4:
                            edition = GetEditionMajorVersionFour(osVersion.ProductType, osVersion.SuiteMask);
                            break;
                        case 5:
                            edition = GetEditionMajorVersionFive(osVersion.MinorVersion, osVersion.ProductType, osVersion.SuiteMask);
                            break;
                        case 6:
                            edition = GetEditionMajorVersionSix(osVersion);
                            break;
                    }
                }

                _edition = edition;
                return edition;
            }
        }

        /// <summary>
        /// Gets the name of the operating system running on this computer.
        /// </summary>
        public string Name
        {
            get
            {
                if (_name != null)
                    return _name;

                string name = "unknown";

                OsVersionInfoEx osVersion = new OsVersionInfoEx();

                if (NativeMethods.GetVersionEx(osVersion))
                {
                    switch (_operatingSystem.Platform)
                    {
                        case PlatformID.Win32Windows:
                            {
                                if (osVersion.MajorVersion == 4)
                                {
                                    name = GetWin32VersionName(osVersion.MinorVersion, osVersion.CSDVersion);
                                }

                                break;
                            }
                        case PlatformID.Win32NT:
                            {
                                name = GetWin32NTVersionName(osVersion.MajorVersion, osVersion.MinorVersion, osVersion.ProductType);
                            }

                            break;
                    }
                }

                _name = name;
                return name;
            }
        }

        /// <summary>
        /// Converts the value of this <see cref="OperatingSystemInfo"/> object to its equivalent string representation.
        /// </summary>
        /// <returns>The commercial name of the running operating system.</returns>
        [SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Justification = "The violation is caused by an exception declaration instead of a thrown exception.")]
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} {1} with {2}", Name, Edition, ServicePack);
        }

        private static string GetWin32VersionName(int minorVersion, string csdVersion)
        {
            switch (minorVersion)
            {
                case 0:
                    if (csdVersion == "B" || csdVersion == "C")
                    {
                        return "Windows 95 OSR2";
                    }

                    return "Windows 95";
                case 10:
                    if (csdVersion == "A")
                    {
                        return "Windows 98 Second Edition";
                    }

                    return "Windows 98";

                case 90:
                    return "Windows Me";

                default:
                    return string.Empty;
            }
        }

        private static string GetWin32NTVersionName(int majorVersion, int minorVersion, int productType)
        {
            switch (majorVersion)
            {
                case 3:
                    return "Windows NT 3.51";
                case 4:
                    switch (productType)
                    {
                        case 1:
                            return "Windows NT 4.0";
                        case 3:
                            return "Windows NT 4.0 Server";
                    }

                    return string.Empty;
                case 5:
                    switch (minorVersion)
                    {
                        case 0:
                            return "Windows 2000";
                        case 1:
                            return "Windows XP";
                        case 2:
                            return "Windows Server 2003";
                    }

                    return string.Empty;
                case 6:
                    return GetVersionSixOsName(minorVersion, productType);
                default:
                    return string.Empty;
            }
        }

        private static string GetVersionSixOsName(int minorVersion, int productType)
        {
            switch (minorVersion)
            {
                case 0:
                    switch (productType)
                    {
                        case 1:
                            return "Windows Vista";
                        case 3:
                            return "Windows Server 2008";
                    }

                    return string.Empty;
                case 1:
                    switch (productType)
                    {
                        case 1:
                            return "Windows 7";
                        case 3:
                            return "Windows Server 2008 R2";
                    }

                    return string.Empty;
                case 2:
                    switch (productType)
                    {
                        case 1:
                            return "Windows 8";
                        case 3:
                            return "Windows Server 2012";
                    }

                    return string.Empty;
                case 3:
                    switch (productType)
                    {
                        case 1:
                            return "Windows 8.1";
                        case 3:
                            return "Windows Server 2012 R2";
                    }

                    return string.Empty;

                default:
                    return string.Empty;
            }
        }

        private static string GetEditionMajorVersionFour(byte productType, short suiteMask)
        {
            if (productType == VER_NT_WORKSTATION)
            {
                // Windows NT 4.0 Workstation
                return "Workstation";
            }

            if (productType == VER_NT_SERVER)
            {
                if ((suiteMask & VER_SUITE_ENTERPRISE) != 0)
                {
                    // Windows NT 4.0 Server Enterprise
                    return "Enterprise Server";
                }

                // Windows NT 4.0 Server
                return "Standard Server";
            }

            return string.Empty;
        }

        private static string GetEditionMajorVersionFive(int minorVersion, byte productType, short suiteMask)
        {
            if (productType == VER_NT_WORKSTATION)
            {
                if ((suiteMask & VER_SUITE_PERSONAL) != 0)
                {
                    return "Home";
                }

                if (NativeMethods.GetSystemMetrics(SystemMetric.SM_TABLETPC) == 0)
                {
                    return "Professional";
                }

                return "Tablet PC Edition";
            }


            if (productType == VER_NT_SERVER)
            {
                if (minorVersion == 0)
                {
                    if ((suiteMask & VER_SUITE_DATACENTER) != 0)
                    {
                        // Windows 2000 Datacenter Server
                        return "Datacenter Server";
                    }

                    return (suiteMask & VER_SUITE_ENTERPRISE) != 0 ? "Advanced Server" : "Server";
                }


                if ((suiteMask & VER_SUITE_DATACENTER) != 0)
                {
                    // Windows Server 2003 Datacenter Edition
                    return "Datacenter";
                }

                if ((suiteMask & VER_SUITE_ENTERPRISE) != 0)
                {
                    // Windows Server 2003 Enterprise Edition
                    return "Enterprise";
                }

                return (suiteMask & VER_SUITE_BLADE) != 0 ? "Web Edition" : "Standard";
            }

            return string.Empty;
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity",
            Justification = "It can't be helped")]
        private static string GetEditionMajorVersionSix(OsVersionInfoEx osVersion)
        {
            int ed;
            if (NativeMethods.GetProductInfo(osVersion.MajorVersion, osVersion.MinorVersion,
                osVersion.ServicePackMajor, osVersion.ServicePackMinor,
                out ed))
            {
                switch (ed)
                {
                    case PRODUCT_BUSINESS:
                        return "Business";
                    case PRODUCT_BUSINESS_N:
                        return "Business N";
                    case PRODUCT_CLUSTER_SERVER:
                        return "HPC Edition";
                    case PRODUCT_CLUSTER_SERVER_V:
                        return "HPC Edition without Hyper-V";
                    case PRODUCT_DATACENTER_SERVER:
                        return "Datacenter Server";
                    case PRODUCT_DATACENTER_SERVER_CORE:
                        return "Datacenter Server (core installation)";
                    case PRODUCT_DATACENTER_SERVER_V:
                        return "Datacenter Server without Hyper-V";
                    case PRODUCT_DATACENTER_SERVER_CORE_V:
                        return "Datacenter Server without Hyper-V (core installation)";
                    case PRODUCT_EMBEDDED:
                        return "Embedded";
                    case PRODUCT_ENTERPRISE:
                        return "Enterprise";
                    case PRODUCT_ENTERPRISE_N:
                        return "Enterprise N";
                    case PRODUCT_ENTERPRISE_E:
                        return "Enterprise E";
                    case PRODUCT_ENTERPRISE_SERVER:
                        return "Enterprise Server";
                    case PRODUCT_ENTERPRISE_SERVER_CORE:
                        return "Enterprise Server (core installation)";
                    case PRODUCT_ENTERPRISE_SERVER_CORE_V:
                        return "Enterprise Server without Hyper-V (core installation)";
                    case PRODUCT_ENTERPRISE_SERVER_IA64:
                        return "Enterprise Server for Itanium-based Systems";
                    case PRODUCT_ENTERPRISE_SERVER_V:
                        return "Enterprise Server without Hyper-V";
                    case PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT:
                        return "Essential Business Server MGMT";
                    case PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL:
                        return "Essential Business Server ADDL";
                    case PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC:
                        return "Essential Business Server MGMTSVC";
                    case PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC:
                        return "Essential Business Server ADDLSVC";
                    case PRODUCT_HOME_BASIC:
                        return "Home Basic";
                    case PRODUCT_HOME_BASIC_N:
                        return "Home Basic N";
                    case PRODUCT_HOME_BASIC_E:
                        return "Home Basic E";
                    case PRODUCT_HOME_PREMIUM:
                        return "Home Premium";
                    case PRODUCT_HOME_PREMIUM_N:
                        return "Home Premium N";
                    case PRODUCT_HOME_PREMIUM_E:
                        return "Home Premium E";
                    case PRODUCT_HOME_PREMIUM_SERVER:
                        return "Home Premium Server";
                    case PRODUCT_HYPERV:
                        return "Microsoft Hyper-V Server";
                    case PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT:
                        return "Windows Essential Business Management Server";
                    case PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING:
                        return "Windows Essential Business Messaging Server";
                    case PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY:
                        return "Windows Essential Business Security Server";
                    case PRODUCT_PROFESSIONAL:
                        return "Professional";
                    case PRODUCT_PROFESSIONAL_N:
                        return "Professional N";
                    case PRODUCT_PROFESSIONAL_E:
                        return "Professional E";
                    case PRODUCT_SB_SOLUTION_SERVER:
                        return "SB Solution Server";
                    case PRODUCT_SB_SOLUTION_SERVER_EM:
                        return "SB Solution Server EM";
                    case PRODUCT_SERVER_FOR_SB_SOLUTIONS:
                        return "Server for SB Solutions";
                    case PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM:
                        return "Server for SB Solutions EM";
                    case PRODUCT_SERVER_FOR_SMALLBUSINESS:
                        return "Windows Essential Server Solutions";
                    case PRODUCT_SERVER_FOR_SMALLBUSINESS_V:
                        return "Windows Essential Server Solutions without Hyper-V";
                    case PRODUCT_SERVER_FOUNDATION:
                        return "Server Foundation";
                    case PRODUCT_SMALLBUSINESS_SERVER:
                        return "Windows Small Business Server";
                    case PRODUCT_SMALLBUSINESS_SERVER_PREMIUM:
                        return "Windows Small Business Server Premium";
                    case PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE:
                        return "Windows Small Business Server Premium (core installation)";
                    case PRODUCT_SOLUTION_EMBEDDEDSERVER:
                        return "Solution Embedded Server";
                    case PRODUCT_SOLUTION_EMBEDDEDSERVER_CORE:
                        return "Solution Embedded Server (core installation)";
                    case PRODUCT_STANDARD_SERVER:
                        return "Standard Server";
                    case PRODUCT_STANDARD_SERVER_CORE:
                        return "Standard Server (core installation)";
                    case PRODUCT_STANDARD_SERVER_SOLUTIONS:
                        return "Standard Server Solutions";
                    case PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE:
                        return "Standard Server Solutions (core installation)";
                    case PRODUCT_STANDARD_SERVER_CORE_V:
                        return "Standard Server without Hyper-V (core installation)";
                    case PRODUCT_STANDARD_SERVER_V:
                        return "Standard Server without Hyper-V";
                    case PRODUCT_STARTER:
                        return "Starter";
                    case PRODUCT_STARTER_N:
                        return "Starter N";
                    case PRODUCT_STARTER_E:
                        return "Starter E";
                    case PRODUCT_STORAGE_ENTERPRISE_SERVER:
                        return "Enterprise Storage Server";
                    case PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE:
                        return "Enterprise Storage Server (core installation)";
                    case PRODUCT_STORAGE_EXPRESS_SERVER:
                        return "Express Storage Server";
                    case PRODUCT_STORAGE_EXPRESS_SERVER_CORE:
                        return "Express Storage Server (core installation)";
                    case PRODUCT_STORAGE_STANDARD_SERVER:
                        return "Standard Storage Server";
                    case PRODUCT_STORAGE_STANDARD_SERVER_CORE:
                        return "Standard Storage Server (core installation)";
                    case PRODUCT_STORAGE_WORKGROUP_SERVER:
                        return "Workgroup Storage Server";
                    case PRODUCT_STORAGE_WORKGROUP_SERVER_CORE:
                        return "Workgroup Storage Server (core installation)";
                    case PRODUCT_UNDEFINED:
                        return "Unknown product";
                    case PRODUCT_ULTIMATE:
                        return "Ultimate";
                    case PRODUCT_ULTIMATE_N:
                        return "Ultimate N";
                    case PRODUCT_ULTIMATE_E:
                        return "Ultimate E";
                    case PRODUCT_WEB_SERVER:
                        return "Web Server";
                    case PRODUCT_WEB_SERVER_CORE:
                        return "Web Server (core installation)";
                }
            }

            return string.Empty;
        }
    }
}
