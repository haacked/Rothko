using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Rothko.Implementations
{
    internal static class EnumerableExtensions
    {
        public static IDictionary<TKey, TValue> ToGenericDictionary<TKey, TValue>(this IDictionary dictionary)
        {
            return dictionary.Keys.Cast<TKey>().ToDictionary(key => key, key => (TValue) dictionary[key]);
        }
        
        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> source) where T : class
        {
            return source.Where(item => item != null).Select(item => item!);
        }
    }
}