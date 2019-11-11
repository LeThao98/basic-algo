using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        conditional-statement
        Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height.
    */

    public class Program
    {
        private static void Main(string[] args)
        {
            float PerHeight;
            Console.Write("\n\n");
            Console.Write("Accept the height of a person in centimeter and categorize them:\n");
            Console.Write("----------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the height of the person (in centimetres):");
            PerHeight = Convert.ToInt32(Console.ReadLine());

            if (PerHeight < 150.0)
                Console.Write("The person is Dwarf. \n\n");
            else if ((PerHeight >= 150.0) && (PerHeight <= 165.0))
                Console.Write("The person is  average heighted. \n\n");
            else if ((PerHeight >= 165.0) && (PerHeight <= 195.0))
                Console.Write("The person is taller. \n\n");
            else
                Console.Write("Abnormal height.\n\n");
            Console.ReadKey();
        }
    }
}