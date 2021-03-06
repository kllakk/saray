﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StuffLibrary
{
    public class RandomList
    {
        public static List<int> InitialIntListFirstCount(int max = 10000)
        {
            Random r = new Random();
            int count = r.Next(1, max);

            List<int> result = new List<int>();
            result.Add(count);

            result.AddRange(InitialIntList(max, count));

            return result;
        }

        public static List<int> InitialIntList(int max = 10000, int count = 10)
        {
            Random r = new Random();
            List<int> result = new List<int>();
            for (int i = 0; i < count; i++)
            {
                int rnd = r.Next(0, max);
                result.Add(rnd);
            }

            return result;
        }
    }
}
