using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace basic_algo
{
    /*
       Write a C# Sharp program to remove all "a" in each string in given list of strings and return the new string.
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> mylist = test(new List<string>(new string[] { "abc", "cdaef", "js", "php" }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadKey();
        }

        public static List<string> test(List<string> str)
        {
            return str.Select(x => x.Replace("a", "")).ToList();
        }
    }
}