using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to check a given array of integers, length 3 and create a new array.
       If there is a 5 in the given array immediately followed by a 7 then set 7 to 1.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 5, 7 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();
        }

        public static int[] test(int[] numbers)
        {
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i].Equals(5) && numbers[i + 1].Equals(7))
                    numbers[i + 1] = 1;
            }
            return numbers;
        }
    }
}