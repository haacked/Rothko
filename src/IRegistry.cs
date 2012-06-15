using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace Rothko
{
    public interface IRegistry
    {
        IRegistryKey ClassesRoot { get; }

        IRegistryKey CurrentConfig { get; }

        IRegistryKey CurrentUser { get; }

        IRegistryKey LocalMachine { get; }

        IRegistryKey PerformanceData { get; }

        IRegistryKey Users { get; }

        object GetValue(string keyName, string valueName, object defaultValue);

        void SetValue(string keyName, string valueName, object value);

        void SetValue(string keyName, string valueName, object value, RegistryValueKind valueKind);

        // Formerly static methods of RegistryKey
        IRegistryKey FromHandle(SafeRegistryHandle handle);

        IRegistryKey FromHandle(SafeRegistryHandle handle, RegistryView view);

        IRegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view);

        IRegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName);

        IRegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName, RegistryView view);
    }
}