using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        searching-and-sorting-algorithm: Counting Sort
        Write a C# Sharp program to sort a list of elements using Counting sort.
    */

    public class Program
    {
        private static void Main(string[] args)
        {
            int[] array = new int[10] { 2, 5, -4, 11, 0, 8, 22, 67, 51, 6 };
            int[] sortedArray = new int[array.Length];
            Console.WriteLine("\n" + "Original array :");
            foreach (int aa in array)
                Console.Write(aa + " ");
            int minVal = array[0], maxVal = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxVal) maxVal = array[i];
                if (array[i] < minVal) minVal = array[i];
            }
            int[] counts = new int[maxVal - minVal + 1];
            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i] - minVal]++;
            }
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }
            for (int i = 0; i < array.Length; i++)
            {
                sortedArray[counts[array[i] - minVal]--] = array[i];
            }
            Console.Write(counts);
            Console.WriteLine("\n" + "Sorted array :");
            foreach (int aa in sortedArray)
                Console.Write(aa + " ");
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}