using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to compute the sum of values in a given array of integers except the number 17.
        Return 0 if the given array has no integer.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ReadKey();
        }

        public static int test(int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 17) sum += nums[i];
            }
            return sum;
        }
    }
}