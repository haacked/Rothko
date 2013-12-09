
namespace Rothko
{
    public class RegistryKey : IRegistryKey
    {
        Microsoft.Win32.RegistryKey inner;

        public RegistryKey(Microsoft.Win32.RegistryKey inner)
        {
            this.inner = inner;
        }

        internal static IRegistryKey Wrap(Microsoft.Win32.RegistryKey inner)
        {
            return new RegistryKey(inner);
        }

        public Microsoft.Win32.SafeHandles.SafeRegistryHandle Handle
        {
            get { return inner.Handle; }
        }

        public string Name
        {
            get { return inner.Name; }
        }

        public int SubKeyCount
        {
            get { return inner.SubKeyCount; }
        }

        public int ValueCount
        {
            get { return inner.ValueCount; }
        }

        public Microsoft.Win32.RegistryView View
        {
            get { return inner.View; }
        }

        public void Close()
        {
            inner.Close();
        }

        public IRegistryKey CreateSubKey(string subkey)
        {
            return Wrap(inner.CreateSubKey(subkey));
        }

        public IRegistryKey CreateSubKey(string subkey, Microsoft.Win32.RegistryKeyPermissionCheck permissionCheck)
        {
            return Wrap(inner.CreateSubKey(subkey, permissionCheck));
        }

        public IRegistryKey CreateSubKey(string subkey, Microsoft.Win32.RegistryKeyPermissionCheck permissionCheck, Microsoft.Win32.RegistryOptions options)
        {
            return Wrap(inner.CreateSubKey(subkey, permissionCheck, options));
        }

        public IRegistryKey CreateSubKey(string subkey, Microsoft.Win32.RegistryKeyPermissionCheck permissionCheck, System.Security.AccessControl.RegistrySecurity registrySecurity)
        {
            return Wrap(inner.CreateSubKey(subkey, permissionCheck, registrySecurity));
        }

        public IRegistryKey CreateSubKey(string subkey, Microsoft.Win32.RegistryKeyPermissionCheck permissionCheck, Microsoft.Win32.RegistryOptions registryOptions, System.Security.AccessControl.RegistrySecurity registrySecurity)
        {
            return Wrap(inner.CreateSubKey(subkey, permissionCheck, registryOptions, registrySecurity));
        }

        public void DeleteSubKey(string subkey)
        {
            inner.DeleteSubKey(subkey);
        }

        public void DeleteSubKey(string subkey, bool throwOnMissingSubKey)
        {
            inner.DeleteSubKey(subkey, throwOnMissingSubKey);
        }

        public void DeleteSubKeyTree(string subkey)
        {
            inner.DeleteSubKeyTree(subkey);
        }

        public void DeleteSubKeyTree(string subkey, bool throwOnMissingSubKey)
        {
            inner.DeleteSubKeyTree(subkey, throwOnMissingSubKey);
        }

        public void DeleteValue(string name)
        {
            inner.DeleteValue(name);
        }

        public void DeleteValue(string name, bool throwOnMissingValue)
        {
            inner.DeleteValue(name, throwOnMissingValue);
        }

        public void Dispose()
        {
            inner.Dispose();
        }

        public void Flush()
        {
            inner.Flush();
        }

        public System.Security.AccessControl.RegistrySecurity GetAccessControl()
        {
            return inner.GetAccessControl();
        }

        public System.Security.AccessControl.RegistrySecurity GetAccessControl(System.Security.AccessControl.AccessControlSections includeSections)
        {
            return inner.GetAccessControl(includeSections);
        }

        public string[] GetSubKeyNames()
        {
            return inner.GetSubKeyNames();
        }

        public object GetValue(string name)
        {
            return inner.GetValue(name);
        }

        public object GetValue(string name, object defaultValue)
        {
            return inner.GetValue(name, defaultValue);
        }

        public object GetValue(string name, object defaultValue, Microsoft.Win32.RegistryValueOptions options)
        {
            return inner.GetValue(name, defaultValue, options);
        }

        public Microsoft.Win32.RegistryValueKind GetValueKind(string name)
        {
            return inner.GetValueKind(name);
        }

        public string[] GetValueNames()
        {
            return inner.GetValueNames();
        }

        public IRegistryKey OpenSubKey(string name)
        {
            return Wrap(inner.OpenSubKey(name));
        }

        public IRegistryKey OpenSubKey(string name, bool writable)
        {
            return Wrap(inner.OpenSubKey(name, writable));
        }

        public IRegistryKey OpenSubKey(string name, Microsoft.Win32.RegistryKeyPermissionCheck permissionCheck)
        {
            return Wrap(inner.OpenSubKey(name, permissionCheck));
        }

        public IRegistryKey OpenSubKey(string name, Microsoft.Win32.RegistryKeyPermissionCheck permissionCheck, System.Security.AccessControl.RegistryRights rights)
        {
            return Wrap(inner.OpenSubKey(name, permissionCheck, rights));
        }

        public void SetAccessControl(System.Security.AccessControl.RegistrySecurity registrySecurity)
        {
            inner.SetAccessControl(registrySecurity);
        }

        public void SetValue(string name, object value)
        {
            inner.SetValue(name, value);
        }

        public void SetValue(string name, object value, Microsoft.Win32.RegistryValueKind valueKind)
        {
            inner.SetValue(name, value, valueKind);
        }
    }
}
