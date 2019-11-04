using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to create a new string from a give string where a specified character
         have been removed except starting and ending position of the given string.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("xxHxix", 'x'));
            Console.WriteLine(test("abxdddca", 'a'));
            Console.WriteLine(test("xabjbhtrb", 'b'));

            Console.ReadKey();
        }

        private static string test(string s, char x)
        {
            for (int i = s.Length - 2; i > 0; i--)
            {
                if (s[i].Equals(x))
                    s = s.Remove(i, 1);
            }
            return s;
        }
    }
}