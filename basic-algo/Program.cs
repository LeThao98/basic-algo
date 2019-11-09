using System;
using System.Diagnostics;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to check a given array of integers and return true if the given array contains either 2 even or 2 odd
        values all next to each other.
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
            //int tot_odd = 0, tot_even = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (tot_odd < 2 && tot_even < 2)
            //    {
            //        if (numbers[i] % 2 == 0)
            //        {
            //            tot_even++;
            //            tot_odd = 0;
            //        }
            //        else
            //        {
            //            tot_odd++;
            //            tot_even = 0;
            //        }
            //    }
            //}
            //return tot_odd == 2 || tot_even == 2;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i + 1] % 2 == 0)
                    return true;
                if (numbers[i] % 2 != 0 && numbers[i + 1] % 2 != 0)
                    return true;
            }
            return false;
        }
    }
}