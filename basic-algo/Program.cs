using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
      Write a C# Sharp program to create a new array of length 3 from a given array (length atleast 3)
      using the elements from the middle of the array.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 5, 7, 9, 11, 13 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();
        }

        public static int[] test(int[] numbers)
        {
            return new int[] { numbers[numbers.Length / 2 - 1], numbers[numbers.Length / 2], numbers[numbers.Length / 2 + 1] };
        }
    }
}