using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
     * data_types
        Write a C# Sharp program that takes a number and a width also a number, as input and then displays a 
        triangle of that width, using that number.
    */

    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int num = Convert.ToInt32( Console.ReadLine() );
 
            Console.Write("Input the desired width: ");
            int width = Convert.ToInt32( Console.ReadLine() );
 
            int height = width;   
            for (int row=0; row < height; row++)
            {
                for (int column=0; column < width; column++)
                {
                    Console.Write( num );
                }
 
            Console.WriteLine();
            width--;
            }
        }
    }
}