using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranges
{
    class Program
    {
        class Truc : IComparable<Truc>
        {
            int f;
            int IComparable<Truc>.CompareTo(Truc other)
            {
                return f - other.f;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine((new Range(1, 5000)).Aggregate((x, y) => x + y));

            var range = new Range(1, 10);

            foreach(var i in range)
            {
                foreach(var j in range)
                {
                    Console.WriteLine(i * j);
                }
            }
        }
    }
}
