using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to check a given array of integers of length 1 or more and
       return true if 10 appears as either first or last element in the given array.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 10, 20, 40, 50 }));
            Console.WriteLine(test(new[] { 5, 20, 40, 10 }));
            Console.WriteLine(test(new[] { 10, 20, 40, 10 }));
            Console.WriteLine(test(new[] { 12, 24, 35, 55 }));

            Console.ReadKey();
        }

        public static bool test(int[] nums)
        {
            return nums[0] == 10 || nums[nums.Length - 1] == 10;
        }
    }
}