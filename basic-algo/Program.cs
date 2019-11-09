using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to check a given array of integers and return true if the given array contains two 5's next to each other, or two 5 separated by one element.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 5, 5, 1, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(test(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 1, 5, 5, 7, 8, 10 }));
            Console.ReadKey();
        }

        public static bool test(int[] numbers)
        {
            int len = numbers.Length;

            for (int i = 0; i < len - 1; i++)
            {
                if (numbers[i] == 5 && numbers[i + 1] == 5) return true;
                if (i + 2 < len && numbers[i] == 5 && numbers[i + 2] == 5) return true;
            }

            return false;
        }
    }
}