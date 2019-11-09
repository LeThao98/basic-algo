using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to check if a given array of integers contains 5 next to a 5 somewhere.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 5, 6, 9, 10, 17 }));
            Console.WriteLine(test(new[] { 1, 5, 5, 9, 10, 17 }));
            Console.WriteLine(test(new[] { 1, 5, 5, 9, 10, 17, 5, 5 }));
            Console.ReadKey();
        }

        public static bool test(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 5 && nums[i] == nums[i + 1]) return true;
            }

            return false;
        }
    }
}