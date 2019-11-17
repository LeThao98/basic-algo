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
        Write a program in C# Sharp to create a blank file in the disk newly.
     */

    public class Program
    {
        private static void Main()
        {
            string fileName = @"mytest.txt";
            try
            {
                Console.Write("\n\n Create a file named mytest.txt in the disk:\n");
                Console.Write("--------------------------------------------------\n");
                //Create the file
                using (FileStream fileStream = File.Create(fileName))
                {
                    Console.WriteLine(" A file created with name mytest.txt\n\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}