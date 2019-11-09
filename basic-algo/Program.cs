using System;
using System.Collections;
using System.Collections.Generic;

namespace basic_algo
{
    /*
        Write a C# Sharp program to check a given array (length will be atleast 2) of integers and return true
        if there are two values 15, 15 next to each other.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 5, 5, 1, 15, 15 }));
            Console.WriteLine(test(new[] { 15, 2, 3, 4, 15 }));
            Console.WriteLine(test(new[] { 3, 3, 15, 15, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 5, 15, 7, 8, 15 }));
            Console.ReadKey();
        }

        public static bool test(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1] == numbers[i] && numbers[i] == 15) return true;
            }
            return false;
        }
    }
}