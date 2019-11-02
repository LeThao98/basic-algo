using System;

namespace basic_algo
{
    /*
       Write a C# Sharp program to check if one given temperatures is less than 0 and the other is greater than 100.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(act(120, -1));
            Console.WriteLine(act(-1, 120));
            Console.WriteLine(act(2, 120));

            Console.ReadKey();
        }

        private static bool act(int x, int y)
        {
            return x < 0 && y > 100 || y < 0 && x > 100;
        }
    }
}