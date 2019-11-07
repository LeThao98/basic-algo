using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to create a new string using the first and last n characters from a given string of length at least n.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("Hello", 1));
            Console.WriteLine(test("Python", 2));
            Console.WriteLine(test("on", 1));
            Console.WriteLine(test("o", 1));

            Console.ReadKey();
        }

        public static string test(string s, int n)
        {
            return s.Length >= n ? s.Substring(0, n) + s.Substring(s.Length - n) : string.Empty;
        }
    }
}