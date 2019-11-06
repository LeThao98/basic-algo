using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to create a new string from two given string one is shorter and another is longer.
         The format of the new string will be long string + short string + long string.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("Hello", "Hi"));
            Console.WriteLine(test("JS", "Python"));

            Console.ReadKey();
        }

        public static string test(string s1, string s2)
        {
            return s1.Length > s2.Length ? s1 + s2 + s1 : s2 + s1 + s2;
        }
    }
}