using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to find out the maximum element between the first or last element in a given array of integers (length 4),
       replace all elements with maximum element.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] item = test(new[] { 10, 20, -30, -40 });

            Console.Write("New array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();
        }

        public static int[] test(int[] nums)
        {
            int max = nums.Max();

            return new int[] { max, max, max, max };
        }
    }
}