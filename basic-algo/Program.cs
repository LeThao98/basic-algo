using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to create a new string from a given string without the first and last character
       if the first or last characters are 'a' otherwise return the original given string.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("abcab"));
            Console.WriteLine(test("python"));
            Console.WriteLine(test("abcda"));
            Console.WriteLine(test("jython"));

            Console.ReadKey();
        }

        public static string test(string s)
        {
            if (s.Length > 0 && s.Substring(s.Length - 1) == "a")
            {
                s = s.Remove(s.Length - 1);
            }

            if (s.Length > 0 && s.Substring(0, 1) == "a")
            {
                s = s.Remove(0, 1);
            }

            return s;
        }
    }
}