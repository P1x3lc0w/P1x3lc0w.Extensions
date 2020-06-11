using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace P1x3lc0w.Extensions
{
    public static class ConcurrentDictionaryExtensions
    {
        public static bool AddOrUpdate<TKey, TValue>(this ConcurrentDictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            bool changed = false;

            dict.AddOrUpdate(
                    key,
                    (key) =>
                    {
                        changed = true;
                        return value;
                    },
                    (key, oldValue) =>
                    {
                        changed = !EqualityComparer<TValue>.Default.Equals(oldValue, value);
                        return value;
                    }
                );

            return changed;
        }
    }
}
