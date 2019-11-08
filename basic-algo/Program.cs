using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to check if a given string begins with "abc" or "xyz".
       If the string begins with "abc" or "xyz" return "abc" or "xyz" otherwise return the empty string
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("abc"));
            Console.WriteLine(test("abcdef"));
            Console.WriteLine(test("C"));
            Console.WriteLine(test("xyz"));
            Console.WriteLine(test("xyzsder"));

            Console.ReadKey();
        }

        public static string test(string s)
        {
            if (s.StartsWith("abc"))
            {
                return "abc";
            }
            if (s.StartsWith("xyz"))
            {
                return "xyz";
            }
            return string.Empty;
        }
    }
}