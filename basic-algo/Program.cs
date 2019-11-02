using System;

namespace basic_algo
{
    /*
         Write a C# Sharp program to create a new string which is n (non-negative integer ) copies of a given string.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("JS", 2));
            Console.WriteLine(test("JS", 3));
            Console.WriteLine(test("JS", 1));

            Console.ReadKey();
        }

        private static string test(string str, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += str;
            }
            return result;
        }
    }
}