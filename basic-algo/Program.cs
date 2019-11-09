using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to check a given array of integers and return true if every 5 that appears
        in the given array is next to another 5.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 3, 5, 5, 3, 7 }));
            Console.WriteLine(test(new[] { 3, 5, 5, 4, 1, 5, 7 }));
            Console.WriteLine(test(new[] { 3, 5, 5, 5, 5, 5 }));
            Console.WriteLine(test(new[] { 2, 4, 5, 5, 6, 7, 5 }));
            Console.ReadKey();
        }

        public static bool test(int[] numbers)
        {
            int arr_len = numbers.Length;
            bool flag = true;

            for (int i = 0; i < arr_len; i++)
            {
                if (numbers[i] == 5)
                {
                    if ((i > 0 && numbers[i - 1] == 5) || (i < arr_len - 1 && numbers[i + 1] == 5)) flag = true;
                    else if (i == arr_len - 1) flag = false;
                    else return false;
                }
            }
            return flag;
        }
    }
}