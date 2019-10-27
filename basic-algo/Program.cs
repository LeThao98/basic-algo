using System;

namespace basic_algo
{
    /*
        Write a C# Sharp program to check  a given integer
        and return true if it is within 10 of 100 or 200.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(act(103));
            Console.WriteLine(act(90));
            Console.WriteLine(act(89));

            Console.ReadKey();
        }

        private static bool act(int x)
        {
            //return (x >= 90 && x <= 110) || (x >= 190 && x <= 210);
            return Math.Abs(100 - x) <= 10 || Math.Abs(200 - x) <= 10;
        }
    }
}