using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check if two or more non-negative given integers have the same rightmost digit.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(11, 21, 31));
            Console.WriteLine(test(11, 22, 31));
            Console.WriteLine(test(11, 22, 33));

            Console.ReadKey();
        }

        public static bool test(int x, int y, int z)
        {
            return x % 10 == y % 10 || x % 10 == z % 10 || z % 10 == y % 10;
        }
    }
}