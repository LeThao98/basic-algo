using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to create a new string from a given string without the first two characters.
       Keep the first character if it is "p" and keep the second character if it is "y".
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("abcab"));
            Console.WriteLine(test("python"));
            Console.WriteLine(test("press"));
            Console.WriteLine(test("jython"));

            Console.ReadKey();
        }

        public static string test(string s)
        {
            if (s.Substring(0, 1) == "p" && s.Substring(1, 1) == "y") return s;
            if (s.Substring(0, 1) == "p") return "p" + s.Remove(0, 2);
            if (s.Substring(1, 1) == "y") return s.Remove(0, 1);
            return s.Remove(0, 2);
        }
    }
}