using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check if three given numbers are in strict increasing order,
         such as 4 7 15, or 45, 56, 67, but not 4 ,8, 8 or 6, 6, 8.
         However,if a fourth parameter  is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(1, 2, 3, false));
            Console.WriteLine(test(1, 2, 3, true));
            Console.WriteLine(test(10, 2, 30, false));
            Console.WriteLine(test(10, 10, 30, true));

            Console.ReadKey();
        }

        public static bool test(int x, int y, int z, bool flag)
        {
            return flag ? x <= y && y <= z : x < y && y < z;
        }
    }
}