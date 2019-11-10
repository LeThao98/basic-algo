using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace basic_algo
{
    /*
        Write a C# Sharp program to create a new list from a given list of strings where each element
        has "#" added at the beginning and end position.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> mylist = test(new List<string>(new string[] { "1", "2", "3", "4" }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadKey();
        }

        public static List<string> test(List<string> nums_str)
        {
            IEnumerable<string> s = nums_str.Select(x => "#" + x + "#");
            return s.ToList();
        }
    }
}