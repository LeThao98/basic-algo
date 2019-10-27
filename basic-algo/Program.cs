using System;

namespace basic_algo
{
    /*
        Write a C# Sharp program to create a new string where 'if' is added to the front of a given string.
        If the string already begins with 'if', return the string unchanged.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(act("if else"));
            Console.WriteLine(act("esle"));

            Console.ReadKey();
        }

        private static string act(string str)
        {
            return str.StartsWith("if ") ? str : "if " + str;
        }
    }
}