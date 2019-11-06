using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check two given integers and return the value whichever value is nearest to 13 without going over. Return 0 if both numbers go over.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(4, 5));
            Console.WriteLine(test(7, 12));
            Console.WriteLine(test(10, 13));
            Console.WriteLine(test(17, 33));
            Console.WriteLine(test(17, 33));

            Console.ReadKey();
        }

        public static int test(int x, int y)
        {
            return x > 13 && y > 13 ? 0 : ((x > 13 && y <= 13) ? y : ((y > 13 && x <= 13) ? x : (13 - x > 13 - y ? y : x)));
        }
    }
}