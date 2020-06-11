using System;
using System.Collections.Generic;

namespace P1x3lc0w.Extensions
{
    public static class ListExtensions
    {
        public static int InsertSort<T>(this IList<T> list, T item, SortOrder sortOrder = SortOrder.ASCENDING) where T : IComparable<T>
        {
            for (int index = 0; index < list.Count; index++)
            {
                if
                (
                    (sortOrder == SortOrder.ASCENDING && list[index].CompareTo(item) >= 0) ||
                    (sortOrder == SortOrder.DESCENDING && list[index].CompareTo(item) <= 0)
                )
                {
                    list.Insert(index, item);
                    return index;
                }
            }

            list.Add(item);
            return list.Count - 1;
        }
    }
}