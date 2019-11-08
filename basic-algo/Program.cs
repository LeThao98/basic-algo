using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to rotate the elements of a given array of integers (length 4) in left direction and return the new array.
        Test Data: 90, 30, 50, 40
        Sample Output: Rotated array: 30 50 40 90
        Test Data: -40, 10, -20, -10
        Sample Output: Rotated array: 10 -20 -10 -40
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] item = test(new[] { 10, 20, -30, -40 });

            Console.Write("Rotated array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();
        }

        public static int[] test(int[] a1)
        {
            return new int[] { a1[1], a1[2], a1[3], a1[0] };
        }
    }
}