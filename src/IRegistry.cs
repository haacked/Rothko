using Microsoft.Win32;

namespace Rothko
{
    public interface IRegistry
    {
        RegistryKey ClassesRoot { get; }

        RegistryKey CurrentConfig { get; }

        RegistryKey CurrentUser { get; }

        RegistryKey LocalMachine { get; }

        RegistryKey PerformanceData { get; }

        RegistryKey Users { get; }

        object GetValue(string keyName, string valueName, object defaultValue);

        void SetValue(string keyName, string valueName, object value);

        void SetValue(string keyName, string valueName, object value, RegistryValueKind valueKind);
    }
}