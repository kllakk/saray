using StuffLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = RandomList.InitialIntList(30);

            var result = BubbleSortSimple(A);
            Console.WriteLine(string.Format("A = [{0}], count = {1}, time = {2}", 
                string.Join(", ", result.list), 
                result.count, result.time));

            var result2 = BubbleSortSwappedCheck(A);
            Console.WriteLine(string.Format("A = [{0}], count = {1}, time = {2}",
                string.Join(", ", result2.list), 
                result2.count, result2.time));

            var result3 = BubbleSelectionSort(A);
            Console.WriteLine(string.Format("A = [{0}], count = {1}, time = {2}",
                string.Join(", ", result3.list),
                result3.count, result3.time));

            Console.ReadLine();
        }

        static (List<int> list, int count, long time) BubbleSortSimple(List<int> list)
        {
            List<int> result = new List<int>();
            result.AddRange(list);

            Stopwatch timer = new Stopwatch();
            timer.Start();
            
            int count = 0;
            for (int i = 1; i <= result.Count; i++)
            {
                for (int j = 0; j < result.Count - 1; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        result.Swap(j, j + 1);
                    }
                }

                count = i;
            }

            timer.Stop();

            return (result, count, timer.ElapsedMilliseconds);
        }

        static (List<int> list, int count, long time) BubbleSortSwappedCheck(List<int> list)
        {
            List<int> result = new List<int>();
            result.AddRange(list);

            Stopwatch timer = new Stopwatch();
            timer.Start();

            int count = 0;
            for (int i = 1; i <= result.Count - 1; i++)
            {
                int swapped = 0;
                for (int j = 0; j < result.Count - i; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        result.Swap(j, j + 1);
                        swapped++;
                    }
                }

                count = i;

                if (swapped == 0) break;
            }

            timer.Stop();

            return (result, count, timer.ElapsedMilliseconds);
        }

        static (List<int> list, int count, long time) BubbleSelectionSort(List<int> list)
        {
            List<int> result = new List<int>();
            result.AddRange(list);

            Stopwatch timer = new Stopwatch();
            timer.Start();

            int count = 0;
            for (int i = 1; i <= result.Count - 1; i++)
            {
                int swapped = 0;
                int min = i;
                for (int j = i; j < result.Count - i; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        result.Swap(j, j + 1);
                        swapped++;
                    }

                    if (result[j] < result[min])
                    {
                        min = j;
                    }
                }

                count = i;

                if (swapped == 0) break;

                if (min != i)
                {
                    result.Swap(i, min);
                }
            }

            timer.Stop();

            return (result, count, timer.ElapsedMilliseconds);
        }
    }
}