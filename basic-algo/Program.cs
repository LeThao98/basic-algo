using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to compare two given strings and return the number of the positions
         where they contain the same length 2 substring.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("abcdefgh", "abijsklm"));
            Console.WriteLine(test("abcde", "osuefrcd"));
            Console.WriteLine(test("pqrstuvwx", "pqkdiewx"));

            Console.ReadKey();
        }

        private static int test(string s1, string s2)
        {
            int count = 0;
            for (int i = 0; i < s1.Length - 1; i++)
            {
                string firstString = s1.Substring(i, 2);
                for (int j = 0; j < s2.Length - 1; j++)
                {
                    string secondString = s2.Substring(j, 2);
                    if (secondString.Equals(firstString))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}