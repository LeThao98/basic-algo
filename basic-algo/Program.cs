using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to check whether a given array of integers contains 5's and 7's.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 5, 6, 9, 10, 17 }));
            Console.WriteLine(test(new[] { 1, 4, 7, 9, 10, 17 }));
            Console.WriteLine(test(new[] { 1, 1, 2, 9, 10, 17 }));
            Console.ReadKey();
        }

        public static bool test(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 5 || nums[i] == 7) return true;
            }

            return false;
        }
    }
}