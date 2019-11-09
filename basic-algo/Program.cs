using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to compute the sum of the numbers in a given array except those numbers starting with 5
        followed by atleast one 6. Return 0 if the given array has no integer.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Sum of the numbers of the said array except those numbers starting with 5 followed by atleast one 6: ");
            Console.WriteLine(test(new[] { 1, 5, 6, 9, 10, 17 }));
            Console.ReadKey();
        }

        public static int test(int[] nums)
        {
            int sum = 0;
            bool inSection = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 5) inSection = true;
                else if (inSection && nums[i] == 6) inSection = false;
                else if (!inSection) sum += nums[i];
            }
            return sum;
        }
    }
}