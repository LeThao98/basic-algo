using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to compute the sum of the two given integers.
         If the sum is in the range 10..20 inclusive return 30.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(12, 17));
            Console.WriteLine(test(2, 17));
            Console.WriteLine(test(22, 17));
            Console.WriteLine(test(20, 0));

            Console.ReadKey();
        }

        private static int test(int a, int b)
        {
            return a + b >= 10 && a + b <= 20 ? 30 : a + b;
        }
    }
}