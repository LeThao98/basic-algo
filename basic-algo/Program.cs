using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to check a given array of integers and return true if the array contains 10 or 20 twice.
       The length of the array will be 0, 1, or 2.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 12, 20 }));
            Console.WriteLine(test(new[] { 20, 20 }));
            Console.WriteLine(test(new[] { 10, 10 }));
            Console.WriteLine(test(new[] { 10 }));

            Console.ReadKey();
        }

        public static bool test(int[] nums)
        {
            return nums.Length == 2
               && ((nums[0] == 10 && nums[1] == 10)
                    || (nums[0] == 20 && nums[1] == 20));
        }
    }
}