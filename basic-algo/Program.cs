using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check two given integers, each in the range 10..99.
         Return true if a digit appears in both numbers, such as the 3 in 13 and 33
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(11, 21));
            Console.WriteLine(test(11, 20));
            Console.WriteLine(test(10, 10));

            Console.ReadKey();
        }

        public static bool test(int x, int y)
        {
            return (x / 10 == y / 10 || x / 10 == y % 10) || (x % 10 == y / 10 || x % 10 == y % 10);
        }
    }
}