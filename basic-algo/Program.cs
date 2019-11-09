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
            Console.WriteLine(test(new[] { 1, 5, 6, 9, 3, 3 }));
            Console.WriteLine(test(new[] { 1, 5, 5, 5, 10, 17 }));
            Console.WriteLine(test(new[] { 1, 3, 3, 5, 5, 5 }));
            Console.ReadKey();
        }

        public static bool test(int[] nums)
        {
            int no_3 = 0, no_5 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 3) no_3++;
                if (nums[i] == 5) no_5++;
            }

            return no_3 > no_5;
        }
    }
}