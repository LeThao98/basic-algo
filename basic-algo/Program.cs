using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 1, 2, 3, 1 }));
            Console.WriteLine(test(new[] { 1, 1, 2, 4, 1 }));
            Console.WriteLine(test(new[] { 1, 1, 2, 1, 2, 3 }));

            Console.ReadKey();
        }

        private static bool test(int[] a)
        {
            for (var i = 0; i < a.Length - 2; i++)
            {
                if (a[i] == 1 && a[i + 1] == 2 && a[i + 2] == 3)
                    return true;
            }
            return false;
        }
    }
}