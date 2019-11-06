using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to create a new string using first two characters of a given string.
         If the string length is less than 2 then return the original string.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Hi"));
            Console.WriteLine(test("H"));
            Console.WriteLine(test(" "));
            Console.ReadKey();
        }

        public static string test(string s)
        {
            return s.Length >= 2 ? s.Substring(0, 2) : s;
        }
    }
}