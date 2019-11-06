using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to create a new string of the first half of a given string of even length.
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
            return s.Length % 2 == 0 ? s.Substring(0, s.Length / 2) : s.Substring(0, (s.Length - 1) / 2);
        }
    }
}