using System;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check if a given string contains between 2 and 4 'z' character.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("frizz"));
            Console.WriteLine(test("zane"));
            Console.WriteLine(test("Zazz"));
            Console.WriteLine(test("false"));

            Console.ReadKey();
        }

        private static bool test(string str)
        {
            int count = 0;
            foreach (char item in str)
            {
                if (item == 'z') count++;
            }
            return count > 1 && count < 4;
        }
    }
}