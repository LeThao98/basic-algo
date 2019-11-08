using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to check if a given array of integers and length 2, does not contain 15 and 20.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 12, 20 }));
            Console.WriteLine(test(new[] { 14, 15 }));
            Console.WriteLine(test(new[] { 11, 21 }));

            Console.ReadKey();
        }

        public static int[] test(int[] nums)
        {
            return nums[0] != 15 && nums[0] != 20 && nums[1] != 15 && nums[1] != 20;
        }
    }
}