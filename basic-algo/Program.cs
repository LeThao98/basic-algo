using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        Write a C# Sharp program to get the absolute difference between n and 51.
        If n is greater than 51 return triple the absolute difference.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(act(52));
            Console.WriteLine(act(50));
            Console.WriteLine(act(51));

            Console.ReadKey();
        }

        private static int act(int a)
        {
            return a > 51 ? 3 * (a - 51) : a - 51;
        }
    }
}