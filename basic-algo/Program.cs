using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to create a new array containing the middle elements from the two given arrays of integers, each length 5.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] item = test(new[] { 10, 20, -30, -40, 30 }, new[] { 10, 20, 30, 40, 30 });

            Console.Write("New array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();
        }

        public static int[] test(int[] nums1, int[] nums2)
        {
            return new int[] { nums1[2], nums2[2] };
        }
    }
}