using System;
using System.Collections;
using System.Collections.Generic;

namespace basic_algo
{
    /*
        Write a C# Sharp program to check if the value of each element is equal or greater than the value of previous element of a given array of integers.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 5, 5, 1, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(test(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 5, 5, 7, 8, 10 }));
            Console.ReadKey();
        }

        public static bool test(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1] < numbers[i]) return false;
            }

            return true;
        }
    }
}