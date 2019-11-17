using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        structure 07
        Write a program in C# Sharp to demonstrates struct initialization using both default and parameterized constructors.
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
            Console.Write("\n\nStruct declares using default and parameterized constructors :\n");
            Console.Write("-----------------------------------------------------------------\n");
            newStruct myPoint1 = new newStruct();
            newStruct myPoint2 = new newStruct(25, 25);
            Console.Write("\nnewStruct 1: ");
            Console.WriteLine("m = {0}, n = {1}", myPoint1.m, myPoint1.n);

            Console.Write("newStruct 2: ");
            Console.WriteLine("m = {0}, n = {1}", myPoint2.m, myPoint2.n);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}