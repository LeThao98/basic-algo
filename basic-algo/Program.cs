using System;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check which number nearest to the value 100 among two given integers.
         Return 0 if the two numbers are equal.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(78, 95));
            Console.WriteLine(test(95, 95));
            Console.WriteLine(test(99, 70));

            Console.ReadKey();
        }

        private static int test(int x, int y)
        {
            if (x == y)
                return 0;
            else
            {
                return Math.Abs(x - 100) > Math.Abs(y - 100) ? y : x;
            }
        }
    }
}