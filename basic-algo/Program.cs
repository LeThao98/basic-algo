using System;
using System.Collections;
using System.Collections.Generic;

namespace basic_algo
{
    /*
        Write a C# Sharp program to create a new array from a given array of strings using all the strings whose length are matched with given string length.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            IEnumerable<string> item = test(new[] { "a", "aaa", "b", "bbb", "c", "ccc" }, 3);
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadKey();
        }

        public static IEnumerable<string> test(string[] arr_str, int n)
        {
            for (int i = 0; i < arr_str.Length; i++)
            {
                if (arr_str[i].Length == n)
                {
                    yield return arr_str[i];
                }
            }
        }
    }
}