using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check three given integers (small, medium and large) and return true if the difference between small
         and medium and the difference between medium and large is same.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(4, 5, 6));
            Console.WriteLine(test(7, 12, 13));
            Console.WriteLine(test(-1, 0, 1));

            Console.ReadKey();
        }

        public static bool test(int x, int y, int z)
        {
            return z - y == y - x;
        }
    }
}