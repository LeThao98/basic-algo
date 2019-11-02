using System;

namespace basic_algo
{
    /*
         Write a C# Sharp program to create a new string which is n (non-negative integer )copies of the the first 3 characters of a given string.
         If the length of the given string is less than 3 then return n copies of the string.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("Python", 2));
            Console.WriteLine(test("Python", 3));
            Console.WriteLine(test("JS", 3));

            Console.ReadKey();
        }

        private static string test(string str, int n)
        {
            string result = string.Empty;
            if (str.Length < 3)
            {
                for (int i = 0; i < n; i++)
                {
                    result += str;
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    result += str.Substring(0, 3);
                }
                result += str.Substring(3);
            }
            return result;
        }
    }
}