using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to compute the sum of three given integers. If the two values are same return the third value.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(4, 5, 7));
            Console.WriteLine(test(7, 4, 12));
            Console.WriteLine(test(10, 10, 12));
            Console.WriteLine(test(12, 12, 18));

            Console.ReadKey();
        }

        public static int test(int x, int y, int z)
        {
            if (x == y && y == z) return 0;
            if (x == y) return z;
            if (x == z) return y;
            if (y == z) return x;
            return x + y + z;
        }
    }
}