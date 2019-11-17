using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        structure 08
        Write a program in C# Sharp to demonstrates struct initialization without using the new operator.
     */

    internal struct newStruct
    {
        public int m, n;

        public newStruct(int pt1, int pt2)
        {
            m = pt1;
            n = pt2;
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("\n\nStruct initialization without using the new operator :\n");
            Console.Write("----------------------------------------------------------\n"); newStruct myPoint1 = new newStruct();
            newStruct myPoint;
            myPoint.m = 30;
            myPoint.n = 20;
            Console.Write("\nnewStruct : ");
            Console.WriteLine("m = {0}, n = {1}", myPoint.m, myPoint.n);

            Console.WriteLine("\nPress any key to exit."); ;
            Console.ReadKey();
        }
    }
}