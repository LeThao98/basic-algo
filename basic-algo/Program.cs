using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check if a triple is presents in an array of integers or not.
         If a value appears three times in a row in an array it is called a triple.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 1, 2, 2, 1 }));
            Console.WriteLine(test(new[] { 1, 1, 2, 1, 2, 3 }));
            Console.WriteLine(test(new[] { 1, 1, 1, 2, 2, 2, 1 }));

            Console.ReadKey();
        }

        private static bool test(int[] a)
        {
            for (int i = 0; i < a.Length - 2; i++)
            {
                int x = a[i];
                if (a[i + 1] == x && a[i + 2] == x)
                {
                    return true;
                }
            }
            return false;
        }
    }
}