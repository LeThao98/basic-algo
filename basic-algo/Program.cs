using System;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string.
         If it appears return a string without 'yt' otherwise return the original string.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("ytade"));
            Console.WriteLine(test("jsues"));

            Console.ReadKey();
        }

        private static string test(string str)
        {
            return str.Substring(1).StartsWith("yt") ? str.Substring(0, 1) + str.Substring(3) : str;
        }
    }
}