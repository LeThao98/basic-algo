using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
      Write a C# Sharp program to create a new array swapping the first and last elements of a given array of
      integers and length will be least 1.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 5, 7, 9, 11, 13 });
            Console.Write("After swapping first and last elements: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();
        }

        public static int[] test(int[] numbers)
        {
            int first = numbers[0];
            numbers[0] = numbers[numbers.Length - 1];
            numbers[numbers.Length - 1] = first;

            return numbers;
        }
    }
}