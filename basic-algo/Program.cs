using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to check if an array of integers contains a 3 next to a 3 or a 5 next to a 5 or both.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 5, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(test(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 5, 5, 7, 8, 10 }));
            Console.ReadKey();
        }

        public static bool test(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++) if ((numbers[i] == 3 && numbers[i + 1] == 3) || (numbers[i] == 5 && numbers[i] == 5)) return true;
            return false;
        }
    }
}