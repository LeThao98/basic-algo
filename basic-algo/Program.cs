using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        searching-and-sorting-algorithm: Insertion  Sort
        Write a C# Sharp program to sort a list of elements using Insertion  sort.
    */

    public class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[10] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("\nOriginal Array Elements :");
            PrintIntegerArray(numbers);
            Console.WriteLine("\nSorted Array Elements :");
            PrintIntegerArray(InsertionSortByShift(numbers));
            Console.WriteLine("\n");
            Console.ReadKey();
        }

        private static int[] InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        private static int[] InsertionSortByShift(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int j = i;
                int insertionValue = array[i];
                while (j > 0 && array[j - 1] > insertionValue)
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = insertionValue;
            }
            return array;
        }

        private static void PrintIntegerArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}