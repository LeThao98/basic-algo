using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check if it is possible to add two integers to get the third integer from three given integers.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(1, 2, 3));
            Console.WriteLine(test(4, 5, 6));
            Console.WriteLine(test(-1, 1, 0));

            Console.ReadKey();
        }

        private static bool test(int a, int b, int c)
        {
            return a == b + c || b == a + c || c == a + b;
        }
    }
}