using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        structure
        Write a program in C# Sharp to declare a simple structure.
    */

    internal struct w3rStruct
    {
        public int x;
        public int y;
        private int z;
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("\n\nDeclare a simple structure :\n");
            Console.Write("--------------------------------\n");
            w3rStruct w3st = new w3rStruct();
            w3st.x = 15;
            w3st.y = 25;
            int sum = w3st.x + w3st.y;
            Console.WriteLine("The sum of x and y is {0}\n", sum);
            Console.ReadKey();
        }
    }
}