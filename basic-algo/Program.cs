using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        structure
        Write a program in C# Sharp to declare a simple structure and use of static fields inside a struct.
    */

    internal struct w3rStruct
    {
        public static int x = 15;
        public static int y = 25;
        public int z;
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("\n\nStructure with the use of static fields inside a struct :\n");
            Console.Write("--------------------------------\n");
            int sum = w3rStruct.x + w3rStruct.y;
            w3rStruct w3R = new w3rStruct();
            w3R.z = sum;
            Console.WriteLine("The sum of x and y is {0}\n", w3R.z);
            Console.ReadKey();
        }
    }
}