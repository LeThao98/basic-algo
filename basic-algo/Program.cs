using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        file-handling 01
        Write a program in C# Sharp to remove a file from the disk.
     */

    public class Program
    {
        private static void Main()
        {
            string fileName = @"mytest.txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine(" The file {0} deleted successfully.\n", fileName);
            }
            else
            {
                Console.WriteLine(" File does not exist.");
            }
            Console.ReadKey();
        }
    }
}