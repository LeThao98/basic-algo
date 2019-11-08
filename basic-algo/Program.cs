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
            Console.WriteLine(test("abc", "abcd"));
            Console.WriteLine(test("Python", "Python"));
            Console.WriteLine(test("JS", "Python"));

            Console.ReadKey();
        }

        public static string test(string s1, string s2)
        {
            if (s1.Length > s2.Length)
            {
                return s1.Substring(0, s2.Length) + s2;
            }
            if (s2.Length > s1.Length)
            {
                return s1 + s2.Remove(0, s2.Length - s1.Length);
            }
            return s1 + s2;
        }
    }
}