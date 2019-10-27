using System;

namespace basic_algo
{
    /*
       Write a C# Sharp program to create  a new string with the last char
       added at the front and back of a given string of length 1 or more.
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
            string last = str.Substring(str.Length - 1, 1);
            return last + str + last;
        }
    }
}