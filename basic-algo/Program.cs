using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to create a new string from a given string.
       If the first or first two characters is 'a', return the string without those 'a' characters otherwise return the original given string.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("abcab"));
            Console.WriteLine(test("python"));
            Console.WriteLine(test("aacda"));
            Console.WriteLine(test("jython"));

            Console.ReadKey();
        }

        public static string test(string s)
        {
            if (s.Length == 1 && s.Substring(0, 1) == "a")
            {
                s = s.Remove(0, 1);
            }

            if (s.Length > 1)
            {
                if (s.Substring(1, 1) == "a")
                {
                    s = s.Remove(1, 1);
                }

                if (s.Substring(0, 1) == "a")
                {
                    s = s.Remove(0, 1);
                }
            }

            return s;
        }
    }
}