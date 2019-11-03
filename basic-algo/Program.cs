using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 2, 9, 3 }, 3));
            Console.WriteLine(test(new[] { 1, 2, 3, 4, 5, 6 }, 2));
            Console.WriteLine(test(new[] { 1, 2, 2, 3 }, 9));

            Console.ReadKey();
        }

        private static bool test(int[] a, int x)
        {
            return a.Length < 4 ? a.Contains(x) : a.Take(4).Contains(x);
        }
    }
}