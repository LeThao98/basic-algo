using System;

namespace basic_algo
{
    /*
         Write a C# Sharp program to find the larger value from two positive integer values that is in the range 20..30 inclusive,
         or return 0 if neither is in that range.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(78, 95));
            Console.WriteLine(test(20, 30));
            Console.WriteLine(test(21, 25));
            Console.WriteLine(test(28, 28));

            Console.ReadKey();
        }

        private static int test(int x, int y)
        {
            if ((x >= 20 && x <= 30) && (y >= 20 && y <= 30))
            {
                return Math.Max(x, y);
            }
            else if (x >= 20 && x <= 30)
                return x;
            else if (y >= 20 && y <= 30)
                return y;
            else return 0;
        }
    }
}