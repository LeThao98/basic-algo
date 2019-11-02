using System;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check the largest number among three given integers.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(1, 2, 3));
            Console.WriteLine(test(1, 3, 2));
            Console.WriteLine(test(1, 1, 1));
            Console.WriteLine(test(1, 2, 2));

            Console.ReadKey();
        }

        private static int test(int x, int y, int z)
        {
            return Math.Max(x, Math.Max(y, z));
        }
    }
}