using System;
using System.Collections.Generic;

namespace saray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int>() { 1, 1, 1, 4, 4, 2, 3, 3, 2, 2 };

            var result = Calculate(A);

            Console.WriteLine(string.Format("L: [{0}]", string.Join(", ", result.L)));
            Console.WriteLine(string.Format("R: [{0}]", string.Join(", ", result.R)));

            Console.ReadLine();
        }

        static (List<int> L, List<int> R) Calculate(List<int> A)
        {
            List<int> L = new List<int>();
            List<int> R = new List<int>();

            return (L, R);
        }
    }
}