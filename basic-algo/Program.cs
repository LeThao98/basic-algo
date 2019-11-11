using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        conditional-statement
        Write a program in C# Sharp to read any day number in integer and display day name in the word.
    */

    public class Program
    {
        private static void Main(string[] args)
        {
            int cdigit;

            Console.Write("\n\n");
            Console.Write("Accept digit and display in word:\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");

            Console.Write("Input Digit(0-9) : ");
            cdigit = Convert.ToInt32(Console.ReadLine());

            switch (cdigit)
            {
                case 0:
                    Console.Write("Zero\n");
                    break;

                case 1:
                    Console.Write("one\n");
                    break;

                case 2:
                    Console.Write("Two\n");
                    break;

                case 3:
                    Console.Write("Three\n");
                    break;

                case 4:
                    Console.Write("Four\n");
                    break;

                case 5:
                    Console.Write("Five\n");
                    break;

                case 6:
                    Console.Write("Six\n");
                    break;

                case 7:
                    Console.Write("Seven\n");
                    break;

                case 8:
                    Console.Write("Eight\n");
                    break;

                case 9:
                    Console.Write("Nine\n");
                    break;

                default:
                    Console.Write("invalid digit. \nPlease try again ....\n");
                    break;
            }

            Console.ReadKey();
        }
    }
}