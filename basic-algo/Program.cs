using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to create a new string of length 2 starting at the given index of a given string.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("Hello", 1));
            Console.WriteLine(test("Python", 2));
            Console.WriteLine(test("on", 1));

            Console.ReadKey();
        }

        public static string test(string s, int n)
        {
            return n <= s.Length - 2 ? s.Substring(n, 2) : (s.Length == 1 ? s : s.Substring(0, 2));
        }
    }
}