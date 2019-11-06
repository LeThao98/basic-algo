using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to find the larger from two given integers.
         However if the two integers have the same remainder when divided by 7,then the return the smaller integer.
         If the two integers are the same, return 0.
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

        public static int test(int x, int y)
        {
            return x == y ? 0 : (x % 7 == y % 7 ? Math.Min(x, y) : Math.Max(x, y));
        }
    }
}