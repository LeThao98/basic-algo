using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to check if a given string ends with "on".
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("on"));
            Console.WriteLine(test("o"));

            Console.ReadKey();
        }

        public static bool test(string s)
        {
            if (s.Length >= 2) return s.Substring(s.Length - 2) == "on";
            return false;
            //return s1.EndsWith("on");
        }
    }
}