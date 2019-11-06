using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check three given integers and return true if one of them is 20 or more less than one of the others.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(11, 21, 31));
            Console.WriteLine(test(11, 22, 31));
            Console.WriteLine(test(10, 20, 15));

            Console.ReadKey();
        }

        public static bool test(int x, int y, int z)
        {
            return Math.Abs(x - y) >= 20 || Math.Abs(x - z) >= 20 ||
                   Math.Abs(y - z) >= 20;
        }
    }
}