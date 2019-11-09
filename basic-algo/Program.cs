using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to check if the sum of all 5' in the array exactly 15 in a given array of integers.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 5, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 3, 3, 3, 3 }));
            Console.WriteLine(test(new[] { 3, 3, 3, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 6, 8, 10 }));
            Console.ReadKey();
        }

        public static bool test(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 3 && nums[i] != 5) return false;
            }
            return true;
        }
    }
}