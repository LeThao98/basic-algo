using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to move the first two characters to the end of a given string of length at least two.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("JS"));

            Console.ReadKey();
        }

        public static string test(string s)
        {
            return s.Length >= 2 ? s.Substring(2) + s.Substring(0, 2) : s;
        }
    }
}