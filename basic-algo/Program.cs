using System;

namespace basic_algo
{
    /*
        Write a C# Sharp program to create a new array after replacing all the values 5 with 0 shifting all zeros to right direction.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 2, 5, 3, 5, 7, 5, 9, 11 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadKey();
        }

        public static int[] test(int[] numbers)
        {
            int flag = 0;
            int[] res = new int[numbers.Length];
            for (int i = 0; i < res.Length; i++)
            {
                if (numbers[i] != 5)
                {
                    res[flag++] = numbers[i];
                }
            }
            return res;
        }
    }
}