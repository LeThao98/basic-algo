using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to create a new list from a given list of integers where each element is multiplied by 3.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> mylist = test(new List<int>(new int[] { 1, 2, 3, 4 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadKey();
        }

        public static List<int> test(List<int> nums)
        {
            IEnumerable<int> doubled = nums.Select(x => x *= 3);
            return doubled.ToList<int>();
        }
    }
}