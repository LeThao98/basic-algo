using System;

namespace basic_algo
{
    /*
         Write a C# Sharp program to create a new string made of every other character starting with the first from a given string.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("PHP"));
            Console.WriteLine(test("JS"));

            Console.ReadKey();
        }

        private static string test(string s)
        {
            string result = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += s[i];
                }
            }
            return result;
        }
    }
}