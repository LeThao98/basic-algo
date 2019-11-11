using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        conditional-statement
        Write a C# Sharp program to check whether a given number is positive or negative.
    */

    public class Program
    {
        private static void Main(string[] args)
        {
            int int1;
            Console.Write("\n\n");
            Console.Write("Check whether a number is positive or negative:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input an number: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            if (int1 > 0)
                Console.WriteLine("{0} is an positive number.\n", int1);
            else
                Console.WriteLine("{0} is an negative number.\n", int1);
            Console.ReadKey();
        }
    }
}