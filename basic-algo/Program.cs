using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to compute the sum of two given non-negative integers x and y as long as the sum has the same number of digits as x.
         If the sum has more digits than x then return x without y.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(4, 5));
            Console.WriteLine(test(7, 4));
            Console.WriteLine(test(10, 10));

            Console.ReadKey();
        }

        public static int test(int x, int y)
        {
            int a = x + y;
            int b = x;
            while (a > 0 && b > 0)
            {
                a /= 10;
                b /= 10;
            }
            return a > b ? x : x + y;
            //return (x + y).ToString().Length > x.ToString().Length ? x : x + y;
        }
    }
}