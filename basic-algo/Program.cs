using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to check whether the first two characters and last two characters of a given string are same.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("abab"));
            Console.WriteLine(test("abcdef"));
            Console.WriteLine(test("xyzsderxy"));

            Console.ReadKey();
        }

        public static bool test(string s)
        {
            return s.Substring(0, 2) == s.Substring(s.Length - 2);
        }
    }
}