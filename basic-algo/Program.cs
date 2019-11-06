using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to compute the sum of the three given integers.
         However, if any of the values is in the range 10..20 inclusive then that value counts as 0, except 13 to 17.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(4, 5, 7));
            Console.WriteLine(test(7, 4, 12));
            Console.WriteLine(test(10, 13, 12));
            Console.WriteLine(test(17, 12, 18));

            Console.ReadKey();
        }

        public static int test(int x, int y, int z)
        {
            return check_value(x) + check_value(y) + check_value(z);
        }

        private static int check_value(int x)
        {
            return (x < 13 && x > 9) || (x > 17 && x < 21) ? 0 : x;
        }
    }
}