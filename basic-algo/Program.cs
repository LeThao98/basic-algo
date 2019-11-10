using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to create a new list of the rightmost digits from a given list of positive integers.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> mylist = test(new List<int>(new int[] { 10, 22, 35, 41 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadKey();
        }

        public static List<int> test(List<int> nums)
        {
            IEnumerable<int> e = nums.Select(x => x % 10);
            return e.ToList();
        }
    }
}