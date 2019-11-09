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
            Console.WriteLine(test(new[] { 3, 5, 1, 3, 7 }));
            Console.WriteLine(test(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(test(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 2, 5, 5, 7, 8, 10 }));
            Console.ReadKey();
        }

        public static bool test(int[] numbers)
        {
            bool three = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (three && numbers[i] == 5) return true;
                if (numbers[i] == 3) three = true;
            }
            return false;
        }
    }
}