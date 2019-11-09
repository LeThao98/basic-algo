using System;
using System.Collections;
using System.Collections.Generic;

namespace basic_algo
{
    /*
        Write a C# Sharp program to create a new array using the first n strings from a given array of strings.
        (n>=1 and <=length of the array)
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] item = test(new[] { "a", "b", "bb", "c", "ccc" }, 3);
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadKey();
        }

        public static string[] test(string[] arr_str, int n)
        {
            string[] new_array = new string[n];

            for (int i = 0; i < n; i++)
            {
                new_array[i] = arr_str[i];
            }

            return new_array;
        }
    }
}