using System;
using System.Collections;
using System.Collections.Generic;

namespace basic_algo
{
    /*
        Write a C# Sharp program to find the larger average value between the first and the second half of a given array of integers and minimum length is atleast 2.
        Assume that the second half begins at index (array length)/2.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 2, 3, 4, 6, 8 }));
            Console.WriteLine(test(new[] { 15, 2, 3, 4, 15, 11 }));
            Console.ReadKey();
        }

        public static int test(int[] numbers)
        {
            var firstHalf = Average(numbers, 0, numbers.Length / 2);
            var secondHalf = Average(numbers, numbers.Length / 2, numbers.Length);
            return firstHalf > secondHalf ? firstHalf : secondHalf;
        }

        private static int Average(int[] num, int start, int end)
        {
            var sum = 0;
            for (var i = start; i < end; i++)
                sum += num[i];
            return sum / (num.Length / 2);
        }
    }
}