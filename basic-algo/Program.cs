using System;
using System.Collections;
using System.Collections.Generic;

namespace basic_algo
{
    /*
        Write a C# Sharp program to count the number of strings with given length in given array of strings.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Number of array: ");
            Console.WriteLine(test(new[] { "a", "b", "bb", "c", "ccc" }, 1));
            Console.ReadKey();
        }

        public static int test(string[] arr_str, int len)
        {
            int ctr = 0;

            for (int i = 0; i < arr_str.Length; i++)
            {
                if (arr_str[i].Length == len) ctr++;
            }
            return ctr;
        }
    }
}