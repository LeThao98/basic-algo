using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        conditional-statement
        Write a C program to check whether a given number is even or odd.
    */

    public class Program
    {
        private static void Main(string[] args)
        {
            int int1;
            Console.Write("\n\n");
            Console.Write("Check whether a number is even or odd :\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input an number: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            if (int1 % 2 == 0)
                Console.WriteLine("{0} is an even integer.\n", int1);
            else
                Console.WriteLine("{0} is an odd integer.\n", int1);
            Console.ReadKey();
        }
    }
}