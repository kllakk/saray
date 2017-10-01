using StuffLibrary;
using System;
using System.Collections.Generic;

namespace bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                List<int> A = RandomList.InitialIntList(30000, 10);

                var bubble = new BubbleSort(A);

                bubble.RegisterHandler(new BubbleSort.PrintData(PrintData));
                
                var result = bubble.Sort(BubbleSort.SortType.Simple);
                var result2 = bubble.Sort(BubbleSort.SortType.SwappedCheck);
                var result3 = bubble.Sort(BubbleSort.SortType.WithSelection);
            }

            Console.ReadLine();
        }

        static void PrintData(List<int> list, int count, long time)
        {
            Console.WriteLine(string.Format("A = [{0}], count = {1}, time = {2}",
                string.Join(", ", list),
                count, time));
        }
    }
}