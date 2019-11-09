using System;

namespace basic_algo
{
    /*
        Write a C# Sharp program to create a new array from a given array of integers shifting all zeros to left direction.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 2, 0, 3, 5, 7, 0, 9, 11 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadKey();
        }

        public static int[] test(int[] numbers)
        {
            int pos = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    numbers[i] = numbers[pos];
                    numbers[pos++] = 0;
                }
            }
            return numbers;
        }
    }
}