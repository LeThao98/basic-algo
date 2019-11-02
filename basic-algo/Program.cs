using System;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check if two given non-negative integers have the same last digit.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(123, 456));
            Console.WriteLine(test(12, 512));
            Console.WriteLine(test(7, 87));
            Console.WriteLine(test(12, 45));

            Console.ReadKey();
        }

        private static bool test(int x, int y)
        {
            return x % 10 == y % 10;
        }
    }
}