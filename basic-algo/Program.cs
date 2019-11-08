using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to create a new array of integers and length 1 or more.
       The length of the new array will be double length of an given array and
       all the elements are 0 except the first element which is equal to first elements of the given array.
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
            int elements = nums.Length * 2;
            int[] doubleNums = new int[elements];

            doubleNums[0] = nums[0];
            return doubleNums;
        }
    }
}