﻿using System;
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
            int dayno;

            Console.Write("\n\n");
            Console.Write("Accept day number and display its equivalent day name in word:\n");
            Console.Write("----------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input Day No : ");
            dayno = Convert.ToInt32(Console.ReadLine());

            switch (dayno)
            {
                case 1:
                    Console.Write("Monday \n");
                    break;

                case 2:
                    Console.Write("Tuesday \n");
                    break;

                case 3:
                    Console.Write("Wednesday \n");
                    break;

                case 4:
                    Console.Write("Thursday \n");
                    break;

                case 5:
                    Console.Write("Friday \n");
                    break;

                case 6:
                    Console.Write("Saturday \n");
                    break;

                case 7:
                    Console.Write("Sunday  \n");
                    break;

                default:
                    Console.Write("Invalid day number. \nPlease try again ....\n");
                    break;
            }

            Console.ReadKey();
        }
    }
}