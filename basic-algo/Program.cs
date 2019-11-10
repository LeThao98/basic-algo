using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to create a new list from a given list of integers removing those values end with 7.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> mylist = test(new List<int>(new int[] { 10, 22, 35, 47, 53, 67 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadKey();
        }

        public static List<int> test(List<int> nums)
        {
            return nums.Where(n => n % 10 < 7).ToList();
        }
    }
}