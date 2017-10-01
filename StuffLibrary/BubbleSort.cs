using System.Collections.Generic;
using System.Diagnostics;

namespace StuffLibrary
{
    public class BubbleSort
    {
        public delegate void PrintData(List<int> list, int count, long time);
        PrintData print;

        public void RegisterHandler(PrintData _print)
        {
            print = _print;
        }

        public List<int> List { get; private set; }

        public enum SortType
        {
            Simple,
            SwappedCheck,
            WithSelection
        }

        public BubbleSort(List<int> list)
        {
            List<int> List = new List<int>();
            List.AddRange(list);
        }

        public List<int> Sort(SortType type)
        {
            switch(type)
            {
                case SortType.Simple:
                    return BubbleSortSimple();
                case SortType.SwappedCheck:
                    return BubbleSortSwappedCheck();
                case SortType.WithSelection:
                    return BubbleSelectionSort();
            }

            return List;
        }

        private List<int> BubbleSortSimple()
        {
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

            print(result, count, timer.ElapsedMilliseconds);

            return result;
        }

        private List<int> BubbleSortSwappedCheck()
        {
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

            print(result, count, timer.ElapsedMilliseconds);

            return result;
        }

        private List<int> BubbleSelectionSort()
        {
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

            print(result, count, timer.ElapsedMilliseconds);

            return result;
        }
    }
}
