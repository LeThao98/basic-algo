using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to create a new array taking the first and last elements of a given array of integers and length 1 or more.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] item = test(new[] { 10, 20, -30, -40, 30 });

            Console.Write("New array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();
        }

        public static int[] test(int[] nums)
        {
            return new int[] { nums[0], nums[nums.Length - 1] };
        }
    }
}