using System;
using System.Collections.Generic;

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

    public class RandomList
    {
        public static List<int> InitialIntList(int max = 10000)
        {
            Random r = new Random();
            int count = r.Next(1, max);

            List<int> result = new List<int>();
            result.Add(count);
            for (int i = 0; i < count; i++)
            {
                int rnd = r.Next(0, max);
                result.Add(rnd);
            }

            return result;
        }
    }
}
