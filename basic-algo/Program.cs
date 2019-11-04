using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(13));
            Console.WriteLine(test(14));
            Console.WriteLine(test(27));
            Console.WriteLine(test(41));

            Console.ReadKey();
        }

        private static bool test(int a)
        {
            return a % 13 == 0 || a % 13 == 1;
        }
    }
}