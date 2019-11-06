using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to compute the sum of the three integers.
         If one of the values is 13 then do not count it and its right towards the sum.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(4, 5, 7));
            Console.WriteLine(test(7, 4, 12));
            Console.WriteLine(test(10, 13, 12));
            Console.WriteLine(test(13, 12, 18));

            Console.ReadKey();
        }

        public static int test(int x, int y, int z)
        {
            if (x == 13) return 0;
            if (y == 13) return x;
            if (z == 13) return x + y;
            return x + y + z;
        }
    }
}