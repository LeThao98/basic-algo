using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to create a new array taking the first two elements from a given array.
        If the length of the given array is less than 2 then return the give array.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 5, 7, 9, 10, 12 }));

            Console.ReadKey();
        }

        public static int test(int[] numbers)
        {
            int evens = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) evens++;
            }
            return evens;
        }
    }
}