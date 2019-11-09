using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to check if a given array of integers contains no 3 or a 5.
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
            var three = false;
            var five = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 3) { three = true; }
                if (nums[i] == 5) { five = true; }
                if (three && five) return false;
            }
            return true;
        }
    }
}