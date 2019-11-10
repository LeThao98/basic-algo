using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to create a new list from a given list of integers where each integer multiplied by itself three times.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> mylist = test(new List<int>(new[] { 1, 2, 3, 4 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadKey();
        }

        public static List<int> test(List<int> nums)
        {
            IEnumerable<int> squared = nums.Select(x => x * x * x);
            return squared.ToList<int>();
        }
    }
}