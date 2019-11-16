using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algo
{
    /*
        searching-and-sorting-algorithm: Selection Sort
        Write a C# Sharp program to sort a list of elements using Selection sort.
    */

    public class Program
    {
        private static void Main(string[] args)
        {
            SelectionSort selectionSort = new SelectionSort(10);
            selectionSort.Sort();
            Console.ReadKey();
        }
    }

    public class SelectionSort
    {
        private List<int> list = new List<int>();

        public SelectionSort(int Length)
        {
            Random random = new Random();
            Console.Write("Original Array: ");
            for (int i = 0; i < Length; i++)
            {
                list.Add(random.Next(0, 100));
                Console.Write("{0} ", list[i]);
            }
        }

        private void Swap(int a, int b)
        {
            int temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }

        public void Sort()
        {
            for (int i = 0; i < list.Count; i++)
            {
                int minIndex = i;
                for (int j = i; j < list.Count; j++)
                {
                    if (list[j] < list[minIndex]) minIndex = j;
                }
                Swap(i, minIndex);
                Print();
            }
        }

        private void Print()
        {
            Console.WriteLine();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0} ", list[i]);
            }
        }
    }
}