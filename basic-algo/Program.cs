using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        structure 10
        Write a program in C# Sharp to implement a method that returns a structure including calling the method and using its value.
     */

    public struct SampStru
    {
        private double val;

        public double Value
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
            }
        }

        public double Read()
        {
            return double.Parse(Console.ReadLine());
        }
    }

    public struct Square
    {
        private SampStru ln;
        private SampStru ht;

        public SampStru Length
        {
            get { return ln; }
            set { ln = value; }
        }

        public SampStru Breadth
        {
            get { return ht; }
            set { ht = value; }
        }

        public void NewSquare()
        {
            SampStru rct = new SampStru();
            Console.WriteLine("\nInput the dimensions of the Square( equal length and breadth ) : ");
            ln = SqrLength();
            Console.Write("breadth : ");
            ht.Value = rct.Read();
        }

        public SampStru SqrLength()
        {
            SampStru rct = new SampStru();

            Console.Write("length : ");
            rct.Value = rct.Read();
            return rct;
        }
    }

    public class Program
    {
        private static void Main()
        {
            Console.Write("\n\nMethod that returns a structure  :\n");
            Console.Write("--------------------------------------\n");
            var Sqre = new Square();
            Sqre.NewSquare();
            Console.WriteLine();
            Console.WriteLine("Perimeter and Area of the square :");
            Console.WriteLine("Length:    {0}", Sqre.Length.Value);
            Console.WriteLine("Breadth:    {0}", Sqre.Breadth.Value);
            Console.WriteLine("Perimeter: {0}", (Sqre.Length.Value + Sqre.Breadth.Value) * 2);
            Console.WriteLine("Area:      {0}\n", Sqre.Length.Value * Sqre.Breadth.Value);
            Console.ReadKey();
        }
    }
}