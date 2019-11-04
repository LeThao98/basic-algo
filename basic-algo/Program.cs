using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program that accept two integers and return true if either one is 5 or their sum or difference is 5.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(5, 4));
            Console.WriteLine(test(4, 3));
            Console.WriteLine(test(1, 4));

            Console.ReadKey();
        }

        private static bool test(int a, int b)
        {
            return a == 5 || b == 5 || a + b == 5 ? true : false;
        }
    }
}