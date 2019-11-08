using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to create a new string using 3 copies of the first 2 characters of a given string.
       If the length of the given string is less than 2 use the whole string.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("abc"));
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("J"));

            Console.ReadKey();
        }

        public static string test(string s)
        {
            return s.Length >= 2 ? s.Substring(0, 2) + s.Substring(0, 2) + s.Substring(0, 2) : s + s + s;
        }
    }
}