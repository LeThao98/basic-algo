using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to create a new string of length 2, using first two characters of a given string. If the given string length is less than 2 use '#' as missing characters.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("a"));
            Console.WriteLine(test(""));

            Console.ReadKey();
        }

        public static string test(string s)
        {
            return s.Length >= 2 ? s.Substring(0, 2) : (s.Length == 1 ? s + '#' : "##");
        }
    }
}