using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Rothko
{
    internal static class EnumerableExtensions
    {
        public static IDictionary<TKey, TValue> ToGenericDictionary<TKey, TValue>(this IDictionary dictionary)
        {
            return dictionary.Keys.Cast<TKey>().ToDictionary(key => key, key => (TValue) dictionary[key]);
        }
    }
}