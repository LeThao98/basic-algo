using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to check two given arrays of integers of length 1 or more and return true if they have the same
       first element or they have the same last element.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 10, 20, 40, 50 }, new[] { 10, 20, 40, 50 }));
            Console.WriteLine(test(new[] { 10, 20, 40, 50 }, new[] { 10, 20, 40, 5 }));
            Console.WriteLine(test(new[] { 10, 20, 40, 50 }, new[] { 1, 20, 40, 5 }));

            Console.ReadKey();
        }

        public static bool test(int[] a1, int[] a2)
        {
            return a1[0] == a2[0] || a1[a1.Length - 1] == a2[a2.Length - 1];
        }
    }
}