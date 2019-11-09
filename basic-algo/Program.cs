using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to create a new array taking the elements before the element value 5 from a given array of integers.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 2, 3, 5, 7 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadKey();
        }

        public static int[] test(int[] numbers)
        {
            int size = 0;
            int[] pre_ele_5;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 5)
                {
                    size = i;
                    break;
                }
            }
            pre_ele_5 = new int[size];

            for (int j = 0; j < size; j++)
            {
                pre_ele_5[j] = numbers[j];
            }
            return pre_ele_5;
        }
    }
}