using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to create a new list from a given list of strings where strings will be in upper case in new string.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> mylist = test(new List<string>(new string[] { "Abc", "cdef", "js", "php" }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadKey();
        }

        public static List<string> test(List<string> str)
        {
            IEnumerable<string> s = str.Select(x => x.ToUpper());
            return s.ToList();
        }
    }
}