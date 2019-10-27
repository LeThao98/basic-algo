using System;

namespace basic_algo
{
    /*
        Write a C# Sharp program to remove the character in a given position of a given string.
        The given position will be in the range 0.str.length()-1 inclusive).
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(act("Python", 1));
            Console.WriteLine(act("Python", 0));
            Console.WriteLine(act("Python", 4));

            Console.ReadKey();
        }

        private static string act(string str, int position)
        {
            return str.Remove(position, 1);
        }
    }
}