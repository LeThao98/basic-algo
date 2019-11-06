using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to concat two given string of length atleast 1, after removing their first character.
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
            return s1.Substring(1) + s2.Substring(1);
        }
    }
}