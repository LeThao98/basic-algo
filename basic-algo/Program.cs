using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
      Write a C# Sharp program to create a new array from two give array of integers, each length 3.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] item = test(new[] { 10, 20, 30 }, new[] { 40, 50, 60 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();
        }

        public static int[] test(int[] nums1, int[] nums2)
        {
            return new int[] { nums1[0], nums1[1], nums1[2], nums2[0], nums2[1], nums2[2] };
        }
    }
}