using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to create a new string from a given string after swapping last two characters.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("PHP"));
            Console.WriteLine(test("JS"));
            Console.WriteLine(test("C"));

            Console.ReadKey();
        }

        public static string test(string s)
        {
            return s.Length >= 2 ? s.Substring(0, s.Length - 2) + s.Substring(s.Length - 1) + s.Substring(s.Length - 2, 1) : string.Empty;
        }
    }
}