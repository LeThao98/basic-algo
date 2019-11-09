using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to check a given array of integers and return true if the array contains three increasing adjacent numbers.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 2, 3, 5, 3, 7 }));
            Console.WriteLine(test(new[] { 3, 7, 5, 5, 3, 7 }));
            Console.WriteLine(test(new[] { 3, 7, 5, 5, 6, 7, 5 }));
            Console.ReadKey();
        }

        public static bool test(int[] numbers)
        {
            for (int i = 0; i <= numbers.Length - 3; i++)
            {
                if (numbers[i] == numbers[i + 1] - 1
                    && numbers[i] == numbers[i + 2] - 2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}