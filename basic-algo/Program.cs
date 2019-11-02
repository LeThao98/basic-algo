using System;

namespace basic_algo
{
    /*
       Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces),
       and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            act();

            Console.ReadKey();
        }

        private static void act()
        {
            int x;
            Console.WriteLine("Enter a digit: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {0} {0} {0}", x);
            Console.WriteLine("{0}{0}{0}{0}", x);
            Console.WriteLine("{0} {0} {0} {0}", x);
            Console.WriteLine("{0}{0}{0}{0}", x);
        }
    }
}