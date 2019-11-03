using System;

namespace basic_algo
{
    /*
         Write a C# Sharp program to create a string like  "aababcabcd" from a given string "abcd".
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("abcd"));
            Console.WriteLine(test("abc"));
            Console.WriteLine(test("a"));

            Console.ReadKey();
        }

        private static string test(string s)
        {
            string result = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                result += s.Substring(0, i + 1);
            }
            return result;
        }
    }
}