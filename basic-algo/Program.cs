using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
         Write a C# Sharp program to check if y is greater than x, and z is greater than y from three given integers x,y,z.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(1, 2, 3));
            Console.WriteLine(test(4, 5, 6));
            Console.WriteLine(test(-1, 1, 0));

            Console.ReadKey();
        }

        private static bool test(int x, int y, int z)
        {
            return y > x && z > y;
        }
    }
}