using System;

namespace basic_algo
{
    /*
       Write a C# Sharp program to create a new string taking the first 3 characters of a given string and
       return the string with the 3 characters added at both the front and back.
       If the given string length is less than 3, use whatever characters are there.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(act("Python"));
            Console.WriteLine(act("xy"));

            Console.ReadKey();
        }

        private static string act(string x)
        {
            return x.Length < 3 ? x + x + x : x.Substring(0, 3) + x + x.Substring(0, 3);
        }
    }
}