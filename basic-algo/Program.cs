using System;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive,
         or they are both in the range 50..60 inclusive.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(78, 95));
            Console.WriteLine(test(25, 35));
            Console.WriteLine(test(40, 50));
            Console.WriteLine(test(55, 60));

            Console.ReadKey();
        }

        private static bool test(int x, int y)
        {
            return ((x >= 40 && x <= 50) && (x >= 40 && x <= 50)) || ((x >= 50 && x <= 60) && (x >= 50 && x <= 60));
        }
    }
}