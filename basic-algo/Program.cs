using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        Write a C# Sharp program to check two given integers,
        and return true if one of them is 30 or if their sum is 30.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(act(30, 0));
            Console.WriteLine(act(0, 30));
            Console.WriteLine(act(25, 5));
            Console.WriteLine(act(25, 9));

            Console.ReadKey();
        }

        private static bool act(int x, int y)
        {
            return x == 30 || y == 30 || x + y == 30;
        }
    }
}