using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to check a given array of integers and return true if the value 5 appears 5 times
        and there are no 5 next to each other.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 3, 5, 1, 5, 3, 5, 7, 5, 1, 5 }));
            Console.WriteLine(test(new[] { 3, 5, 5, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 3, 5, 2, 5, 4, 5, 7, 5, 8, 5 }));
            Console.WriteLine(test(new[] { 2, 4, 5, 5, 5, 5 }));
            Console.ReadKey();
        }

        public static bool test(int[] numbers)
        {
            bool flag = false;
            int five = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 5 && !flag)
                {
                    five++;
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }

            return five == 5;
        }
    }
}