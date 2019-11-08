using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to reverse a given array of integers and length 5.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] item = test(new[] { 10, 20, -30, -40, 50 });

            Console.Write("Rotated array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();
        }

        public static int[] test(int[] nums)
        {
            return new int[] { nums[4], nums[3], nums[2], nums[1], nums[0] };
        }
    }
}