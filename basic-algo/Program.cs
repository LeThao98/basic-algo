using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check a specified number is preset in a given array of integers.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Console.WriteLine(test(new[] { 1, 2, 5, 4, 3 }, 3));
            Console.WriteLine(test(new[] { 1, 2, 2, 3 }, 2));
            Console.WriteLine(test(new[] { 1, 2, 2, 3 }, 9));
            long elapseMs = stopwatch.ElapsedMilliseconds;
            Console.WriteLine(elapseMs);
            Console.ReadKey();
        }

        private static bool test(int[] a, int x)
        {
            return a.Contains(x);
        }
    }
}