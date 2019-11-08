using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to compute the sum of the elements of an given array of integers.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 10, 20, 30, 40, 50 }));
            Console.WriteLine(test(new[] { 10, 20, -30, -40, 50 }));

            Console.ReadKey();
        }

        public static int test(int[] a1)
        {
            int result = 0;
            foreach (int item in a1)
            {
                result += item;
            }
            return result;
        }
    }
}