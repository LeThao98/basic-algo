using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to create a new array taking the elements after the element value 5 from a given array of integers.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 2, 3, 5, 7, 9, 11 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadKey();
        }

        public static int[] test(int[] numbers)
        {
            int len = numbers.Length, size = 0, i = len - 1;
            int[] post_ele_5;

            while (i >= 0 && numbers[i] != 5) i--;
            i++;

            size = len - i;
            post_ele_5 = new int[size];

            for (int j = 0; j < size; j++)
            {
                post_ele_5[j] = numbers[i + j];
            }

            return post_ele_5;
        }
    }
}