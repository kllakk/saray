using System;
using System.Collections.Generic;
using System.Linq;

namespace saray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = InitialA();

            var result = CalculateLR(A);

            Console.WriteLine(string.Format("A: [{0}]", string.Join(", ", A)));
            Console.WriteLine(string.Format("L: [{0}]", string.Join(", ", result.L)));
            Console.WriteLine(string.Format("R: [{0}]", string.Join(", ", result.R)));

            Console.ReadLine();
        }

        static List<int> InitialA()
        {
            Random r = new Random();
            int count = r.Next(1, 10000);

            List<int> result = new List<int>();
            result.Add(count);
            for (int i = 0; i < count; i++)
            {
                int rnd = r.Next(0, 10000);
                result.Add(rnd);
            }

            return result;
        }

        static (List<int> L, List<int> R) CalculateLR(List<int> A)
        {            
            var data = A.Where((x, i) => i > 0).Select((x, i) => new Data { Value = x, Index = i }).ToList();

            List<int> L = TakeOne(data, Type.ToLeft);
            List<int> R = TakeOne(data, Type.ToRight);

            return (L, R);
        }

        static List<int> TakeOne(List<Data> data, Type type)
        {
            List<int> result = new List<int>();

            foreach (var d in data)
            {
                int? value = null;

                List<Data> range = new List<Data>();

                switch (type) {
                    case Type.ToLeft:
                        range.AddRange(data.Take(d.Index + 1).OrderByDescending(x => x.Index).ToList());
                        break;
                    case Type.ToRight:
                        range.AddRange(data.Skip(d.Index).OrderBy(x => x.Index).ToList());
                        break;
                }

                foreach (var r in range)
                {
                    if (r.Value >= d.Value)
                    {
                        value = r.Index;
                    }
                    else
                    {
                        break;
                    }
                }

                result.Add((int)value);
            }

            return result;
        }

        enum Type
        {
            ToLeft,
            ToRight
        }

        class Data
        {
            public int Index { get; set; }
            public int Value { get; set; }
        }
    }
}