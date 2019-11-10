using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
     * data_types
        Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd.
    */

    public class Program
    {
        private static void Main(string[] args)
        {
            int n1, n2;
            bool bothEven;
            Console.Write("Input First number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            //bothEven = ((n1%2!=0) || (n1%2!=0))? false:true;
            bothEven = ((n1 % 2 == 0)
                && (n2 % 2 == 0)) ? true : false;

            Console.WriteLine(bothEven ?
              "there're numbers bothEven" :
              "there's a number odd");
            Console.ReadKey();
        }
    }
}