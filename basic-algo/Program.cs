using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to check a given array of integers of length 1 or more and return true
       if the first element and the last element are equal in the given array.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 10, 20, 40, 50 }));
            Console.WriteLine(test(new[] { 10, 20, 40, 10 }));
            Console.WriteLine(test(new[] { 12, 24, 35, 55 }));

            Console.ReadKey();
        }

        public static bool test(int[] nums)
        {
            return nums.Length > 0 && nums[0] == nums[nums.Length - 1];
        }
    }
}