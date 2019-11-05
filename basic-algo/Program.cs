using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to compute the sum of the two given integers.
         If one of the given integer value is in the range 10..20 inclusive return 18.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(3, 7));
            Console.WriteLine(test(10, 11));
            Console.WriteLine(test(10, 20));
            Console.WriteLine(test(21, 220));

            Console.ReadKey();
        }

        private static int test(int x, int y)
        {
            return (x >= 10 && x <= 20) || (y >= 10 && y <= 20) ? 18 : x + y;
        }
    }
}