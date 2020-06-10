
namespace Rothko
{
    public class Registry : IRegistry
    {
        public IRegistryKey ClassesRoot
        {
            get { return RegistryKey.Wrap(Microsoft.Win32.Registry.ClassesRoot); }
        }

        public IRegistryKey CurrentConfig
        {
            get { return RegistryKey.Wrap(Microsoft.Win32.Registry.CurrentConfig); }
        }

        public IRegistryKey CurrentUser
        {
            get { return RegistryKey.Wrap(Microsoft.Win32.Registry.CurrentUser); }
        }

        public IRegistryKey LocalMachine
        {
            get { return RegistryKey.Wrap(Microsoft.Win32.Registry.LocalMachine); }
        }

        public IRegistryKey PerformanceData
        {
            get { return RegistryKey.Wrap(Microsoft.Win32.Registry.PerformanceData); }
        }

        public IRegistryKey Users
        {
            get { return RegistryKey.Wrap(Microsoft.Win32.Registry.Users); }
        }

        public object GetValue(string keyName, string valueName, object defaultValue)
        {
            return Microsoft.Win32.Registry.GetValue(keyName, valueName, defaultValue);
        }

        public void SetValue(string keyName, string valueName, object value)
        {
            Microsoft.Win32.Registry.SetValue(keyName, valueName, value);
        }

        public void SetValue(string keyName, string valueName, object value, Microsoft.Win32.RegistryValueKind valueKind)
        {
            Microsoft.Win32.Registry.SetValue(keyName, valueName, value, valueKind);
        }

        public IRegistryKey FromHandle(Microsoft.Win32.SafeHandles.SafeRegistryHandle handle)
        {
            return RegistryKey.Wrap(Microsoft.Win32.RegistryKey.FromHandle(handle));
        }

        public IRegistryKey FromHandle(Microsoft.Win32.SafeHandles.SafeRegistryHandle handle, Microsoft.Win32.RegistryView view)
        {
            return RegistryKey.Wrap(Microsoft.Win32.RegistryKey.FromHandle(handle, view));
        }

        public IRegistryKey OpenBaseKey(Microsoft.Win32.RegistryHive hKey, Microsoft.Win32.RegistryView view)
        {
            return RegistryKey.Wrap(Microsoft.Win32.RegistryKey.OpenBaseKey(hKey, view));
        }

        public IRegistryKey OpenRemoteBaseKey(Microsoft.Win32.RegistryHive hKey, string machineName)
        {
            return RegistryKey.Wrap(Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(hKey, machineName));
        }

        public IRegistryKey OpenRemoteBaseKey(Microsoft.Win32.RegistryHive hKey, string machineName, Microsoft.Win32.RegistryView view)
        {
            return RegistryKey.Wrap(Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(hKey, machineName, view));
        }
    }
}
