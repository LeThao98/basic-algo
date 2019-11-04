using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to count the number of two 5's are next to each other in an array of integers.
         Also count the situation where the second 5 is actually a 6.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 5, 5, 2 }));
            Console.WriteLine(test(new[] { 5, 5, 2, 5, 5 }));
            Console.WriteLine(test(new[] { 5, 6, 2, 9 }));

            Console.ReadKey();
        }

        private static int test(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if ((a[i] == 5 && a[i + 1] == 5) || (a[i] == 5) && a[i + 1] == 6)
                {
                    count++;
                }
            }
            return count;
        }
    }
}