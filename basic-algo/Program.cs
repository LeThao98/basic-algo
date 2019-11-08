using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
      Write a C# Sharp program to compute the sum of the two given arrays of integers, length 3 and find the array which has the largest sum.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] item = test(new[] { 10, 20, -30 }, new[] { 10, 20, 30 });
            Console.Write("Larger array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();
        }

        public static int[] test(int[] nums1, int[] nums2)
        {
            return nums1[0] + nums1[1] + nums1[2] >= nums2[0] + nums2[1] + nums2[2] ? nums1 : nums2;
        }
    }
}