using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to check a given array of integers and return true if the specified number of same elements
        appears at the start and end of the given array.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 3, 7, 5, 5, 3, 7 }, 2));
            Console.WriteLine(test(new[] { 3, 7, 5, 5, 3, 7 }, 3));
            Console.WriteLine(test(new[] { 3, 7, 5, 5, 3, 7, 5 }, 3));
            Console.ReadKey();
        }

        public static bool test(int[] numbers, int len)
        {
            int arra_size = numbers.Length;

            for (int i = 0; i < len; i++)
            {
                if (numbers[i] != numbers[arra_size - len + i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}