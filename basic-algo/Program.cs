using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to insert a given string into middle of the another given string of length 4.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("[[]]", "Hello"));
            Console.WriteLine(test("(())", "Hi"));
            Console.ReadKey();
        }

        public static string test(string s1, string s2)
        {
            return s1.Length == 4 ? s1.Substring(0, 2) + s2 + s1.Substring(2) : string.Empty;
        }
    }
}