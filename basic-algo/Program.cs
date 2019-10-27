using System;

namespace basic_algo
{
    /*
       Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(act(3));
            Console.WriteLine(act(14));
            Console.WriteLine(act(13));
            Console.WriteLine(act(21));

            Console.ReadKey();
        }

        private static int act(int x)
        {
            if (x % 3 == 0 && x % 7 == 0)
                return 3;
            else if (x % 7 == 0)
                return 2;
            else if (x % 3 == 0)
                return 1;
            else
                return 0;
        }
    }
}