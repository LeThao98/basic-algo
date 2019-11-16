using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        structure
        Write a program in C# Sharp to create a structure and assign the value and call it.
     */

    // crate a class
    internal class aNewClass
    {
        public int x;
        public int y;
    }

    //create a structure
    internal struct aNewStruc
    {
        public int x;
        public int y;
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("\n\nCreate a structure and Assign the Value and call it :\n");
            Console.Write("---------------------------------------------------------\n");
            aNewClass ClassNum1 = new aNewClass();
            ClassNum1.x = 1;
            ClassNum1.y = 2;
            //	ClassNum2 is ClassNum1 type
            aNewClass ClassNum2 = ClassNum1;
            ClassNum1.x = 3;
            ClassNum1.y = 4;
            Console.WriteLine("\nAssign in Class:       x:{0},   y:{1}", ClassNum2.x, ClassNum2.y);
            aNewStruc StrucNum1 = new aNewStruc();
            StrucNum1.x = 1;
            StrucNum1.y = 2;
            //	StrucNum2 is StrucNum1 type
            aNewStruc StrucNum2 = StrucNum1;
            StrucNum1.x = 3;
            StrucNum1.y = 4;
            Console.WriteLine("Assign in Structure:   x:{0},    y:{1}\n\n", StrucNum2.x, StrucNum2.y);
            Console.ReadKey();
        }
    }
}