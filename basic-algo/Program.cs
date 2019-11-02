using System;

namespace basic_algo
{
    /*
         Write a C# Sharp program to convert the last 3 characters of a given string in upper case. If the length
         of the string has less than 3 then uppercase all the characters.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("Javascript"));
            Console.WriteLine(test("js"));
            Console.WriteLine(test("PHP"));

            Console.ReadKey();
        }

        private static string test(string str)
        {
            return str.Length < 3 ? str.ToUpper() : str.Substring(0, str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
        }
    }
}