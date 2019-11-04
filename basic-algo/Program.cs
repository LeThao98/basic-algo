using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to create a new string of the characters at indexes 0,1, 4,5, 8,9 ... from a given string.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("JavaScript"));
            Console.WriteLine(test("HTML"));

            Console.ReadKey();
        }

        private static string test(string s)
        {
            int i = 0;
            string result = string.Empty;
            while (i < s.Length)
            {
                if (i % 4 == 0)
                {
                    if (i + 1 <= s.Length)
                    {
                        result += s.Substring(i, 2);
                        i += 4;
                    }
                    else
                    {
                        result += s.Substring(i, 1);
                        i++;
                    }
                }
                else
                    i++;
            }
            return result;
        }
    }
}