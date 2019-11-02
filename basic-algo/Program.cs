using System;

namespace basic_algo
{
    /*
       Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(100, 199));
            Console.WriteLine(test(250, 300));
            Console.WriteLine(test(105, 190));

            Console.ReadKey();
        }

        private static bool test(int x, int y)
        {
            return x >= 100 && x <= 200 | y >= 100 && y <= 200;
        }
    }
}