using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        searching-and-sorting-algorithm: Shell Sort
        Write a C# Sharp program to sort a list of elements using Shell sort.
    */

    public class Program
    {
        private static void Main(string[] args)
        {
            //int[] arr = new int[] { 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            int[] arr = new int[] { 62, 83, 18, 53, 07, 17, 95, 86, 47, 69, 25, 28 };
            int n;

            n = arr.Length;
            Console.WriteLine("Original Array Elements :");
            ShowArrayElements(arr);
            ShellSort(arr);
            Console.WriteLine("\nSorted Array Elements :");
            ShowArrayElements(arr);

            Console.ReadKey();
        }

        private static int[] ShellSort(int[] a)
        {
            int n = a.Length;
            int gap = 5;
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int j;
                    int temp = a[i];
                    for (j = i; j >= gap && temp < a[j - gap];)
                    {
                        a[j] = a[j - gap];
                        j -= gap;
                    }
                    a[j] = temp;
                }
                if (gap / 2 != 0)
                {
                    gap /= 2;
                }
                else gap = 0;
            }
            return a;
        }

        private static void ShowArrayElements(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n");
        }
    }
}