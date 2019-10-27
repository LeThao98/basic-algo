using System;

namespace basic_algo
{
    /*
        Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(act("Python"));
            Console.WriteLine(act("x"));

            Console.ReadKey();
        }

        private static string act(string str)
        {
            return str.Length > 1 ?
                str.Substring(str.Length - 1, 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1)
                :
                str;
        }
    }
}