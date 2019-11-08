using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to create a new string taking the first character from a given string and the last character from another given string.
       If the length of any given string is 0, use '#' as its  missing character.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("Hello", "Hi"));
            Console.WriteLine(test("Python", "PHP"));
            Console.WriteLine(test("JS", "JS"));
            Console.WriteLine(test("Csharp", ""));

            Console.ReadKey();
        }

        public static string test(string s1, string s2)
        {
            string firstChar = s1.Length == 0 ? "#" : s1.Substring(0, 1);
            string secondChar = s2.Length == 0 ? "#" : s2.Substring(s2.Length - 1);
            return firstChar + secondChar;
        }
    }
}