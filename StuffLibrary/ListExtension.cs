using System;
using System.Collections.Generic;
using System.Text;

namespace StuffLibrary
{
    public static class ListExtension
    {
        public static IList<T> Swap<T>(this IList<T> list, int a, int b)
        {
            T tmp = list[a];
            list[a] = list[b];
            list[b] = tmp;
            return list;
        }
    }
}
