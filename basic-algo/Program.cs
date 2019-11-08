using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to concate two given strings. If there are any double character in new string then omit one character.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("abc", "cat"));
            Console.WriteLine(test("python", "php"));
            Console.WriteLine(test("php", "php"));

            Console.ReadKey();
        }

        public static string test(string s1, string s2)
        {
            if (s1.Length < 1)
            {
                return s2;
            }

            if (s2.Length < 1)
            {
                return s1;
            }

            return !s1.EndsWith(s2.Substring(0, 1)) ? s1 + s2 : s1 + s2.Substring(1);
        }
    }
}