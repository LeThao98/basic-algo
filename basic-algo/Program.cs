using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to create a new string using three copies of the last two character of a given string of length atleast two.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Hi"));
            Console.ReadKey();
        }

        public static string test(string s)
        {
            return s.Length >= 2 ? s.Substring(s.Length - 2) + s.Substring(s.Length - 2) + s.Substring(s.Length - 2) : s + s + s;
        }
    }
}