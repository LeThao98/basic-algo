using System;

namespace basic_algo
{
    /*
        Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string.
        If the given string length is less than 2 return the original string.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(act("C Sharp"));
            Console.WriteLine(act("JS"));
            Console.WriteLine(act("a"));

            Console.ReadKey();
        }

        private static string act(string str)
        {
            return str.Length >= 2 ?
                str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2)
                :
                str;
        }
    }
}