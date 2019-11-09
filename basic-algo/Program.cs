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
            Console.WriteLine(test(123));
            Console.WriteLine(test(13));
            Console.WriteLine(test(222));
            Console.ReadKey();
        }

        public static bool test(int n)
        {
            while (n > 0)
            {
                if (n % 10 == 2) return true;
                n /= 10;
            }
            return false;
        }
    }
}