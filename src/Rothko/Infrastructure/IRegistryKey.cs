using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace Rothko
{
    public interface IRegistryKey : IDisposable
    {
        SafeRegistryHandle Handle { get; }

        string Name { get; }

        int SubKeyCount { get; }

        int ValueCount { get; }

        RegistryView View { get; }

        void Close();

        IRegistryKey CreateSubKey(string subkey);

        IRegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck);

        IRegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck,
                                  RegistryOptions options);

        IRegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck,
                                  RegistrySecurity registrySecurity);

        IRegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck,
                                  RegistryOptions registryOptions, RegistrySecurity registrySecurity);

        void DeleteSubKey(string subkey);

        void DeleteSubKey(string subkey, bool throwOnMissingSubKey);

        void DeleteSubKeyTree(string subkey);

        void DeleteSubKeyTree(string subkey, bool throwOnMissingSubKey);

        void DeleteValue(string name);

        void DeleteValue(string name, bool throwOnMissingValue);

        void Flush();

        RegistrySecurity GetAccessControl();

        RegistrySecurity GetAccessControl(AccessControlSections includeSections);

        IReadOnlyList<string> GetSubKeyNames();

        object GetValue(string name);

        object GetValue(string name, object defaultValue);

        object GetValue(string name, object defaultValue, RegistryValueOptions options);

        RegistryValueKind GetValueKind(string name);

        IReadOnlyList<string> GetValueNames();

        IRegistryKey OpenSubKey(string name);

        IRegistryKey OpenSubKey(string name, bool writable);

        IRegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck);

        IRegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck, RegistryRights rights);

        void SetAccessControl(RegistrySecurity registrySecurity);

        void SetValue(string name, object value);

        void SetValue(string name, object value, RegistryValueKind valueKind);
    }
}