using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to create a new string using two given strings s1, s2, the format of the new string will be s1s2s2s1.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("Hi", "Hello"));
            Console.WriteLine(test("whats", "app"));
            Console.ReadKey();
        }

        public static string test(string s1, string s2)
        {
            return String.Format("{0}{1}{1}{0}", s1, s2);
        }
    }
}