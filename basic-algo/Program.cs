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
            Console.WriteLine(test(new[] { 1, 5, 6, 9, 10, 17 }));
            Console.WriteLine(test(new[] { 1, 5, 5, 5, 10, 17 }));
            Console.WriteLine(test(new[] { 1, 1, 5, 5, 5, 5 }));
            Console.ReadKey();
        }

        public static bool test(int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 5)
                    sum += 5;
            }

            return sum == 15;
        }
    }
}