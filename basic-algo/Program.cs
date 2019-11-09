using System;
using System.Collections;
using System.Collections.Generic;

namespace basic_algo
{
    /*
        Write a C# Sharp program to create new array from a given array of integers shifting all even numbers before all odd numbers.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 2, 5, 3, 5, 4, 6, 9, 11 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadKey();
        }

        public static int[] test(int[] numbers)
        {
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    int temp = numbers[index];
                    numbers[index] = numbers[i];
                    numbers[i] = temp;

                    index++;
                }
            }
            return numbers;
        }
    }
}