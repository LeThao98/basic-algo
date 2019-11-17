using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        structure 09
        Write a program in C# Sharp to insert the information of two books.
     */

    internal struct book
    {
        public string title, author;
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            int nobook = 1000;
            book[] books = new book[nobook];
            int i, j, n = 1, k = 1;
            Console.Write("\n\nInsert the information of two books :\n");
            Console.Write("-----------------------------------------\n");
            for (j = 0; j <= n; j++)
            {
                Console.WriteLine("Information of book {0} :", k);

                Console.Write("Input name of the book : ");
                books[j].title = Console.ReadLine();

                Console.Write("Input the author : ");
                books[j].author = Console.ReadLine();
                k++;
                Console.WriteLine();
            }

            for (i = 0; i <= n; i++)
            {
                Console.WriteLine("{0}: Title = {1},  Author = {2}", i + 1, books[i].title, books[i].author);
                Console.WriteLine();
            }
            Console.WriteLine("\nPress any key to exit."); ;
            Console.ReadKey();
        }
    }
}