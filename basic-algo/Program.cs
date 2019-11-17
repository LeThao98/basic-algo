using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        structure 06
        Write a program in C# Sharp to declares a struct with a property, a method, and a private field.
     */

    internal struct newStruct
    {
        private int num;

        public int n
        {
            get
            {
                return num;
            }
            set
            {
                if (value < 50)
                    num = value;
            }
        }

        public void clsMethod()
        {
            Console.WriteLine("\nThe stored value is: {0}\n", num);
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("\n\nDeclares a struct with a property, amethod, a field:\n");
            Console.WriteLine("-------------------------------------------------------");
            newStruct newStruct = new newStruct();
            newStruct.n = 15;
            newStruct.clsMethod();

            Console.ReadKey();
        }
    }
}