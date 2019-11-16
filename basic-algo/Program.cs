using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        searching-and-sorting-algorithm: Quick Sort
        Write a C# Sharp program to sort a list of elements using Quick sort.
    */

    public class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            Console.WriteLine("Original array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            QuickSort(arr, arr.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Sorted array : ");

            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Console.ReadKey();
        }

        private static void swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        private static void QuickSort(int[] a, int maxIndex, int minIndex = 0)
        {
            Random random = new Random();
            int privotIndex = random.Next(maxIndex - minIndex);
            int privot = a[minIndex + privotIndex];
            int i = minIndex;
            int j = maxIndex;
            while (i <= j)
            {
                while (a[i] < privot) i++;
                while (a[j] > privot) j--;
                if (i <= j)
                {
                    swap(ref a[i], ref a[j]);
                    i++;
                    j--;
                }
            }
            if (j > minIndex) QuickSort(a, j);
            if (i < maxIndex) QuickSort(a, maxIndex, i);
        }
    }
}