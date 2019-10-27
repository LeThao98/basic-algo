using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        Write a C# Sharp program to compute the sum of the two given integer values.
        If the two values are the same, then return triple their sum. Go to the editor

        Expected Output:
            3
            5
            12
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(act(1, 2));
            Console.WriteLine(act(2, 3));
            Console.WriteLine(act(2, 2));

            Console.ReadKey();
        }

        private static int act(int a, int b)
        {
            return a == b ? 3 * (a + b) : a + b;
        }
    }
}