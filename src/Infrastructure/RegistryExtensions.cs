using System;

namespace Rothko
{
    public static class RegistryExtensions
    {
        public static bool ValueExistsAtSubKey(this IRegistryKey key, string subkey, string value)
        {
            if (subkey.Length == 0) throw new ArgumentException("The 'subkey' should not be empty", "subkey");

            using (var k = key.OpenSubKey(subkey))
            {
                if (k == null) return false;
                // Gets the unnamed value.
                return (string)k.GetValue(string.Empty) == value;
            }
        }
    }
}
