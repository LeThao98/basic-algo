using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to create a new string from a given string.
       If the two characters of the given string from its beginning and end
       are same return the given string without the first two characters otherwise return the original string.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("abcab"));
            Console.WriteLine(test("Python"));

            Console.ReadKey();
        }

        public static string test(string s)
        {
            return s.Substring(0, 2) == s.Substring(s.Length - 2) ? s.Remove(0, 2) : s;
        }
    }
}