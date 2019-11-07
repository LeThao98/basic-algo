using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to create a new string taking 3 characters from the middle of a given string at least 3.
        Wind, Light, Ocean, Electric, Land
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("abc"));

            Console.ReadKey();
        }

        public static string test(string s)
        {
            return s.Length >= 3 ? s.Substring((s.Length - 1) / 2 - 1, 3) : string.Empty;
        }
    }
}