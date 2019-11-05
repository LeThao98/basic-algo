using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check if a given non-negative given number is a multiple of 3 or 7, but not both.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(3));
            Console.WriteLine(test(7));
            Console.WriteLine(test(8));
            Console.WriteLine(test(21));

            Console.ReadKey();
        }

        private static bool test(int a)
        {
            return a % 10 <= 2 || a % 10 >= 8;
        }
    }
}