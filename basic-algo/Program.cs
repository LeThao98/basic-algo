using System;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a".
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test("caabb"));
            Console.WriteLine(test("babaaba"));
            Console.WriteLine(test("aaaaa"));

            Console.ReadKey();
        }

        private static bool test(string str)
        {
            for (int i = 1; i < str.Length - 1; i++)
            {
                if (str[i] == 'a')
                    if (str[i + 1] == 'a')
                        return true;
                    else return false;
            }
            return false;
        }
    }
}